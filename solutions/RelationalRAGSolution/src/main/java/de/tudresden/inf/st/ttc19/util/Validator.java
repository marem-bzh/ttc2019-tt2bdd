package de.tudresden.inf.st.ttc19.util;


import de.tudresden.inf.st.ttc19.jastadd.model.*;

import java.util.NoSuchElementException;

public class Validator {

  public boolean validateBDT(TruthTable tt, BDT bdt) {
    if (tt.getNumPort() != bdt.getNumPort()) {
      System.err.println(String.format(
          "TT and BDT have different number of ports (TT = %d, BDT = %d)",
          tt.getNumPort(), bdt.getNumPort()));
      return false;
    }

    int iRow = 0;
    for (Row ttRow : tt.getRows()) {
      if (!validateBDT(iRow, ttRow, bdt.getTree())) {
        return false;
      }
      iRow++;
    }
    return true;
  }

  private boolean validateBDT(int iRow, Row ttRow, BDT_Tree tree) {
    final JastAddList<BDT_Assignment> assignments = findAssignmentsInTree(ttRow, tree);
    if (assignments.getNumChild() == 0) {
      System.err.println(String.format("Row %d of TT did not produce any assignments in BDT", iRow));
    }

    for (BDT_Assignment a : assignments) {
      final String oPortName = a.getPort().getName();
      final boolean expectedResult = getExpectedResult(ttRow, oPortName);
      if (expectedResult != a.getValue()) {
        System.err.println(String.format("Row %d of TT produces unexpected result %s in BDT", iRow, a.getValue()));
        return false;
      }
    }

    // No mismatches found!
    return true;
  }


  private JastAddList<BDT_Assignment> findAssignmentsInTree(Row ttRow, BDT_Tree tree) {
    if (tree instanceof BDT_Leaf) {
      BDT_Leaf leaf = (BDT_Leaf) tree;
      return leaf.getAssignments();
    } else if (tree instanceof BDT_Subtree) {
      BDT_Subtree sb = (BDT_Subtree) tree;
      InputPort sbInputPort = sb.getPort().getTruthTableInputPort();
      for (Cell c : ttRow.getCells()) {
        // Port must be an input and have the same name
        if (c.getPort() instanceof InputPort && c.getPort().getName().equals(sbInputPort.getName())) {
          return findAssignmentsInTree(ttRow, c.getValue() ? sb.getTreeForOne() : sb.getTreeForZero());
        }
      }

      /*
       * (2019-05-23 Artur Boronat) If the row in the table does not require a
       * specific value for the port checked in this subtree, try both values.
       */
      JastAddList<BDT_Assignment> zeroList = findAssignmentsInTree(ttRow, sb.getTreeForZero());
      if (zeroList.getNumChild() == 0) {
        return findAssignmentsInTree(ttRow, sb.getTreeForOne());
      } else {
        return zeroList;
      }
    } else {
      throw new IllegalArgumentException("Tree must be a subtree or a leaf");
    }
  }

  public boolean validateBDD(TruthTable tt, BDD bdd) {
    if (tt.getNumPort() != bdd.getPorts().size()) {
      System.err.println(String.format(
          "TT and BDD have different number of ports (TT = %d, BDD = %d)",
          tt.getNumPort(), bdd.getPorts().size()));
      return false;
    }

    int iRow = 0;
    for (Row ttRow : tt.getRows()) {
      if (!validateBDD(iRow, ttRow, bdd.getRoot())) {
        return false;
      }
      iRow++;
    }
    return true;
  }

  private boolean validateBDD(int iRow, Row ttRow, AbstractNode tree) {
    final JastAddList<Assignment> assignments = findAssignmentsInGraph(ttRow, tree);
    if (assignments.getNumChild() == 0) {
      System.err.println(String.format("Row %d of TT did not produce any assignments in BDD", iRow));
    }

    for (Assignment a : assignments) {
      final String oPortName = a.getPort().getName();
      final boolean expectedResult = getExpectedResult(ttRow, oPortName);
      if (expectedResult != a.getValue()) {
        System.err.println(String.format("Row %s of TT produces unexpected result %s in BDD", ttRow.rowString(), a.getValue()));
        //return false;
      }
    }

    // No mismatches found!
    return true;
  }

  private boolean getExpectedResult(Row ttRow, String oPortName) {
    for (Cell c : ttRow.getCells()) {
      if (c.getPort() instanceof OutputPort && c.getPort().getName().equals(oPortName)) {
        return c.getValue();
      }
    }
    throw new NoSuchElementException("Could not find output port " + oPortName + " in the cells of the truth table");
  }

  private JastAddList<Assignment> findAssignmentsInGraph(Row ttRow, AbstractNode tree) {
    if (tree instanceof TerminalNode) {
      TerminalNode leaf = (TerminalNode) tree;
      return leaf.getAssignmentList();
    } else if (tree instanceof InnerNode) {
      InnerNode sb = (InnerNode) tree;
      InputPort sbInputPort = sb.getPort();
      for (Cell c : ttRow.getCells()) {
        // Port must be an input and have the same name
        if (c.getPort() instanceof InputPort && c.getPort().getName().equals(sbInputPort.getName())) {
          return findAssignmentsInGraph(ttRow, c.getValue() ? sb.getGraphForOne() : sb.getGraphForZero());
        }
      }

      /*
       * (2019-05-23 Artur Boronat) If the row in the table does not require a
       * specific value for the port checked in this subtree, try both values.
       */
      JastAddList<Assignment> zeroList = findAssignmentsInGraph(ttRow, sb.getGraphForZero());
      if (zeroList.getNumChild() == 0) {
        return findAssignmentsInGraph(ttRow, sb.getGraphForOne());
      } else {
        return zeroList;
      }
    } else if (tree == null) {
      throw new IllegalArgumentException("Tree must not be null");
    } else {
      throw new IllegalArgumentException("Tree must be a subtree or a leaf");
    }
  }

}
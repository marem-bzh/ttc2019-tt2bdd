//------------------------------------------------------------------------------
// <auto-generated>
//     Dieser Code wurde von einem Tool generiert.
//     Laufzeitversion:4.0.30319.42000
//
//     Änderungen an dieser Datei können falsches Verhalten verursachen und gehen verloren, wenn
//     der Code erneut generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

using NMF.Collections.Generic;
using NMF.Collections.ObjectModel;
using NMF.Expressions;
using NMF.Expressions.Linq;
using NMF.Models;
using NMF.Models.Collections;
using NMF.Models.Expressions;
using NMF.Models.Meta;
using NMF.Models.Repository;
using NMF.Serialization;
using NMF.Utilities;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;

namespace TTC2019.BinaryDecision.Metamodels.BinaryDecisionDiagrams.BDD
{
    
    
    /// <summary>
    /// The public interface for Subtree
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Subtree))]
    [XmlDefaultImplementationTypeAttribute(typeof(Subtree))]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/bdd#//Subtree")]
    public interface ISubtree : IModelElement, ITree
    {
        
        /// <summary>
        /// The port property
        /// </summary>
        [DisplayNameAttribute("port")]
        [CategoryAttribute("Subtree")]
        [XmlElementNameAttribute("port")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("subtrees")]
        IInputPort Port
        {
            get;
            set;
        }
        
        /// <summary>
        /// The treeForZero property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("treeForZero")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("ownerSubtreeForZero")]
        ITree TreeForZero
        {
            get;
            set;
        }
        
        /// <summary>
        /// The treeForOne property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("treeForOne")]
        [XmlAttributeAttribute(false)]
        [ContainmentAttribute()]
        [XmlOppositeAttribute("ownerSubtreeForOne")]
        ITree TreeForOne
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Port property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PortChanging;
        
        /// <summary>
        /// Gets fired when the Port property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PortChanged;
        
        /// <summary>
        /// Gets fired before the TreeForZero property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreeForZeroChanging;
        
        /// <summary>
        /// Gets fired when the TreeForZero property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreeForZeroChanged;
        
        /// <summary>
        /// Gets fired before the TreeForOne property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreeForOneChanging;
        
        /// <summary>
        /// Gets fired when the TreeForOne property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> TreeForOneChanged;
    }
}


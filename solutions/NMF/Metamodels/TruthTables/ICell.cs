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

namespace TTC2019.BinaryDecision.Metamodels.TruthTables.TT
{
    
    
    /// <summary>
    /// The public interface for Cell
    /// </summary>
    [DefaultImplementationTypeAttribute(typeof(Cell))]
    [XmlDefaultImplementationTypeAttribute(typeof(Cell))]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/tt#//Cell")]
    public interface ICell : IModelElement, ILocatedElement
    {
        
        /// <summary>
        /// The value property
        /// </summary>
        [DisplayNameAttribute("value")]
        [CategoryAttribute("Cell")]
        [XmlElementNameAttribute("value")]
        [XmlAttributeAttribute(true)]
        bool Value
        {
            get;
            set;
        }
        
        /// <summary>
        /// The owner property
        /// </summary>
        [BrowsableAttribute(false)]
        [XmlElementNameAttribute("owner")]
        [DesignerSerializationVisibilityAttribute(DesignerSerializationVisibility.Hidden)]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("cells")]
        IRow Owner
        {
            get;
            set;
        }
        
        /// <summary>
        /// The port property
        /// </summary>
        [DisplayNameAttribute("port")]
        [CategoryAttribute("Cell")]
        [XmlElementNameAttribute("port")]
        [XmlAttributeAttribute(true)]
        [XmlOppositeAttribute("cells")]
        IPort Port
        {
            get;
            set;
        }
        
        /// <summary>
        /// Gets fired before the Value property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanging;
        
        /// <summary>
        /// Gets fired when the Value property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> ValueChanged;
        
        /// <summary>
        /// Gets fired before the Owner property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OwnerChanging;
        
        /// <summary>
        /// Gets fired when the Owner property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> OwnerChanged;
        
        /// <summary>
        /// Gets fired before the Port property changes its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PortChanging;
        
        /// <summary>
        /// Gets fired when the Port property changed its value
        /// </summary>
        event System.EventHandler<ValueChangedEventArgs> PortChanged;
    }
}


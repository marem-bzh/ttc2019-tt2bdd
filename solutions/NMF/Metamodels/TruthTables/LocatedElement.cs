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
    /// The default implementation of the LocatedElement class
    /// </summary>
    [XmlNamespaceAttribute("https://www.transformation-tool-contest.eu/2019/tt")]
    [XmlNamespacePrefixAttribute("tt")]
    [ModelRepresentationClassAttribute("https://www.transformation-tool-contest.eu/2019/tt#//LocatedElement")]
    public partial class LocatedElement : ModelElement, ILocatedElement, IModelElement
    {
        
        /// <summary>
        /// The backing field for the Location property
        /// </summary>
        private string _location;
        
        private static Lazy<ITypedElement> _locationAttribute = new Lazy<ITypedElement>(RetrieveLocationAttribute);
        
        private static IClass _classInstance;
        
        /// <summary>
        /// The location property
        /// </summary>
        [DisplayNameAttribute("location")]
        [CategoryAttribute("LocatedElement")]
        [XmlElementNameAttribute("location")]
        [XmlAttributeAttribute(true)]
        public string Location
        {
            get
            {
                return this._location;
            }
            set
            {
                if ((this._location != value))
                {
                    string old = this._location;
                    ValueChangedEventArgs e = new ValueChangedEventArgs(old, value);
                    this.OnLocationChanging(e);
                    this.OnPropertyChanging("Location", e, _locationAttribute);
                    this._location = value;
                    this.OnLocationChanged(e);
                    this.OnPropertyChanged("Location", e, _locationAttribute);
                }
            }
        }
        
        /// <summary>
        /// Gets the Class model for this type
        /// </summary>
        public new static IClass ClassInstance
        {
            get
            {
                if ((_classInstance == null))
                {
                    _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/tt#//LocatedElement")));
                }
                return _classInstance;
            }
        }
        
        /// <summary>
        /// Gets fired before the Location property changes its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanging;
        
        /// <summary>
        /// Gets fired when the Location property changed its value
        /// </summary>
        public event System.EventHandler<ValueChangedEventArgs> LocationChanged;
        
        private static ITypedElement RetrieveLocationAttribute()
        {
            return ((ITypedElement)(((ModelElement)(LocatedElement.ClassInstance)).Resolve("location")));
        }
        
        /// <summary>
        /// Raises the LocationChanging event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanging(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanging;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Raises the LocationChanged event
        /// </summary>
        /// <param name="eventArgs">The event data</param>
        protected virtual void OnLocationChanged(ValueChangedEventArgs eventArgs)
        {
            System.EventHandler<ValueChangedEventArgs> handler = this.LocationChanged;
            if ((handler != null))
            {
                handler.Invoke(this, eventArgs);
            }
        }
        
        /// <summary>
        /// Resolves the given attribute name
        /// </summary>
        /// <returns>The attribute value or null if it could not be found</returns>
        /// <param name="attribute">The requested attribute name</param>
        /// <param name="index">The index of this attribute</param>
        protected override object GetAttributeValue(string attribute, int index)
        {
            if ((attribute == "LOCATION"))
            {
                return this.Location;
            }
            return base.GetAttributeValue(attribute, index);
        }
        
        /// <summary>
        /// Sets a value to the given feature
        /// </summary>
        /// <param name="feature">The requested feature</param>
        /// <param name="value">The value that should be set to that feature</param>
        protected override void SetFeature(string feature, object value)
        {
            if ((feature == "LOCATION"))
            {
                this.Location = ((string)(value));
                return;
            }
            base.SetFeature(feature, value);
        }
        
        /// <summary>
        /// Gets the property expression for the given attribute
        /// </summary>
        /// <returns>An incremental property expression</returns>
        /// <param name="attribute">The requested attribute in upper case</param>
        protected override NMF.Expressions.INotifyExpression<object> GetExpressionForAttribute(string attribute)
        {
            if ((attribute == "LOCATION"))
            {
                return new LocationProxy(this);
            }
            return base.GetExpressionForAttribute(attribute);
        }
        
        /// <summary>
        /// Gets the Class for this model element
        /// </summary>
        public override IClass GetClass()
        {
            if ((_classInstance == null))
            {
                _classInstance = ((IClass)(MetaRepository.Instance.Resolve("https://www.transformation-tool-contest.eu/2019/tt#//LocatedElement")));
            }
            return _classInstance;
        }
        
        /// <summary>
        /// Represents a proxy to represent an incremental access to the location property
        /// </summary>
        private sealed class LocationProxy : ModelPropertyChange<ILocatedElement, string>
        {
            
            /// <summary>
            /// Creates a new observable property access proxy
            /// </summary>
            /// <param name="modelElement">The model instance element for which to create the property access proxy</param>
            public LocationProxy(ILocatedElement modelElement) : 
                    base(modelElement, "location")
            {
            }
            
            /// <summary>
            /// Gets or sets the value of this expression
            /// </summary>
            public override string Value
            {
                get
                {
                    return this.ModelElement.Location;
                }
                set
                {
                    this.ModelElement.Location = value;
                }
            }
        }
    }
}


#pragma warning disable
namespace Adrichem.Serialization.Ameff.V31
{
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Xml;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    [System.Xml.Serialization.XmlRootAttribute("model", Namespace="http://www.opengroup.org/xsd/archimate/3.0/", IsNullable=false)]
    public partial class ModelType : NamedReferenceableType
    {
        
        #region Private fields
        private List<PropertyType> _properties;
        
        private MetadataType _metadata;
        
        private List<ElementType> _elements;
        
        private List<RelationshipType> _relationships;
        
        private List<OrganizationType> _organizations;
        
        private List<PropertyDefinitionType> _propertyDefinitions;
        
        private ViewsType _views;
        
        private string _version;
        #endregion
        
        public ModelType()
        {
            this._views = new ViewsType();
            this._propertyDefinitions = new List<PropertyDefinitionType>();
            this._organizations = new List<OrganizationType>();
            this._relationships = new List<RelationshipType>();
            this._elements = new List<ElementType>();
            this._metadata = new MetadataType();
            this._properties = new List<PropertyType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        
        public MetadataType metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("element", IsNullable=false)]
        public List<ElementType> elements
        {
            get
            {
                return this._elements;
            }
            set
            {
                this._elements = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("relationship", IsNullable=false)]
        public List<RelationshipType> relationships
        {
            get
            {
                return this._relationships;
            }
            set
            {
                this._relationships = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("item", typeof(OrganizationType), IsNullable=false)]
        public List<OrganizationType> organizations
        {
            get
            {
                return this._organizations;
            }
            set
            {
                this._organizations = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("propertyDefinition", IsNullable=false)]
        public List<PropertyDefinitionType> propertyDefinitions
        {
            get
            {
                return this._propertyDefinitions;
            }
            set
            {
                this._propertyDefinitions = value;
            }
        }
        
        public ViewsType views
        {
            get
            {
                return this._views;
            }
            set
            {
                this._views = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyType
    {
        
        #region Private fields
        private List<LangStringType> _value;
        
        private string _propertyDefinitionRef;
        #endregion
        
        public PropertyType()
        {
            this._value = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("value")]
        public List<LangStringType> value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string propertyDefinitionRef
        {
            get
            {
                return this._propertyDefinitionRef;
            }
            set
            {
                this._propertyDefinitionRef = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PreservedLangStringType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LangStringType
    {
        
        #region Private fields
        private string _lang;
        
        private string _value;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(Form=System.Xml.Schema.XmlSchemaForm.Qualified, Namespace="http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this._lang;
            }
            set
            {
                this._lang = value;
            }
        }
        
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LocationType
    {
        
        #region Private fields
        private string _x;
        
        private string _y;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ReferenceType
    {
        
        #region Private fields
        private string _ref;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string @ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class FontType
    {
        
        #region Private fields
        private RGBColorType _color;
        
        private string _name;
        
        private decimal _size;
        
        private List<FontStyleEnum> _style;
        #endregion
        
        public FontType()
        {
            this._style = new List<FontStyleEnum>();
            this._color = new RGBColorType();
        }
        
        public RGBColorType color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public decimal size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public List<FontStyleEnum> style
        {
            get
            {
                return this._style;
            }
            set
            {
                this._style = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class RGBColorType
    {
        
        #region Private fields
        private byte _r;
        
        private byte _g;
        
        private byte _b;
        
        private byte _a;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte r
        {
            get
            {
                return this._r;
            }
            set
            {
                this._r = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte g
        {
            get
            {
                return this._g;
            }
            set
            {
                this._g = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte b
        {
            get
            {
                return this._b;
            }
            set
            {
                this._b = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public byte a
        {
            get
            {
                return this._a;
            }
            set
            {
                this._a = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum FontStyleEnum
    {
        
        /// <remarks/>
        plain,
        
        /// <remarks/>
        bold,
        
        /// <remarks/>
        italic,
        
        /// <remarks/>
        underline,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StyleType
    {
        
        #region Private fields
        private RGBColorType _lineColor;
        
        private RGBColorType _fillColor;
        
        private FontType _font;
        
        private string _lineWidth;
        #endregion
        
        public StyleType()
        {
            this._font = new FontType();
            this._fillColor = new RGBColorType();
            this._lineColor = new RGBColorType();
        }
        
        public RGBColorType lineColor
        {
            get
            {
                return this._lineColor;
            }
            set
            {
                this._lineColor = value;
            }
        }
        
        public RGBColorType fillColor
        {
            get
            {
                return this._fillColor;
            }
            set
            {
                this._fillColor = value;
            }
        }
        
        public FontType font
        {
            get
            {
                return this._font;
            }
            set
            {
                this._font = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string lineWidth
        {
            get
            {
                return this._lineWidth;
            }
            set
            {
                this._lineWidth = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConnectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourcedConnectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Relationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Line))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewNodeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Container))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Element))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Label))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewConceptType
    {
        
        #region Private fields
        private List<LangStringType> _label;
        
        private List<PreservedLangStringType> _documentation;
        
        private StyleType _style;
        
        private List<ReferenceType> _viewRef;
        
        private string _identifier;
        
        private List<System.Xml.XmlAttribute> _anyAttr;
        #endregion
        
        public ViewConceptType()
        {
            this._anyAttr = new List<System.Xml.XmlAttribute>();
            this._viewRef = new List<ReferenceType>();
            this._style = new StyleType();
            this._documentation = new List<PreservedLangStringType>();
            this._label = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("label")]
        public List<LangStringType> label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }
        
        public StyleType style
        {
            get
            {
                return this._style;
            }
            set
            {
                this._style = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("viewRef")]
        public List<ReferenceType> viewRef
        {
            get
            {
                return this._viewRef;
            }
            set
            {
                this._viewRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr
        {
            get
            {
                return this._anyAttr;
            }
            set
            {
                this._anyAttr = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PreservedLangStringType : LangStringType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourcedConnectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Relationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Line))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConnectionType : ViewConceptType
    {
        
        #region Private fields
        private LocationType _sourceAttachment;
        
        private List<LocationType> _bendpoint;
        
        private LocationType _targetAttachment;
        
        private string _source;
        
        private string _target;
        #endregion
        
        public ConnectionType()
        {
            this._targetAttachment = new LocationType();
            this._bendpoint = new List<LocationType>();
            this._sourceAttachment = new LocationType();
        }
        
        public LocationType sourceAttachment
        {
            get
            {
                return this._sourceAttachment;
            }
            set
            {
                this._sourceAttachment = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("bendpoint")]
        public List<LocationType> bendpoint
        {
            get
            {
                return this._bendpoint;
            }
            set
            {
                this._bendpoint = value;
            }
        }
        
        public LocationType targetAttachment
        {
            get
            {
                return this._targetAttachment;
            }
            set
            {
                this._targetAttachment = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Relationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class SourcedConnectionType : ConnectionType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Relationship : SourcedConnectionType
    {
        
        #region Private fields
        private string _relationshipRef;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string relationshipRef
        {
            get
            {
                return this._relationshipRef;
            }
            set
            {
                this._relationshipRef = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class NestingRelationship : Relationship
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Line : ConnectionType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Container))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Element))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Label))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewNodeType : ViewConceptType
    {
        
        #region Private fields
        private string _x;
        
        private string _y;
        
        private string _w;
        
        private string _h;
        
        private List<System.Xml.XmlAttribute> _anyAttr1;
        #endregion
        
        public ViewNodeType()
        {
            this._anyAttr1 = new List<System.Xml.XmlAttribute>();
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
        public string y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string w
        {
            get
            {
                return this._w;
            }
            set
            {
                this._w = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="positiveInteger")]
        public string h
        {
            get
            {
                return this._h;
            }
            set
            {
                this._h = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1
        {
            get
            {
                return this._anyAttr1;
            }
            set
            {
                this._anyAttr1 = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Element))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Container : ViewNodeType
    {
        
        #region Private fields
        private List<ViewNodeType> _node;
        #endregion
        
        public Container()
        {
            this._node = new List<ViewNodeType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public List<ViewNodeType> node
        {
            get
            {
                return this._node;
            }
            set
            {
                this._node = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Element : Container
    {
        
        #region Private fields
        private string _elementRef;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string elementRef
        {
            get
            {
                return this._elementRef;
            }
            set
            {
                this._elementRef = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Label : ViewNodeType
    {
        
        #region Private fields
        private string _conceptRef;
        
        private string _xpathPart;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string conceptRef
        {
            get
            {
                return this._conceptRef;
            }
            set
            {
                this._conceptRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string xpathPart
        {
            get
            {
                return this._xpathPart;
            }
            set
            {
                this._xpathPart = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ModelingNoteType
    {
        
        #region Private fields
        private List<PreservedLangStringType> _documentation;
        
        private string _type;
        #endregion
        
        public ModelingNoteType()
        {
            this._documentation = new List<PreservedLangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedRelationshipTypeType
    {
        
        #region Private fields
        private RelationshipTypeEnum _type;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public RelationshipTypeEnum type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum RelationshipTypeEnum
    {
        
        /// <remarks/>
        Composition,
        
        /// <remarks/>
        Aggregation,
        
        /// <remarks/>
        Assignment,
        
        /// <remarks/>
        Realization,
        
        /// <remarks/>
        Serving,
        
        /// <remarks/>
        Access,
        
        /// <remarks/>
        Influence,
        
        /// <remarks/>
        Triggering,
        
        /// <remarks/>
        Flow,
        
        /// <remarks/>
        Specialization,
        
        /// <remarks/>
        Association,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedElementTypeType
    {
        
        #region Private fields
        private string _type;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StakeholderType
    {
        
        #region Private fields
        private List<LangStringType> _label;
        #endregion
        
        public StakeholderType()
        {
            this._label = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("label")]
        public List<LangStringType> label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ConcernType
    {
        
        #region Private fields
        private List<LangStringType> _label;
        
        private List<PreservedLangStringType> _documentation;
        
        private List<StakeholderType> _stakeholders;
        #endregion
        
        public ConcernType()
        {
            this._stakeholders = new List<StakeholderType>();
            this._documentation = new List<PreservedLangStringType>();
            this._label = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("label")]
        public List<LangStringType> label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("stakeholder", IsNullable=false)]
        public List<StakeholderType> stakeholders
        {
            get
            {
                return this._stakeholders;
            }
            set
            {
                this._stakeholders = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewsType
    {
        
        #region Private fields
        private List<ViewpointType> _viewpoints;
        
        private List<Diagram> _diagrams;
        #endregion
        
        public ViewsType()
        {
            this._diagrams = new List<Diagram>();
            this._viewpoints = new List<ViewpointType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("viewpoint", IsNullable=false)]
        public List<ViewpointType> viewpoints
        {
            get
            {
                return this._viewpoints;
            }
            set
            {
                this._viewpoints = value;
            }
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("view", IsNullable=false)]
        public List<Diagram> diagrams
        {
            get
            {
                return this._diagrams;
            }
            set
            {
                this._diagrams = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewpointType : NamedReferenceableType
    {
        
        #region Private fields
        private List<PropertyType> _properties;
        
        private List<ConcernType> _concern;
        
        private string _viewpointPurpose;
        
        private string _viewpointContent;
        
        private List<AllowedElementTypeType> _allowedElementType;
        
        private List<AllowedRelationshipTypeType> _allowedRelationshipType;
        
        private List<ModelingNoteType> _modelingNote;
        #endregion
        
        public ViewpointType()
        {
            this._modelingNote = new List<ModelingNoteType>();
            this._allowedRelationshipType = new List<AllowedRelationshipTypeType>();
            this._allowedElementType = new List<AllowedElementTypeType>();
            this._concern = new List<ConcernType>();
            this._properties = new List<PropertyType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("concern")]
        public List<ConcernType> concern
        {
            get
            {
                return this._concern;
            }
            set
            {
                this._concern = value;
            }
        }
        
        public string viewpointPurpose
        {
            get
            {
                return this._viewpointPurpose;
            }
            set
            {
                this._viewpointPurpose = value;
            }
        }
        
        public string viewpointContent
        {
            get
            {
                return this._viewpointContent;
            }
            set
            {
                this._viewpointContent = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("allowedElementType")]
        public List<AllowedElementTypeType> allowedElementType
        {
            get
            {
                return this._allowedElementType;
            }
            set
            {
                this._allowedElementType = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("allowedRelationshipType")]
        public List<AllowedRelationshipTypeType> allowedRelationshipType
        {
            get
            {
                return this._allowedRelationshipType;
            }
            set
            {
                this._allowedRelationshipType = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("modelingNote")]
        public List<ModelingNoteType> modelingNote
        {
            get
            {
                return this._modelingNote;
            }
            set
            {
                this._modelingNote = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Diagram))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewpointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class NamedReferenceableType : ReferenceableType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConceptType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Association))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Specialization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Flow))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Triggering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Influence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Access))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serving))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Realization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assignment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Composition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipConnectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plateau))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Deliverable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStream))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Capability))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Resource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Value))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Meaning))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constraint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Requirement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Principle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Outcome))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Goal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assessment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Driver))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Material))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Facility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Artifact))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Path))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Device))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Node))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Representation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Contract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessActor))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NamedReferenceableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Diagram))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewpointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ReferenceableType
    {
        
        #region Private fields
        private List<LangStringType> _name;
        
        private List<PreservedLangStringType> _documentation;
        
        private List<System.Xml.XmlElement> _any;
        
        private string _identifier;
        
        private List<System.Xml.XmlAttribute> _anyAttr;
        #endregion
        
        public ReferenceableType()
        {
            this._anyAttr = new List<System.Xml.XmlAttribute>();
            this._any = new List<System.Xml.XmlElement>();
            this._documentation = new List<PreservedLangStringType>();
            this._name = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("name")]
        public List<LangStringType> name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr
        {
            get
            {
                return this._anyAttr;
            }
            set
            {
                this._anyAttr = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Association))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Specialization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Flow))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Triggering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Influence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Access))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serving))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Realization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assignment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Composition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipConnectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plateau))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Deliverable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStream))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Capability))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Resource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Value))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Meaning))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constraint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Requirement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Principle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Outcome))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Goal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assessment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Driver))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Material))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Facility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Artifact))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Path))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Device))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Node))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Representation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Contract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessActor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConceptType : ReferenceableType
    {
        
        #region Private fields
        private List<PropertyType> _properties;
        #endregion
        
        public ConceptType()
        {
            this._properties = new List<PropertyType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Association))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Specialization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Flow))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Triggering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Influence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Access))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serving))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Realization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assignment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Composition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RelationshipType : ConceptType
    {
        
        #region Private fields
        private string _source;
        
        private string _target;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Association : RelationshipType
    {
        public bool isDirected { get; set; }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Specialization : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Flow : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Triggering : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Influence : RelationshipType
    {
        
        #region Private fields
        private string _modifier;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modifier
        {
            get
            {
                return this._modifier;
            }
            set
            {
                this._modifier = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Access : RelationshipType
    {
        
        #region Private fields
        private AccessTypeEnum _accessType;
        #endregion
        
        public Access()
        {
            this._accessType = AccessTypeEnum.Access;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AccessTypeEnum.Access)]
        public AccessTypeEnum accessType
        {
            get
            {
                return this._accessType;
            }
            set
            {
                this._accessType = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum AccessTypeEnum
    {
        
        /// <remarks/>
        Access,
        
        /// <remarks/>
        Read,
        
        /// <remarks/>
        Write,
        
        /// <remarks/>
        ReadWrite,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Serving : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Realization : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Assignment : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Aggregation : RelationshipType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Composition : RelationshipType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipConnectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plateau))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Deliverable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStream))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Capability))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Resource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Value))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Meaning))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constraint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Requirement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Principle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Outcome))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Goal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assessment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Driver))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Material))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Facility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Artifact))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Path))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Device))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Node))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Representation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Contract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessActor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ElementType : ConceptType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class CompositeType : ElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Location : CompositeType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Grouping : CompositeType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RelationshipConnectorType : ElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class OrJunction : RelationshipConnectorType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AndJunction : RelationshipConnectorType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plateau))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Deliverable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStream))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Capability))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Resource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Value))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Meaning))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constraint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Requirement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Principle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Outcome))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Goal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assessment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Driver))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Material))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Facility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Artifact))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Path))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Device))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Node))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Representation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Contract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessActor))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RealElementType : ElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Gap : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Plateau : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ImplementationEvent : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Deliverable : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class WorkPackage : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class CourseOfAction : RealElementType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ValueStream : RealElementType
    {
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Capability : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Resource : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Value : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Meaning : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Constraint : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Requirement : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Principle : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Outcome : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Goal : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Assessment : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Driver : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Stakeholder : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Material : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class DistributionNetwork : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Facility : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Equipment : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Artifact : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyService : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyEvent : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyInteraction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyProcess : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyFunction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class CommunicationNetwork : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Path : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyInterface : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class TechnologyCollaboration : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class SystemSoftware : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Device : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Node : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class DataObject : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationService : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationEvent : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationProcess : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationInteraction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationFunction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationInterface : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationCollaboration : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ApplicationComponent : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Product : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Representation : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Contract : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessObject : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessService : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessEvent : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessInteraction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessFunction : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessProcess : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessInterface : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessCollaboration : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessRole : RealElementType
    {
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class BusinessActor : RealElementType
    {
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Diagram))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewType : NamedReferenceableType
    {
        
        #region Private fields
        private List<PropertyType> _properties;
        
        private string _viewpoint;
        
        private string _viewpointRef;
        #endregion
        
        public ViewType()
        {
            this._properties = new List<PropertyType>();
        }
        
        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable=false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string viewpoint
        {
            get
            {
                return this._viewpoint;
            }
            set
            {
                this._viewpoint = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string viewpointRef
        {
            get
            {
                return this._viewpointRef;
            }
            set
            {
                this._viewpointRef = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Diagram : ViewType
    {
        
        #region Private fields
        private List<ViewNodeType> _node;
        
        private List<ConnectionType> _connection;
        #endregion
        
        public Diagram()
        {
            this._connection = new List<ConnectionType>();
            this._node = new List<ViewNodeType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("node")]
        public List<ViewNodeType> node
        {
            get
            {
                return this._node;
            }
            set
            {
                this._node = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("connection")]
        public List<ConnectionType> connection
        {
            get
            {
                return this._connection;
            }
            set
            {
                this._connection = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyDefinitionType : NamedReferenceableType
    {
        
        #region Private fields
        private DataType _type;
        #endregion
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataType type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum DataType
    {
        
        /// <remarks/>
        @string,
        
        /// <remarks/>
        boolean,
        
        /// <remarks/>
        currency,
        
        /// <remarks/>
        date,
        
        /// <remarks/>
        time,
        
        /// <remarks/>
        number,
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class OrganizationType
    {
        
        #region Private fields
        private List<LangStringType> _label;
        
        private List<PreservedLangStringType> _documentation;
        
        private List<OrganizationType> _item;
        
        private List<System.Xml.XmlElement> _any;
        
        private string _identifier;
        
        private string _identifierRef;
        
        private List<System.Xml.XmlAttribute> _anyAttr;
        #endregion
        
        public OrganizationType()
        {
            this._anyAttr = new List<System.Xml.XmlAttribute>();
            this._any = new List<System.Xml.XmlElement>();
            this._item = new List<OrganizationType>();
            this._documentation = new List<PreservedLangStringType>();
            this._label = new List<LangStringType>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("label")]
        public List<LangStringType> label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("item")]
        public List<OrganizationType> item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="ID")]
        public string identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="IDREF")]
        public string identifierRef
        {
            get
            {
                return this._identifierRef;
            }
            set
            {
                this._identifierRef = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr
        {
            get
            {
                return this._anyAttr;
            }
            set
            {
                this._anyAttr = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class SchemaInfoType
    {
        
        #region Private fields
        private string _schema;
        
        private string _schemaversion;
        
        private List<System.Xml.XmlElement> _any;
        #endregion
        
        public SchemaInfoType()
        {
            this._any = new List<System.Xml.XmlElement>();
        }
        
        public string schema
        {
            get
            {
                return this._schema;
            }
            set
            {
                this._schema = value;
            }
        }
        
        public string schemaversion
        {
            get
            {
                return this._schemaversion;
            }
            set
            {
                this._schemaversion = value;
            }
        }
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class MetadataType
    {
        
        #region Private fields
        private object[] _items;
        
        private ItemsChoiceType[] _itemsElementName;
        #endregion
        
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("schema", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("schemaInfo", typeof(SchemaInfoType))]
        [System.Xml.Serialization.XmlElementAttribute("schemaversion", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.opengroup.org/xsd/archimate/3.0/", IncludeInSchema=false)]
    public enum ItemsChoiceType
    {
        
        /// <remarks/>
        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        
        /// <remarks/>
        schema,
        
        /// <remarks/>
        schemaInfo,
        
        /// <remarks/>
        schemaversion,
    }
}
#pragma warning restore

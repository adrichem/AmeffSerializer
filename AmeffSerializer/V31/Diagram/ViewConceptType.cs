namespace AmeffSerializer.V31.Diagram
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlInclude(typeof(ConnectionType))]
    [System.Xml.Serialization.XmlInclude(typeof(SourcedConnectionType))]
    [System.Xml.Serialization.XmlInclude(typeof(Relationship))]
    [System.Xml.Serialization.XmlInclude(typeof(NestingRelationship))]
    [System.Xml.Serialization.XmlInclude(typeof(Line))]
    [System.Xml.Serialization.XmlInclude(typeof(ViewNodeType))]
    [System.Xml.Serialization.XmlInclude(typeof(Container))]
    [System.Xml.Serialization.XmlInclude(typeof(Element))]
    [System.Xml.Serialization.XmlInclude(typeof(Label))]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
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

        [System.Xml.Serialization.XmlElement("label")]
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

        [System.Xml.Serialization.XmlElement("documentation")]
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

        [System.Xml.Serialization.XmlElement("viewRef")]
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

        [System.Xml.Serialization.XmlAttribute(DataType = "ID")]
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

        [System.Xml.Serialization.XmlAnyAttribute()]
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
}

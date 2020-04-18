namespace Adrichem.Serialization.Ameff.V31.Diagram
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
        public ViewConceptType()
        {
            this.AnyAttr = new List<System.Xml.XmlAttribute>();
            this.viewRef = new List<ReferenceType>();
            this.style = new StyleType();
            this.documentation = new List<PreservedLangStringType>();
            this.label = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> label { get; set; }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> documentation { get; set; }

        public StyleType style { get; set; }

        [System.Xml.Serialization.XmlElement("viewRef")]
        public List<ReferenceType> viewRef { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "ID")]
        public string identifier { get; set; }

        [System.Xml.Serialization.XmlAnyAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr { get; set; }
    }
}

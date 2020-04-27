namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;
    using System.Xml;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlInclude(typeof(ConnectionType))]
    [XmlInclude(typeof(SourcedConnectionType))]
    [XmlInclude(typeof(Relationship))]
    [XmlInclude(typeof(NestingRelationship))]
    [XmlInclude(typeof(Line))]
    [XmlInclude(typeof(ViewNodeType))]
    [XmlInclude(typeof(Container))]
    [XmlInclude(typeof(Element))]
    [XmlInclude(typeof(Label))]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewConceptType
    {
        [XmlElement("label")]
        public List<LangStringType> Label { get; set; }

        [XmlElement("documentation")]
        public List<PreservedLangStringType> Documentation { get; set; }

        [XmlElement("style")]
        public StyleType Style { get; set; }

        [XmlElement("viewRef")]
        public List<ReferenceType> ViewRefs { get; set; }

        [XmlAttribute(AttributeName = "identifier", DataType = "ID")]
        public string Identifier { get; set; }

        [XmlAnyAttribute()]
        public List<XmlAttribute> AnyAttr { get; set; }
    }
}

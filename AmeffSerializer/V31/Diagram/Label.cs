namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Label : ViewNodeType
    {
        [XmlAttribute(AttributeName = "conceptRef", DataType = "IDREF")]
        public string ConceptRef { get; set; }

        [XmlAttribute(AttributeName = "xpathPart", DataType = "token")]
        public string XpathPart { get; set; }
    }
}

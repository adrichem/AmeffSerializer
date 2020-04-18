namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Label : ViewNodeType
    {
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string conceptRef { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "token")]
        public string xpathPart { get; set; }
    }
}

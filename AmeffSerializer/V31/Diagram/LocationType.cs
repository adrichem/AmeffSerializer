namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LocationType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName = "x", DataType = "nonNegativeInteger")]
        public string X { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "y", DataType = "nonNegativeInteger")]
        public string Y { get; set; }
    }

}

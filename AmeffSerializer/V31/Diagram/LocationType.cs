namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LocationType
    {
        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string x { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string y { get; set; }
    }

}

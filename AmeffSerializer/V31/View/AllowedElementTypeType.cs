namespace Adrichem.Serialization.Ameff.V31.View
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedElementTypeType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName = "type")]
        public string Type { get; set; }
    }
}

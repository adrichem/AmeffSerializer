namespace Adrichem.Serialization.Ameff.V31.Relationship
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Influence : RelationshipType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName = "modifier")]
        public string Modifier { get; set; }
    }
}

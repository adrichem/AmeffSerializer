namespace Adrichem.Serialization.Ameff.V31.View
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedRelationshipTypeType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName = "type")]
        public AllowedRelationshipType Type { get; set; }
    }
}

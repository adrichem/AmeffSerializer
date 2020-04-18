namespace Adrichem.Serialization.Ameff.V31.View
{
    using Relationship;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedRelationshipTypeType
    {
        [System.Xml.Serialization.XmlAttribute()]
        public RelationshipTypeEnum type { get; set; }
    }

}

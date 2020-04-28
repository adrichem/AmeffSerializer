using System.Xml.Serialization;

namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [XmlInclude(typeof(NestingRelationship))]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Relationship : SourcedConnectionType
    {
        [XmlAttribute(AttributeName = "relationshipRef",DataType = "IDREF")]
        public string RelationshipRef { get; set; }
    }
}

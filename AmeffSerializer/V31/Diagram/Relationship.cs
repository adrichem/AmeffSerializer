namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Xml.Serialization.XmlInclude(typeof(NestingRelationship))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Relationship : SourcedConnectionType
    {
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string relationshipRef { get; set; }
    }
}

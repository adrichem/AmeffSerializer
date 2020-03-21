namespace AmeffSerializer.V31.Relationship
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Association : RelationshipType
    {
        public bool isDirected { get; set; }
    }
}

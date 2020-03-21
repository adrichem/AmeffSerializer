namespace AmeffSerializer.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlInclude(typeof(Relationship))]
    [System.Xml.Serialization.XmlInclude(typeof(NestingRelationship))]
     [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class SourcedConnectionType : ConnectionType
    {
    }
}

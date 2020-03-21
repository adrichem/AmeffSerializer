namespace AmeffSerializer.V31.Diagram
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Relationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
     [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class SourcedConnectionType : ConnectionType
    {
    }
}

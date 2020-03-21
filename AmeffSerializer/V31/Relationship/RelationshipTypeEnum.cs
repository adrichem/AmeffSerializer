namespace AmeffSerializer.V31.Relationship
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum RelationshipTypeEnum
    {
        Composition,
        Aggregation,
        Assignment,
        Realization,
        Serving,
        Access,
        Influence,
        Triggering,
        Flow,
        Specialization,
        Association,
    }
}

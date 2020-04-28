namespace Adrichem.Serialization.Ameff.V31.View
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum AllowedRelationshipType
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

namespace Adrichem.Serialization.Ameff.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        [System.Xml.Serialization.XmlEnum("##any:")]
        Item,
        schema,
        schemaInfo,
        schemaversion,
    }
}

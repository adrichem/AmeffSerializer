namespace AmeffSerializer.V31
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/", IncludeInSchema = false)]
    public enum ItemsChoiceType
    {

        [System.Xml.Serialization.XmlEnumAttribute("##any:")]
        Item,
        schema,
        schemaInfo,
        schemaversion,
    }
}

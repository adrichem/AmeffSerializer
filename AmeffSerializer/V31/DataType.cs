namespace AmeffSerializer.V31
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum DataType
    {
        @string,
        boolean,
        currency,
        date,
        time,
        number,
    }
}

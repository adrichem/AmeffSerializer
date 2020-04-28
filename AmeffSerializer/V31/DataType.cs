namespace Adrichem.Serialization.Ameff.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public enum DataType
    {
        [System.Xml.Serialization.XmlEnum("string")]
        StringText,
        [System.Xml.Serialization.XmlEnum("boolean")]
        Boolean,
        [System.Xml.Serialization.XmlEnum("currency")]
        Currency,
        [System.Xml.Serialization.XmlEnum("date")]
        Date,
        [System.Xml.Serialization.XmlEnum("time")]
        Time,
        [System.Xml.Serialization.XmlEnum("number")]
        Number,
    }
}

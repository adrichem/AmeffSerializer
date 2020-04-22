namespace Adrichem.Serialization.Ameff.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class MetadataType
    {

        [System.Xml.Serialization.XmlAnyElement()]
        [System.Xml.Serialization.XmlElement("schema", typeof(string))]
        [System.Xml.Serialization.XmlElement("schemaInfo", typeof(SchemaInfoType))]
        [System.Xml.Serialization.XmlElement("schemaversion", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
        public object[] Items { get; set; }


        [System.Xml.Serialization.XmlElement("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnore()]
        public ItemsChoiceType[] ItemsElementName { get; set; }
    }
}

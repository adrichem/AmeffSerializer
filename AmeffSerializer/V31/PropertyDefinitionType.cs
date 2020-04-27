namespace Adrichem.Serialization.Ameff.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyDefinitionType : NamedReferenceableType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName = "type")]
        public DataType Type { get; set; }
    }
}

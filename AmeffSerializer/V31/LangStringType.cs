namespace Adrichem.Serialization.Ameff.V31
{
    [System.Xml.Serialization.XmlInclude(typeof(PreservedLangStringType))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LangStringType
    {
        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang { get; set; }
        
        [System.Xml.Serialization.XmlText()]
        public string Value { get; set; }
    }
}

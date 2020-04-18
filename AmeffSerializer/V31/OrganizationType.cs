namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class OrganizationType
    {
        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> label { get; set; }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> documentation { get; set; }

        [System.Xml.Serialization.XmlElement("item")]
        public List<OrganizationType> item { get; set; }

        [System.Xml.Serialization.XmlAnyElement()]
        public List<System.Xml.XmlElement> Any { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(DataType = "ID")] 
        public string identifier { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string identifierRef { get; set; }

        [System.Xml.Serialization.XmlAnyAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr { get; set; }
    }
}

namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class OrganizationType
    {
        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> Label { get; set; }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> Documentation { get; set; }

        [System.Xml.Serialization.XmlElement("item")]
        public List<OrganizationType> Item { get; set; }

        [System.Xml.Serialization.XmlAnyElement()]
        public List<System.Xml.XmlElement> Any { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(AttributeName = "identifier", DataType = "ID")] 
        public string Identifier { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(AttributeName = "identifierRef", DataType = "IDREF")]
        public string IdentifierRef { get; set; }

        [System.Xml.Serialization.XmlAnyAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr { get; set; }
    }
}

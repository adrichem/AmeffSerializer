namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyType
    {

        [System.Xml.Serialization.XmlElement("value")]
        public List<LangStringType> Value { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(AttributeName = "propertyDefinitionRef", DataType = "IDREF")]
        public string PropertyDefinitionRef { get; set; }
    }
}

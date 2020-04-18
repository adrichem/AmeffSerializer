namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyType
    {
        public PropertyType()
        {
            this.value = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElement("value")]
        public List<LangStringType> value { get; set; }
        

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string propertyDefinitionRef { get; set; }
    }
}

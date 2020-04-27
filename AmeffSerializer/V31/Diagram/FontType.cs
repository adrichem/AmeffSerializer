namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class FontType
    {
        [XmlElement(ElementName = "color")]
        public RGBColorType Color { get; set; }

        [XmlAttribute(AttributeName = "name")]
        public string Name { get; set; }

        [XmlAttribute(AttributeName = "size")]
        public decimal Size { get; set; }

        [XmlAttribute(AttributeName = "style")]
        public List<FontStyleEnum> Style { get; set; }

        public bool ShouldSerializeSize()
        {
            return Size > 0;
        }
    }
}

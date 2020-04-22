namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class FontType
    {
        [System.Xml.Serialization.XmlElement(ElementName = "color")]
        public RGBColorType color { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "name")]
        public string name { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "size")]
        public decimal size { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "style")]
        public List<FontStyleEnum> style { get; set; }

        public bool ShouldSerializesize()
        {
            return size > 0;
        }
    }
}

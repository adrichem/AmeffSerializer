namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StyleType
    {
        [XmlElement("lineColor")]
        public RgbColorType LineColor { get; set; }

        [XmlElement("fillColor")]
        public RgbColorType FillColor { get; set; }

        [XmlElement("font")]
        public FontType Font { get; set; }

        [XmlAttribute(AttributeName = "lineWidth", DataType = "positiveInteger")]
        public string LineWidth { get; set; }

    }
}

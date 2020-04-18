namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StyleType
    {
        public RGBColorType lineColor { get; set; }

        public RGBColorType fillColor { get; set; }

        public FontType font { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "positiveInteger")]
        public string lineWidth { get; set; }

    }
}

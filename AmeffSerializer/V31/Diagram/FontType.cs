namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class FontType
    {
        public FontType()
        {
            this.style = new List<FontStyleEnum>();
            this.color = new RGBColorType();
        }

        public RGBColorType color { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string name { get; set; }
        
        [System.Xml.Serialization.XmlAttribute()]
        public decimal size { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public List<FontStyleEnum> style { get; set; }
    }
}

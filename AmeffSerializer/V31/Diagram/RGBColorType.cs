namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class RGBColorType
    {
        [System.Xml.Serialization.XmlAttribute()]
        public byte r { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public byte g { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public byte b { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string a { get; set; }
    
    }
}

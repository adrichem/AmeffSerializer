namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Element : Container
    {
        [XmlAttribute(AttributeName = "elementRef", DataType = "IDREF")]
        public string ElementRef { get; set; }
    }
}

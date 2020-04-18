namespace Adrichem.Serialization.Ameff.V31.Diagram
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Element : Container
    {

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string elementRef { get; set; }
    }
}

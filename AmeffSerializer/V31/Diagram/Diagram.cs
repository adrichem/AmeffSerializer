namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using View;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Diagram : ViewType
    {
        [XmlElement("node")]
        public List<ViewNodeType> Nodes { get; set; }

        [XmlElement("connection")]
        public List<ConnectionType> Connections { get; set; }

    }
}

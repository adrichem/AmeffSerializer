namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using View;
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Diagram : ViewType
    {

        public Diagram()
        {
            this.connection = new List<ConnectionType>();
            this.node = new List<ViewNodeType>();
        }

        [System.Xml.Serialization.XmlElement("node")]
        public List<ViewNodeType> node { get; set; }

        [System.Xml.Serialization.XmlElement("connection")]
        public List<ConnectionType> connection { get; set; }

    }
}

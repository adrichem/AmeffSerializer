
namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(Element))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Container : ViewNodeType
    {

        public Container()
        {
            this.node = new List<ViewNodeType>();
        }

        [System.Xml.Serialization.XmlElement("node")]
        public List<ViewNodeType> node { get; set; }

    }
}

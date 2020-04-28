
namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlInclude(typeof(Element))]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Container : ViewNodeType
    {
        [XmlElement("node")]
        public List<ViewNodeType> Nodes { get; set; }

    }
}

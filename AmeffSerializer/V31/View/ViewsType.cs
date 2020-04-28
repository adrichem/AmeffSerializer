namespace Adrichem.Serialization.Ameff.V31.View
{
    using Diagram;
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewsType
    {
        [XmlArray("viewpoints")]
        [XmlArrayItem("viewpoint", IsNullable = false)]
        public List<ViewpointType> Viewpoints { get; set; }

        [XmlArray("diagrams")]
        [XmlArrayItem("view", IsNullable = false)]
        public List<Diagram> Diagrams { get; set; }
    }
}

namespace Adrichem.Serialization.Ameff.V31.View
{
    using Diagram;
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewsType
    {
        public ViewsType()
        {
            this.diagrams = new List<Diagram>();
        }

        [System.Xml.Serialization.XmlArrayItem("viewpoint", IsNullable = false)]
        public List<ViewpointType> viewpoints { get; set; }

        [System.Xml.Serialization.XmlArrayItem("view", IsNullable = false)]
        public List<Diagram> diagrams { get; set; }
    }
}

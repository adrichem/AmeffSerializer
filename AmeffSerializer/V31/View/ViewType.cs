namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlInclude(typeof(Diagram.Diagram))]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewType : NamedReferenceableType
    {
        [XmlArray("properties")]
        [XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> Properties { get; set; }

        [XmlAttribute(AttributeName = "viewpoint")]
        public string Viewpoint { get; set; }

        [XmlAttribute(AttributeName = "viewpointRef", DataType = "IDREF")]
        public string ViewpointRef { get; set; }
    }

}

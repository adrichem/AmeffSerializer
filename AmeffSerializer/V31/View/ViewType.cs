namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(Diagram.Diagram))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewType : NamedReferenceableType
    {

        [System.Xml.Serialization.XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> properties { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string viewpoint { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string viewpointRef { get; set; }
    }

}

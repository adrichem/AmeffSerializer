namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(Container))]
    [System.Xml.Serialization.XmlInclude(typeof(Element))]
    [System.Xml.Serialization.XmlInclude(typeof(Label))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewNodeType : ViewConceptType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName="x", DataType = "nonNegativeInteger")]
        public string X { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "y",DataType = "nonNegativeInteger")]
        public string Y { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "w", DataType = "positiveInteger")]
        public string W { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "h", DataType = "positiveInteger")]
        public string H { get; set; }

    }
}

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
        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string x { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string y { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "positiveInteger")]
        public string w { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "positiveInteger")]
        public string h { get; set; }

    }
}

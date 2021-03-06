﻿namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Xml.Serialization.XmlInclude(typeof(Container))]
    [System.Xml.Serialization.XmlInclude(typeof(Element))]
    [System.Xml.Serialization.XmlInclude(typeof(Label))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewNodeType : ViewConceptType
    {
        [System.Xml.Serialization.XmlAttribute(AttributeName="x")]
        public ulong X { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "y")]
        public ulong Y { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "w")]
        public ulong W { get; set; }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "h")]
        public ulong H { get; set; }

    }
}

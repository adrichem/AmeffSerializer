namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [XmlInclude(typeof(SourcedConnectionType))]
    [XmlInclude(typeof(Relationship))]
    [XmlInclude(typeof(NestingRelationship))]
    [XmlInclude(typeof(Line))]
    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConnectionType : ViewConceptType
    {
        [XmlElement("sourceAttachment")]
        public LocationType SourceAttachment { get; set; }

        [XmlElement("bendpoint")]
        public List<LocationType> Bendpoints { get; set; }

        [XmlElement("targetAttachment")]
        public LocationType TargetAttachment { get; set; }
       
        [XmlAttribute(AttributeName = "source", DataType = "IDREF")]
        public string Source { get; set; }

        [XmlAttribute(AttributeName = "target", DataType = "IDREF")]
        public string Target { get; set; }

    }
}

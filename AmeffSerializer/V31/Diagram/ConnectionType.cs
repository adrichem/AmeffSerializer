namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(SourcedConnectionType))]
    [System.Xml.Serialization.XmlInclude(typeof(Relationship))]
    [System.Xml.Serialization.XmlInclude(typeof(NestingRelationship))]
    [System.Xml.Serialization.XmlInclude(typeof(Line))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConnectionType : ViewConceptType
    {
        public LocationType sourceAttachment { get; set; }

        [System.Xml.Serialization.XmlElement("bendpoint")]
        public List<LocationType> bendpoint { get; set; }

        public LocationType targetAttachment { get; set; }
       
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string source { get; set; }

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string target { get; set; }

    }
}

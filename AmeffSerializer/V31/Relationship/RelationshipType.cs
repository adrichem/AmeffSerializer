namespace Adrichem.Serialization.Ameff.V31.Relationship
{
    [System.Xml.Serialization.XmlInclude(typeof(Association))]
    [System.Xml.Serialization.XmlInclude(typeof(Specialization))]
    [System.Xml.Serialization.XmlInclude(typeof(Flow))]
    [System.Xml.Serialization.XmlInclude(typeof(Triggering))]
    [System.Xml.Serialization.XmlInclude(typeof(Influence))]
    [System.Xml.Serialization.XmlInclude(typeof(Access))]
    [System.Xml.Serialization.XmlInclude(typeof(Serving))]
    [System.Xml.Serialization.XmlInclude(typeof(Realization))]
    [System.Xml.Serialization.XmlInclude(typeof(Assignment))]
    [System.Xml.Serialization.XmlInclude(typeof(Aggregation))]
    [System.Xml.Serialization.XmlInclude(typeof(Composition))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RelationshipType : ConceptType
    {
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string source { get; set; }
        
        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string target { get; set; }
    }
}

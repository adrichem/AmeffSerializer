namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewpointType : NamedReferenceableType
    {
        [XmlArray("properties")]
        [XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> Properties { get; set; }

        [XmlElement("concern")]
        public List<ConcernType> Concerns { get; set; }

        [XmlElement("viewpointPurpose")]
        public string ViewpointPurpose { get; set; }

        [XmlElement("viewpointContent")]
        public string ViewpointContent { get; set; }

        [XmlElement("allowedElementType")]
        public List<AllowedElementTypeType> AllowedElementTypes { get; set; }

        [XmlElement("allowedRelationshipType")]
        public List<AllowedRelationshipTypeType> AllowedRelationshipTypes { get; set; }

        [XmlElement("modelingNote")]
        public List<ModelingNoteType> ModelingNotes { get; set; }
    }
}

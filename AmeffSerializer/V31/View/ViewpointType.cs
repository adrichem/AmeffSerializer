namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewpointType : NamedReferenceableType
    {
        public ViewpointType()
        {
            this.modelingNote = new List<ModelingNoteType>();
            this.allowedRelationshipType = new List<AllowedRelationshipTypeType>();
            this.allowedElementType = new List<AllowedElementTypeType>();
            this.concern = new List<ConcernType>();
            this.properties = new List<PropertyType>();
        }

        [System.Xml.Serialization.XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> properties { get; set; }

        [System.Xml.Serialization.XmlElement("concern")]
        public List<ConcernType> concern { get; set; }

        public string viewpointPurpose { get; set; }

        public string viewpointContent { get; set; }

        [System.Xml.Serialization.XmlElement("allowedElementType")]
        public List<AllowedElementTypeType> allowedElementType { get; set; }

        [System.Xml.Serialization.XmlElement("allowedRelationshipType")]
        public List<AllowedRelationshipTypeType> allowedRelationshipType { get; set; }

        [System.Xml.Serialization.XmlElement("modelingNote")]
        public List<ModelingNoteType> modelingNote { get; set; }
    }
}

namespace AmeffSerializer.V31.View
{
    using System.Collections.Generic;

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewpointType : NamedReferenceableType
    {

        #region Private fields
        private List<PropertyType> _properties;

        private List<ConcernType> _concern;

        private string _viewpointPurpose;

        private string _viewpointContent;

        private List<AllowedElementTypeType> _allowedElementType;

        private List<AllowedRelationshipTypeType> _allowedRelationshipType;

        private List<ModelingNoteType> _modelingNote;
        #endregion

        public ViewpointType()
        {
            this._modelingNote = new List<ModelingNoteType>();
            this._allowedRelationshipType = new List<AllowedRelationshipTypeType>();
            this._allowedElementType = new List<AllowedElementTypeType>();
            this._concern = new List<ConcernType>();
            this._properties = new List<PropertyType>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("concern")]
        public List<ConcernType> concern
        {
            get
            {
                return this._concern;
            }
            set
            {
                this._concern = value;
            }
        }

        public string viewpointPurpose
        {
            get
            {
                return this._viewpointPurpose;
            }
            set
            {
                this._viewpointPurpose = value;
            }
        }

        public string viewpointContent
        {
            get
            {
                return this._viewpointContent;
            }
            set
            {
                this._viewpointContent = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("allowedElementType")]
        public List<AllowedElementTypeType> allowedElementType
        {
            get
            {
                return this._allowedElementType;
            }
            set
            {
                this._allowedElementType = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("allowedRelationshipType")]
        public List<AllowedRelationshipTypeType> allowedRelationshipType
        {
            get
            {
                return this._allowedRelationshipType;
            }
            set
            {
                this._allowedRelationshipType = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("modelingNote")]
        public List<ModelingNoteType> modelingNote
        {
            get
            {
                return this._modelingNote;
            }
            set
            {
                this._modelingNote = value;
            }
        }
    }
}

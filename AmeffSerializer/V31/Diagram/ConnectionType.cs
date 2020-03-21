namespace AmeffSerializer.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SourcedConnectionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Relationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Line))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConnectionType : ViewConceptType
    {

        #region Private fields
        private LocationType _sourceAttachment;

        private List<LocationType> _bendpoint;

        private LocationType _targetAttachment;

        private string _source;

        private string _target;
        #endregion

        public ConnectionType()
        {
            this._targetAttachment = new LocationType();
            this._bendpoint = new List<LocationType>();
            this._sourceAttachment = new LocationType();
        }

        public LocationType sourceAttachment
        {
            get
            {
                return this._sourceAttachment;
            }
            set
            {
                this._sourceAttachment = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("bendpoint")]
        public List<LocationType> bendpoint
        {
            get
            {
                return this._bendpoint;
            }
            set
            {
                this._bendpoint = value;
            }
        }

        public LocationType targetAttachment
        {
            get
            {
                return this._targetAttachment;
            }
            set
            {
                this._targetAttachment = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string source
        {
            get
            {
                return this._source;
            }
            set
            {
                this._source = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string target
        {
            get
            {
                return this._target;
            }
            set
            {
                this._target = value;
            }
        }
    }
}

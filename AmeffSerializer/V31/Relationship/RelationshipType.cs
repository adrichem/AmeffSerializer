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

        #region Private fields
        private string _source;

        private string _target;
        #endregion

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

namespace AmeffSerializer.V31.Relationship
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Association))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Specialization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Flow))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Triggering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Influence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Access))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serving))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Realization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assignment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Composition))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
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

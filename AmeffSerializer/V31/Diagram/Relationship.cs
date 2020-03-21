namespace AmeffSerializer.V31.Diagram
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NestingRelationship))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Relationship : SourcedConnectionType
    {

        #region Private fields
        private string _relationshipRef;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string relationshipRef
        {
            get
            {
                return this._relationshipRef;
            }
            set
            {
                this._relationshipRef = value;
            }
        }
    }
}

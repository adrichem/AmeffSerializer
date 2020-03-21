namespace AmeffSerializer.V31.Diagram
{
    [System.Xml.Serialization.XmlInclude(typeof(NestingRelationship))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Relationship : SourcedConnectionType
    {

        #region Private fields
        private string _relationshipRef;
        #endregion

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
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

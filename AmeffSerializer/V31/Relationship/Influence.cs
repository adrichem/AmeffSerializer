namespace AmeffSerializer.V31.Relationship
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Influence : RelationshipType
    {

        #region Private fields
        private string _modifier;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string modifier
        {
            get
            {
                return this._modifier;
            }
            set
            {
                this._modifier = value;
            }
        }
    }
}

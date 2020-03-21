namespace AmeffSerializer.V31
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ReferenceType
    {

        #region Private fields
        private string _ref;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string @ref
        {
            get
            {
                return this._ref;
            }
            set
            {
                this._ref = value;
            }
        }
    }
}

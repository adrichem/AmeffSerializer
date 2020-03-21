namespace AmeffSerializer.V31
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyDefinitionType : NamedReferenceableType
    {

        #region Private fields
        private DataType _type;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute()]
        public DataType type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}

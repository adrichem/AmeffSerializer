namespace AmeffSerializer.V31.Diagram
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Label : ViewNodeType
    {

        #region Private fields
        private string _conceptRef;

        private string _xpathPart;
        #endregion

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string conceptRef
        {
            get
            {
                return this._conceptRef;
            }
            set
            {
                this._conceptRef = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "token")]
        public string xpathPart
        {
            get
            {
                return this._xpathPart;
            }
            set
            {
                this._xpathPart = value;
            }
        }
    }
}

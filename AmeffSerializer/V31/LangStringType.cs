namespace AmeffSerializer.V31
{
    [System.Xml.Serialization.XmlInclude(typeof(PreservedLangStringType))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LangStringType
    {

        #region Private fields
        private string _lang;

        private string _value;
        #endregion

        [System.Xml.Serialization.XmlAttribute(Form = System.Xml.Schema.XmlSchemaForm.Qualified, Namespace = "http://www.w3.org/XML/1998/namespace")]
        public string lang
        {
            get
            {
                return this._lang;
            }
            set
            {
                this._lang = value;
            }
        }

        [System.Xml.Serialization.XmlText()]
        public string Value
        {
            get
            {
                return this._value;
            }
            set
            {
                this._value = value;
            }
        }
    }
}

namespace AmeffSerializer.V31
{
    using System.Collections.Generic;

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyType
    {

        #region Private fields
        private List<LangStringType> _value;

        private string _propertyDefinitionRef;
        #endregion

        public PropertyType()
        {
            this._value = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("value")]
        public List<LangStringType> value
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "IDREF")]
        public string propertyDefinitionRef
        {
            get
            {
                return this._propertyDefinitionRef;
            }
            set
            {
                this._propertyDefinitionRef = value;
            }
        }
    }
}

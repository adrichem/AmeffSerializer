namespace AmeffSerializer.V31
{
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class MetadataType
    {

        #region Private fields
        private object[] _items;

        private ItemsChoiceType[] _itemsElementName;
        #endregion

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        [System.Xml.Serialization.XmlElementAttribute("schema", typeof(string))]
        [System.Xml.Serialization.XmlElementAttribute("schemaInfo", typeof(SchemaInfoType))]
        [System.Xml.Serialization.XmlElementAttribute("schemaversion", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
        public object[] Items
        {
            get
            {
                return this._items;
            }
            set
            {
                this._items = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public ItemsChoiceType[] ItemsElementName
        {
            get
            {
                return this._itemsElementName;
            }
            set
            {
                this._itemsElementName = value;
            }
        }
    }
}

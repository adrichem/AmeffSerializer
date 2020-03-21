namespace AmeffSerializer.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class MetadataType
    {

        #region Private fields
        private object[] _items;

        private ItemsChoiceType[] _itemsElementName;
        #endregion

        [System.Xml.Serialization.XmlAnyElement()]
        [System.Xml.Serialization.XmlElement("schema", typeof(string))]
        [System.Xml.Serialization.XmlElement("schemaInfo", typeof(SchemaInfoType))]
        [System.Xml.Serialization.XmlElement("schemaversion", typeof(string))]
        [System.Xml.Serialization.XmlChoiceIdentifier("ItemsElementName")]
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

        [System.Xml.Serialization.XmlElement("ItemsElementName")]
        [System.Xml.Serialization.XmlIgnore()]
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

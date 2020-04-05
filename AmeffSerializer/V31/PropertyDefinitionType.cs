namespace Adrichem.Serialization.Ameff.V31
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class PropertyDefinitionType : NamedReferenceableType
    {

        #region Private fields
        private DataType _type;
        #endregion

        [System.Xml.Serialization.XmlAttribute()]
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

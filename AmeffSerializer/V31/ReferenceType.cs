namespace Adrichem.Serialization.Ameff.V31
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ReferenceType
    {

        #region Private fields
        private string _ref;
        #endregion

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
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

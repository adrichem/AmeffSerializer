namespace AmeffSerializer.V31.View
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedElementTypeType
    {

        #region Private fields
        private string _type;
        #endregion

        [System.Xml.Serialization.XmlAttribute()]
        public string type
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

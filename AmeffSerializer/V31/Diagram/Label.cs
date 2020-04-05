namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Label : ViewNodeType
    {

        #region Private fields
        private string _conceptRef;

        private string _xpathPart;
        #endregion

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
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

        [System.Xml.Serialization.XmlAttribute(DataType = "token")]
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

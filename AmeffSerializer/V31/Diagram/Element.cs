namespace Adrichem.Serialization.Ameff.V31.Diagram
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Element : Container
    {

        #region Private fields
        private string _elementRef;
        #endregion

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string elementRef
        {
            get
            {
                return this._elementRef;
            }
            set
            {
                this._elementRef = value;
            }
        }
    }
}

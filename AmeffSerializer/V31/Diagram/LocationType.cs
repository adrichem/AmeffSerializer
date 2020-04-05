namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class LocationType
    {

        #region Private fields
        private string _x;

        private string _y;
        #endregion

        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string x
        {
            get
            {
                return this._x;
            }
            set
            {
                this._x = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "nonNegativeInteger")]
        public string y
        {
            get
            {
                return this._y;
            }
            set
            {
                this._y = value;
            }
        }
    }

}

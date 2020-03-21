namespace AmeffSerializer.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class RGBColorType
    {

        #region Private fields
        private byte _r;

        private byte _g;

        private byte _b;

        private byte _a;
        #endregion

        [System.Xml.Serialization.XmlAttribute()]
        public byte r
        {
            get
            {
                return this._r;
            }
            set
            {
                this._r = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public byte g
        {
            get
            {
                return this._g;
            }
            set
            {
                this._g = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public byte b
        {
            get
            {
                return this._b;
            }
            set
            {
                this._b = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public byte a
        {
            get
            {
                return this._a;
            }
            set
            {
                this._a = value;
            }
        }
    }
}

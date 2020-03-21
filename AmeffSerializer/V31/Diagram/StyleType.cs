namespace AmeffSerializer.V31.Diagram
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StyleType
    {

        #region Private fields
        private RGBColorType _lineColor;

        private RGBColorType _fillColor;

        private FontType _font;

        private string _lineWidth;
        #endregion

        public StyleType()
        {
            this._font = new FontType();
            this._fillColor = new RGBColorType();
            this._lineColor = new RGBColorType();
        }

        public RGBColorType lineColor
        {
            get
            {
                return this._lineColor;
            }
            set
            {
                this._lineColor = value;
            }
        }

        public RGBColorType fillColor
        {
            get
            {
                return this._fillColor;
            }
            set
            {
                this._fillColor = value;
            }
        }

        public FontType font
        {
            get
            {
                return this._font;
            }
            set
            {
                this._font = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "positiveInteger")]
        public string lineWidth
        {
            get
            {
                return this._lineWidth;
            }
            set
            {
                this._lineWidth = value;
            }
        }
    }
}

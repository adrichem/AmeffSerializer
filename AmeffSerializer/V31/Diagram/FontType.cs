namespace AmeffSerializer.V31.Diagram
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class FontType
    {

        #region Private fields
        private RGBColorType _color;

        private string _name;

        private decimal _size;

        private List<FontStyleEnum> _style;
        #endregion

        public FontType()
        {
            this._style = new List<FontStyleEnum>();
            this._color = new RGBColorType();
        }

        public RGBColorType color
        {
            get
            {
                return this._color;
            }
            set
            {
                this._color = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public decimal size
        {
            get
            {
                return this._size;
            }
            set
            {
                this._size = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public List<FontStyleEnum> style
        {
            get
            {
                return this._style;
            }
            set
            {
                this._style = value;
            }
        }
    }
}

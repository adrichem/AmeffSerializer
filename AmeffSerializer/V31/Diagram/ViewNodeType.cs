namespace AmeffSerializer.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Container))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Element))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Label))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewNodeType : ViewConceptType
    {

        #region Private fields
        private string _x;

        private string _y;

        private string _w;

        private string _h;

        private List<System.Xml.XmlAttribute> _anyAttr1;
        #endregion

        public ViewNodeType()
        {
            this._anyAttr1 = new List<System.Xml.XmlAttribute>();
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "nonNegativeInteger")]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string w
        {
            get
            {
                return this._w;
            }
            set
            {
                this._w = value;
            }
        }

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "positiveInteger")]
        public string h
        {
            get
            {
                return this._h;
            }
            set
            {
                this._h = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr1
        {
            get
            {
                return this._anyAttr1;
            }
            set
            {
                this._anyAttr1 = value;
            }
        }
    }
}

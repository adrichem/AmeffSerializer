namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class OrganizationType
    {

        #region Private fields
        private List<LangStringType> _label;

        private List<PreservedLangStringType> _documentation;

        private List<OrganizationType> _item;

        private List<System.Xml.XmlElement> _any;

        private string _identifier;

        private string _identifierRef;

        private List<System.Xml.XmlAttribute> _anyAttr;
        #endregion

        public OrganizationType()
        {
            this._anyAttr = new List<System.Xml.XmlAttribute>();
            this._any = new List<System.Xml.XmlElement>();
            this._item = new List<OrganizationType>();
            this._documentation = new List<PreservedLangStringType>();
            this._label = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> label
        {
            get
            {
                return this._label;
            }
            set
            {
                this._label = value;
            }
        }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }

        [System.Xml.Serialization.XmlElement("item")]
        public List<OrganizationType> item
        {
            get
            {
                return this._item;
            }
            set
            {
                this._item = value;
            }
        }

        [System.Xml.Serialization.XmlAnyElement()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "ID")]
        public string identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string identifierRef
        {
            get
            {
                return this._identifierRef;
            }
            set
            {
                this._identifierRef = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr
        {
            get
            {
                return this._anyAttr;
            }
            set
            {
                this._anyAttr = value;
            }
        }
    }

}

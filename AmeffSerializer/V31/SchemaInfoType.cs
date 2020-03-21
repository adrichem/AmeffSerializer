namespace AmeffSerializer.V31
{
    using System.Collections.Generic;


    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class SchemaInfoType
    {

        #region Private fields
        private string _schema;

        private string _schemaversion;

        private List<System.Xml.XmlElement> _any;
        #endregion

        public SchemaInfoType()
        {
            this._any = new List<System.Xml.XmlElement>();
        }

        public string schema
        {
            get
            {
                return this._schema;
            }
            set
            {
                this._schema = value;
            }
        }

        public string schemaversion
        {
            get
            {
                return this._schemaversion;
            }
            set
            {
                this._schemaversion = value;
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
    }
}

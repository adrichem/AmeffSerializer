namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;


    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class SchemaInfoType
    {
        public SchemaInfoType()
        {
            this.Any = new List<System.Xml.XmlElement>();
        }

        public string schema { get; set; }

        public string schemaversion { get; set; }
        
        [System.Xml.Serialization.XmlAnyElement()]
        public List<System.Xml.XmlElement> Any { get; set; }
    }
}

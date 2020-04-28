namespace Adrichem.Serialization.Ameff.V31
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class SchemaInfoType
    {
        [XmlElement("schema")]
        public string Schema { get; set; }

        [XmlElement("schemaversion")]
        public string SchemaVersion { get; set; }
        
        [XmlAnyElement()]
        public List<System.Xml.XmlElement> Any { get; set; }
    }
}

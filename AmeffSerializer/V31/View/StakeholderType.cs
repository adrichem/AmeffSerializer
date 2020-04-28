namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;
    using System.Xml.Serialization;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StakeholderType
    {
        [XmlElement("label")]
        public List<LangStringType> Label { get; set; }
    }
}

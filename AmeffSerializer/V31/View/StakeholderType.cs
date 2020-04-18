namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StakeholderType
    {
        public StakeholderType()
        {
            this.label = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> label { get; set; }
    }
}

namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;


    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ConcernType
    {
        public ConcernType()
        {
            this.stakeholders = new List<StakeholderType>();
            this.documentation = new List<PreservedLangStringType>();
            this.label = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElement("label")]
        public List<LangStringType> label { get; set; }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> documentation { get; set; }

        [System.Xml.Serialization.XmlArrayItem("stakeholder", IsNullable = false)]
        public List<StakeholderType> stakeholders { get; set; }
    }

}

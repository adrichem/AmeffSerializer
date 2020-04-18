namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;


    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ModelingNoteType
    {
        public ModelingNoteType()
        {
            this.documentation = new List<PreservedLangStringType>();
        }

        [System.Xml.Serialization.XmlElement("documentation")]
        public List<PreservedLangStringType> documentation { get; set; }
        [System.Xml.Serialization.XmlAttribute()]
        public string type { get; set; }
    }
}

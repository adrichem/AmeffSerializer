namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;


    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ModelingNoteType
    {

        #region Private fields
        private List<PreservedLangStringType> _documentation;

        private string _type;
        #endregion

        public ModelingNoteType()
        {
            this._documentation = new List<PreservedLangStringType>();
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

        [System.Xml.Serialization.XmlAttribute()]
        public string type
        {
            get
            {
                return this._type;
            }
            set
            {
                this._type = value;
            }
        }
    }
}

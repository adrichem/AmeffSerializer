namespace AmeffSerializer.V31.View
{
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class StakeholderType
    {

        #region Private fields
        private List<LangStringType> _label;
        #endregion

        public StakeholderType()
        {
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
    }

}

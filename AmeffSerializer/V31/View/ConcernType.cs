﻿namespace AmeffSerializer.V31.View
{
    using System.Collections.Generic;


    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ConcernType
    {

        #region Private fields
        private List<LangStringType> _label;

        private List<PreservedLangStringType> _documentation;

        private List<StakeholderType> _stakeholders;
        #endregion

        public ConcernType()
        {
            this._stakeholders = new List<StakeholderType>();
            this._documentation = new List<PreservedLangStringType>();
            this._label = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("label")]
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

        [System.Xml.Serialization.XmlElementAttribute("documentation")]
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

        [System.Xml.Serialization.XmlArrayItemAttribute("stakeholder", IsNullable = false)]
        public List<StakeholderType> stakeholders
        {
            get
            {
                return this._stakeholders;
            }
            set
            {
                this._stakeholders = value;
            }
        }
    }

}

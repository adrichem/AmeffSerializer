﻿namespace AmeffSerializer.V31.View
{
    using AmeffSerializer.V31.Relationship;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class AllowedRelationshipTypeType
    {

        #region Private fields
        private RelationshipTypeEnum _type;
        #endregion

        [System.Xml.Serialization.XmlAttribute()]
        public RelationshipTypeEnum type
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

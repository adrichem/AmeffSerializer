namespace Adrichem.Serialization.Ameff.V31.Relationship
{

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Access : RelationshipType
    {

        #region Private fields
        private AccessTypeEnum _accessType;
        #endregion

        public Access()
        {
            this._accessType = AccessTypeEnum.Access;
        }

        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(AccessTypeEnum.Access)]
        public AccessTypeEnum accessType
        {
            get
            {
                return this._accessType;
            }
            set
            {
                this._accessType = value;
            }
        }
    }
}

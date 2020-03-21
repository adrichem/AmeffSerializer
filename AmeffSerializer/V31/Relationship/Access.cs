namespace AmeffSerializer.V31.Relationship
{

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Access : RelationshipType
    {

        #region Private fields
        private AccessTypeEnum _accessType;
        #endregion

        public Access()
        {
            this._accessType = AccessTypeEnum.Access;
        }

        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(AccessTypeEnum.Access)]
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

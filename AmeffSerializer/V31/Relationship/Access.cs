namespace Adrichem.Serialization.Ameff.V31.Relationship
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Access : RelationshipType
    {

        public Access()
        {
            this.accessType = AccessTypeEnum.Access;
        }

        [System.Xml.Serialization.XmlAttribute()]
        [System.ComponentModel.DefaultValue(AccessTypeEnum.Access)]
        public AccessTypeEnum accessType { get; set; }
       
    }
}

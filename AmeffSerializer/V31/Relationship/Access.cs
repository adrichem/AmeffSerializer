namespace Adrichem.Serialization.Ameff.V31.Relationship
{
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Access : RelationshipType
    {
        public Access()
        {
            this.AccessType = AccessType.Access;
        }

        [System.Xml.Serialization.XmlAttribute(AttributeName = "accessType")]
        [System.ComponentModel.DefaultValue(AccessType.Access)]
        public AccessType AccessType { get; set; }
       
    }
}

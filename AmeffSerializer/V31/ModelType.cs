namespace Adrichem.Serialization.Ameff.V31
{
    using Element;
    using Relationship;
    using View;
    using System.Collections.Generic;
    
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    [System.Xml.Serialization.XmlRoot("model", Namespace = "http://www.opengroup.org/xsd/archimate/3.0/", IsNullable = false)]
    public partial class ModelType : NamedReferenceableType
    {
        [System.Xml.Serialization.XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> properties { get; set; }
        
        public MetadataType metadata { get; set; }
        
        [System.Xml.Serialization.XmlArrayItem("element", IsNullable = false)]
        public List<ElementType> elements { get; set; }

        [System.Xml.Serialization.XmlArrayItem("relationship", IsNullable = false)]
        public List<RelationshipType> relationships { get; set; }

        [System.Xml.Serialization.XmlArrayItem("item", typeof(OrganizationType), IsNullable = false)]
        public List<OrganizationType> organizations { get; set; }

        [System.Xml.Serialization.XmlArrayItem("propertyDefinition", IsNullable = false)]
        public List<PropertyDefinitionType> propertyDefinitions { get; set; }

        public ViewsType views { get; set; }

        [System.Xml.Serialization.XmlAttribute()]
        public string version { get; set; }
    }

}

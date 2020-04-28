namespace Adrichem.Serialization.Ameff.V31
{
    using Element;
    using Relationship;
    using System.Collections.Generic;
    using System.Xml.Serialization;
    using View;

    [System.Serializable()]
    [XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    [XmlRoot("model", Namespace = "http://www.opengroup.org/xsd/archimate/3.0/", IsNullable = false)]
    public partial class ModelType : NamedReferenceableType
    {
        [XmlArray("properties")]
        [XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> Properties { get; set; }

        [XmlElement("metadata")]
        public MetadataType Metadata { get; set; }

        [XmlArray("elements")]
        [XmlArrayItem("element", IsNullable = false)]
        public List<ElementType> Elements { get; set; }

        [XmlArray("relationships")]
        [XmlArrayItem("relationship", IsNullable = false)]
        public List<RelationshipType> Relationships { get; set; }

        [XmlArray("organizations")]
        [XmlArrayItem("item", typeof(OrganizationType), IsNullable = false)]
        public List<OrganizationType> Organizations { get; set; }

        [XmlArray("propertyDefinitions")]
        [XmlArrayItem("propertyDefinition", IsNullable = false)]
        public List<PropertyDefinitionType> PropertyDefinitions { get; set; }

        [XmlElement("views")]
        public ViewsType Views { get; set; }

        [XmlAttribute(AttributeName="version")]
        public string Version { get; set; }
    }

}

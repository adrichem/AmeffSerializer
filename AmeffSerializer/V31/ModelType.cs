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

        #region Private fields
        private List<PropertyType> _properties;

        private MetadataType _metadata;

        private List<ElementType> _elements;

        private List<RelationshipType> _relationships;

        private List<OrganizationType> _organizations;

        private List<PropertyDefinitionType> _propertyDefinitions;

        private ViewsType _views;

        private string _version;
        #endregion

        public ModelType()
        {
            this._views = new ViewsType();
            this._propertyDefinitions = new List<PropertyDefinitionType>();
            this._organizations = new List<OrganizationType>();
            this._relationships = new List<RelationshipType>();
            this._elements = new List<ElementType>();
            this._metadata = new MetadataType();
            this._properties = new List<PropertyType>();
        }

        [System.Xml.Serialization.XmlArrayItem("property", IsNullable = false)]
        public List<PropertyType> properties
        {
            get
            {
                return this._properties;
            }
            set
            {
                this._properties = value;
            }
        }

        public MetadataType metadata
        {
            get
            {
                return this._metadata;
            }
            set
            {
                this._metadata = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItem("element", IsNullable = false)]
        public List<ElementType> elements
        {
            get
            {
                return this._elements;
            }
            set
            {
                this._elements = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItem("relationship", IsNullable = false)]
        public List<RelationshipType> relationships
        {
            get
            {
                return this._relationships;
            }
            set
            {
                this._relationships = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItem("item", typeof(OrganizationType), IsNullable = false)]
        public List<OrganizationType> organizations
        {
            get
            {
                return this._organizations;
            }
            set
            {
                this._organizations = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItem("propertyDefinition", IsNullable = false)]
        public List<PropertyDefinitionType> propertyDefinitions
        {
            get
            {
                return this._propertyDefinitions;
            }
            set
            {
                this._propertyDefinitions = value;
            }
        }

        public ViewsType views
        {
            get
            {
                return this._views;
            }
            set
            {
                this._views = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute()]
        public string version
        {
            get
            {
                return this._version;
            }
            set
            {
                this._version = value;
            }
        }
    }

}

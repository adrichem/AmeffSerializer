namespace AmeffSerializer.V31
{
    using AmeffSerializer.V31.Element;
    using AmeffSerializer.V31.Relationship;
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Association))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Specialization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Flow))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Triggering))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Influence))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Access))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Serving))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Realization))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assignment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Aggregation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Composition))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CompositeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RelationshipConnectorType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RealElementType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Gap))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Plateau))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Deliverable))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStream))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Capability))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Resource))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Value))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Meaning))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Constraint))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Requirement))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Principle))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Outcome))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Goal))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assessment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Driver))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Material))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Facility))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Equipment))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Artifact))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Path))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Device))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Node))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(DataObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Product))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Representation))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Contract))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessService))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(BusinessActor))]

    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConceptType : ReferenceableType
    {

        #region Private fields
        private List<PropertyType> _properties;
        #endregion

        public ConceptType()
        {
            this._properties = new List<PropertyType>();
        }

        [System.Xml.Serialization.XmlArrayItemAttribute("property", IsNullable = false)]
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
    }

}

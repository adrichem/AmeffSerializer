namespace Adrichem.Serialization.Ameff.V31
{
    using Element;
    using Relationship;
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(RelationshipType))]
    [System.Xml.Serialization.XmlInclude(typeof(Association))]
    [System.Xml.Serialization.XmlInclude(typeof(Specialization))]
    [System.Xml.Serialization.XmlInclude(typeof(Flow))]
    [System.Xml.Serialization.XmlInclude(typeof(Triggering))]
    [System.Xml.Serialization.XmlInclude(typeof(Influence))]
    [System.Xml.Serialization.XmlInclude(typeof(Access))]
    [System.Xml.Serialization.XmlInclude(typeof(Serving))]
    [System.Xml.Serialization.XmlInclude(typeof(Realization))]
    [System.Xml.Serialization.XmlInclude(typeof(Assignment))]
    [System.Xml.Serialization.XmlInclude(typeof(Aggregation))]
    [System.Xml.Serialization.XmlInclude(typeof(Composition))]
    [System.Xml.Serialization.XmlInclude(typeof(ElementType))]
    [System.Xml.Serialization.XmlInclude(typeof(CompositeType))]
    [System.Xml.Serialization.XmlInclude(typeof(Location))]
    [System.Xml.Serialization.XmlInclude(typeof(Grouping))]
    [System.Xml.Serialization.XmlInclude(typeof(RelationshipConnectorType))]
    [System.Xml.Serialization.XmlInclude(typeof(OrJunction))]
    [System.Xml.Serialization.XmlInclude(typeof(AndJunction))]
    [System.Xml.Serialization.XmlInclude(typeof(RealElementType))]
    [System.Xml.Serialization.XmlInclude(typeof(Gap))]
    [System.Xml.Serialization.XmlInclude(typeof(Plateau))]
    [System.Xml.Serialization.XmlInclude(typeof(ImplementationEvent))]
    [System.Xml.Serialization.XmlInclude(typeof(Deliverable))]
    [System.Xml.Serialization.XmlInclude(typeof(WorkPackage))]
    [System.Xml.Serialization.XmlInclude(typeof(CourseOfAction))]
    [System.Xml.Serialization.XmlInclude(typeof(ValueStream))]
    [System.Xml.Serialization.XmlInclude(typeof(Capability))]
    [System.Xml.Serialization.XmlInclude(typeof(Resource))]
    [System.Xml.Serialization.XmlInclude(typeof(Value))]
    [System.Xml.Serialization.XmlInclude(typeof(Meaning))]
    [System.Xml.Serialization.XmlInclude(typeof(Constraint))]
    [System.Xml.Serialization.XmlInclude(typeof(Requirement))]
    [System.Xml.Serialization.XmlInclude(typeof(Principle))]
    [System.Xml.Serialization.XmlInclude(typeof(Outcome))]
    [System.Xml.Serialization.XmlInclude(typeof(Goal))]
    [System.Xml.Serialization.XmlInclude(typeof(Assessment))]
    [System.Xml.Serialization.XmlInclude(typeof(Driver))]
    [System.Xml.Serialization.XmlInclude(typeof(Stakeholder))]
    [System.Xml.Serialization.XmlInclude(typeof(Material))]
    [System.Xml.Serialization.XmlInclude(typeof(DistributionNetwork))]
    [System.Xml.Serialization.XmlInclude(typeof(Facility))]
    [System.Xml.Serialization.XmlInclude(typeof(Equipment))]
    [System.Xml.Serialization.XmlInclude(typeof(Artifact))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyService))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyEvent))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyInteraction))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyProcess))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyFunction))]
    [System.Xml.Serialization.XmlInclude(typeof(CommunicationNetwork))]
    [System.Xml.Serialization.XmlInclude(typeof(Path))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyInterface))]
    [System.Xml.Serialization.XmlInclude(typeof(TechnologyCollaboration))]
    [System.Xml.Serialization.XmlInclude(typeof(SystemSoftware))]
    [System.Xml.Serialization.XmlInclude(typeof(Device))]
    [System.Xml.Serialization.XmlInclude(typeof(Node))]
    [System.Xml.Serialization.XmlInclude(typeof(DataObject))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationService))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationEvent))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationProcess))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationInteraction))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationFunction))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationInterface))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationCollaboration))]
    [System.Xml.Serialization.XmlInclude(typeof(ApplicationComponent))]
    [System.Xml.Serialization.XmlInclude(typeof(Product))]
    [System.Xml.Serialization.XmlInclude(typeof(Representation))]
    [System.Xml.Serialization.XmlInclude(typeof(Contract))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessObject))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessService))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessEvent))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessInteraction))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessFunction))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessProcess))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessInterface))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessCollaboration))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessRole))]
    [System.Xml.Serialization.XmlInclude(typeof(BusinessActor))]

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ConceptType : ReferenceableType
    {

        #region Private fields
        private List<PropertyType> _properties;
        #endregion

        public ConceptType()
        {
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
    }

}

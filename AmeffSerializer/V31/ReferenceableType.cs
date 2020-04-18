namespace Adrichem.Serialization.Ameff.V31
{
    using Diagram;
    using Element;
    using Relationship;
    using View;
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlInclude(typeof(ConceptType))]
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
    [System.Xml.Serialization.XmlInclude(typeof(NamedReferenceableType))]
    [System.Xml.Serialization.XmlInclude(typeof(ViewType))]
    [System.Xml.Serialization.XmlInclude(typeof(Diagram.Diagram))]
    [System.Xml.Serialization.XmlInclude(typeof(ViewpointType))]
    [System.Xml.Serialization.XmlInclude(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlInclude(typeof(ModelType))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ReferenceableType
    {

        #region Private fields
        private List<LangStringType> _name;

        private List<PreservedLangStringType> _documentation;

        private List<System.Xml.XmlElement> _any;

        private string _identifier;

        private List<System.Xml.XmlAttribute> _anyAttr;
        #endregion

        public ReferenceableType()
        {
            this._anyAttr = new List<System.Xml.XmlAttribute>();
            this._any = new List<System.Xml.XmlElement>();
            this._documentation = new List<PreservedLangStringType>();
            this._name = new List<LangStringType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("name")]
        public List<LangStringType> name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        [System.Xml.Serialization.XmlElementAttribute("documentation")]
        public List<PreservedLangStringType> documentation
        {
            get
            {
                return this._documentation;
            }
            set
            {
                this._documentation = value;
            }
        }

        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public List<System.Xml.XmlElement> Any
        {
            get
            {
                return this._any;
            }
            set
            {
                this._any = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "ID")]
        public string identifier
        {
            get
            {
                return this._identifier;
            }
            set
            {
                this._identifier = value;
            }
        }

        [System.Xml.Serialization.XmlAnyAttributeAttribute()]
        public List<System.Xml.XmlAttribute> AnyAttr
        {
            get
            {
                return this._anyAttr;
            }
            set
            {
                this._anyAttr = value;
            }
        }
    }
}

namespace AmeffSerializer.V31
{
    using Diagram;
    using Element;
    using Relationship;
    using View;
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ConceptType))]
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
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(NamedReferenceableType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Diagram.Diagram))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ViewpointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.7.3056.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
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

        [System.Xml.Serialization.XmlAttributeAttribute(DataType = "ID")]
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

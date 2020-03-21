namespace AmeffSerializer.V31
{

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(View.ViewType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Diagram.Diagram))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(View.ViewpointType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModelType))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class NamedReferenceableType : ReferenceableType
    {
    }

}

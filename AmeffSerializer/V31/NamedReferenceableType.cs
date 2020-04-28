namespace Adrichem.Serialization.Ameff.V31
{

    [System.Xml.Serialization.XmlInclude(typeof(View.ViewType))]
    [System.Xml.Serialization.XmlInclude(typeof(Diagram.Diagram))]
    [System.Xml.Serialization.XmlInclude(typeof(View.ViewpointType))]
    [System.Xml.Serialization.XmlInclude(typeof(PropertyDefinitionType))]
    [System.Xml.Serialization.XmlInclude(typeof(ModelType))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class NamedReferenceableType : ReferenceableType
    {
    }

}

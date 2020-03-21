namespace AmeffSerializer.V31.Element
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Location))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Grouping))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class CompositeType : ElementType
    {
    }
}

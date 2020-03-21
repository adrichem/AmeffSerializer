namespace AmeffSerializer.V31.Element
{
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(OrJunction))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(AndJunction))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RelationshipConnectorType : ElementType
    {
    }
}

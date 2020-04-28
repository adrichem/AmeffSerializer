namespace Adrichem.Serialization.Ameff.V31.Element
{
    [System.Xml.Serialization.XmlInclude(typeof(OrJunction))]
    [System.Xml.Serialization.XmlInclude(typeof(AndJunction))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class RelationshipConnectorType : ElementType
    {
    }
}

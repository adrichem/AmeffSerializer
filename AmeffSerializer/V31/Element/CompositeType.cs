namespace AmeffSerializer.V31.Element
{
    [System.Xml.Serialization.XmlInclude(typeof(Location))]
    [System.Xml.Serialization.XmlInclude(typeof(Grouping))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class CompositeType : ElementType
    {
    }
}

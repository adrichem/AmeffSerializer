
namespace AmeffSerializer.V31.Diagram
{
    using System.Collections.Generic;

    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Element))]
    [System.SerializableAttribute()]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Container : ViewNodeType
    {

        #region Private fields
        private List<ViewNodeType> _node;
        #endregion

        public Container()
        {
            this._node = new List<ViewNodeType>();
        }

        [System.Xml.Serialization.XmlElementAttribute("node")]
        public List<ViewNodeType> node
        {
            get
            {
                return this._node;
            }
            set
            {
                this._node = value;
            }
        }
    }
}

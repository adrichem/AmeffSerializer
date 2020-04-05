namespace Adrichem.Serialization.Ameff.V31.View
{
    using System.Collections.Generic;


    [System.Xml.Serialization.XmlInclude(typeof(Diagram.Diagram))]
    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public abstract partial class ViewType : NamedReferenceableType
    {

        #region Private fields
        private List<PropertyType> _properties;

        private string _viewpoint;

        private string _viewpointRef;
        #endregion

        public ViewType()
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

        [System.Xml.Serialization.XmlAttribute()]
        public string viewpoint
        {
            get
            {
                return this._viewpoint;
            }
            set
            {
                this._viewpoint = value;
            }
        }

        [System.Xml.Serialization.XmlAttribute(DataType = "IDREF")]
        public string viewpointRef
        {
            get
            {
                return this._viewpointRef;
            }
            set
            {
                this._viewpointRef = value;
            }
        }
    }

}

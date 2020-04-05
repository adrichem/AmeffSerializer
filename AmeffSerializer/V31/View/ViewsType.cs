namespace Adrichem.Serialization.Ameff.V31.View
{
    using Diagram;
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class ViewsType
    {

        #region Private fields
        private List<ViewpointType> _viewpoints;

        private List<Diagram> _diagrams;
        #endregion

        public ViewsType()
        {
            this._diagrams = new List<Diagram>();
        }

        [System.Xml.Serialization.XmlArrayItem("viewpoint", IsNullable = false)]
        public List<ViewpointType> viewpoints
        {
            get
            {
                return this._viewpoints;
            }
            set
            {
                this._viewpoints = value;
            }
        }

        [System.Xml.Serialization.XmlArrayItem("view", IsNullable = false)]
        public List<Diagram> diagrams
        {
            get
            {
                return this._diagrams;
            }
            set
            {
                this._diagrams = value;
            }
        }
    }
}

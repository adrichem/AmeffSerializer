﻿namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using View;
    using System.Collections.Generic;

    [System.Serializable()]
    [System.Xml.Serialization.XmlType(Namespace = "http://www.opengroup.org/xsd/archimate/3.0/")]
    public partial class Diagram : ViewType
    {

        #region Private fields
        private List<ViewNodeType> _node;

        private List<ConnectionType> _connection;
        #endregion

        public Diagram()
        {
            this._connection = new List<ConnectionType>();
            this._node = new List<ViewNodeType>();
        }

        [System.Xml.Serialization.XmlElement("node")]
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

        [System.Xml.Serialization.XmlElement("connection")]
        public List<ConnectionType> connection
        {
            get
            {
                return this._connection;
            }
            set
            {
                this._connection = value;
            }
        }
    }
}

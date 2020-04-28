namespace Adrichem.Serialization.Ameff.V31.Diagram
{
    using System;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [Serializable()]
    public partial class RgbColorType : IXmlSerializable
    {
        public byte R { get; set; }

        public byte G { get; set; }

        public byte B { get; set; }

        public byte? A { get; set; }

        public XmlSchema GetSchema()
        {
            return null;
        }

        public void ReadXml(XmlReader reader)
        {
            if(reader.MoveToAttribute("r") && reader.ReadAttributeValue())
            {
                R = Convert.ToByte(reader.Value);
            }
            if (reader.MoveToAttribute("g") && reader.ReadAttributeValue())
            {
                G = Convert.ToByte(reader.Value);
            }
            if (reader.MoveToAttribute("b") && reader.ReadAttributeValue())
            {
                B = Convert.ToByte(reader.Value);
            }
            if (reader.MoveToAttribute("a") && reader.ReadAttributeValue())
            {
                A = Convert.ToByte(reader.Value);
            }
        }

        public void WriteXml(XmlWriter writer)
        {
            writer.WriteAttributeString("r", R.ToString());
            writer.WriteAttributeString("g", G.ToString());
            writer.WriteAttributeString("b", B.ToString());
            if(A.HasValue)
            {
                writer.WriteAttributeString("a", A.Value.ToString());
            }
        }
    }
}

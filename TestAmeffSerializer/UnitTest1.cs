namespace TestAmeffSerializer
{
    using Adrichem.Serialization.Ameff.V31;
    using Adrichem.Serialization.Ameff.V31.Element;
    using Adrichem.Serialization.Ameff.V31.Relationship;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;

    [TestClass]
    public class TestV3
    {

        private static XmlSchemaSet Schemas;
        

        [ClassInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            Schemas = new XmlSchemaSet();
            Schemas.XmlResolver = new XmlUrlResolver();
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_Model.xsd");
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_View.xsd");
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_Diagram.xsd");
            Schemas.Add("http://purl.org/dc/elements/1.1/", "http://dublincore.org/schemas/xmls/qdc/2008/02/11/dc.xsd");
        }

        [TestMethod]
        public void AssociationTest()
        {
            MemoryStream Buffer = new MemoryStream();

            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            
            var MyXmlReaderSettings = new XmlReaderSettings
            {
                Schemas = Schemas,
                ValidationType = ValidationType.Schema,
                ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.ReportValidationWarnings
            };
            MyXmlReaderSettings.ValidationEventHandler += new ValidationEventHandler((sender, args) => ValidationIssues.Add(args));

            using (var Writer = new StreamWriter(Buffer, new System.Text.UTF8Encoding(false), 1024,true))
            {
                var AmeffModel = new ModelType();
                AmeffModel.identifier = "id-1";
                AmeffModel.name = new List<LangStringType> { new LangStringType { Value = "accesstest" } };
                AmeffModel.elements = new List<ElementType>
                {
                    new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                    new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                };
                AmeffModel.relationships = new List<RelationshipType>
                {
                    new Association { identifier = "association1", source= "actor1", target = "object1", isDirected = true},
                    new Association { identifier = "association2", source= "actor1", target = "object1", isDirected = false },
                };

                new XmlSerializer(typeof(ModelType)).Serialize(Writer, AmeffModel);
            }

            Buffer.Seek(0,SeekOrigin.Begin);
            using (var Reader = new StreamReader(Buffer, new System.Text.UTF8Encoding(false)))
            {
                using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
                {
                    var myAmeff = (ModelType)new XmlSerializer(typeof(ModelType)).Deserialize(XmlRdr);
                    Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i=>i.Exception.ToString())));
                }
            }
        }
    }
}

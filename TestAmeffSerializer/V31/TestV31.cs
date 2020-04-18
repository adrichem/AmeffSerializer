namespace TestAmeffSerializer.V31
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
        public void EmptyModel()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();

            var MyXmlReaderSettings = new XmlReaderSettings
            {
                Schemas = Schemas,
                ValidationType = ValidationType.Schema,
                ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.ReportValidationWarnings
            };
            MyXmlReaderSettings.ValidationEventHandler += new ValidationEventHandler((sender, args) => ValidationIssues.Add(args));

            MemoryStream Buffer = new MemoryStream();
            using (var Writer = new StreamWriter(Buffer, new System.Text.UTF8Encoding(false),1024, true))
            {
                var AmeffModel = new ModelType();
                AmeffModel.identifier = "id-1";
                AmeffModel.name = new List<LangStringType> { new LangStringType { Value = "empty" } };
                new XmlSerializer(typeof(ModelType)).Serialize(Writer, AmeffModel);
            }

            Buffer.Seek(0, SeekOrigin.Begin);
            using (var Reader = new StreamReader(Buffer, new System.Text.UTF8Encoding(false)))
            {
                string xml = Reader.ReadToEnd();
                Buffer.Seek(0, SeekOrigin.Begin);

                using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
                {
                    var myAmeff = (ModelType)new XmlSerializer(typeof(ModelType)).Deserialize(XmlRdr);
                    Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));

                    Assert.IsTrue(myAmeff.Any.Count == 0);
                    Assert.IsTrue(myAmeff.AnyAttr.Count == 0);
                    Assert.IsTrue(myAmeff.documentation.Count == 0);
                    Assert.IsTrue(myAmeff.elements.Count == 0);
                    Assert.IsTrue(myAmeff.metadata == null);
                    Assert.IsTrue(myAmeff.relationships.Count == 0);
                    Assert.IsTrue(myAmeff.organizations.Count == 0);
                    Assert.IsTrue(myAmeff.properties.Count == 0);
                    Assert.IsTrue(myAmeff.propertyDefinitions.Count == 0);
                    Assert.IsTrue(myAmeff.views == null);
                }
            }
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
                string xml = Reader.ReadToEnd();
                Buffer.Seek(0, SeekOrigin.Begin);
                using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
                {
                    var myAmeff = (ModelType)new XmlSerializer(typeof(ModelType)).Deserialize(XmlRdr);
                    Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i=>i.Exception.ToString())));
                    Assert.IsTrue(myAmeff.relationships.OfType<Association>().First().isDirected);
                    Assert.IsFalse(myAmeff.relationships.OfType<Association>().Last().isDirected);
                    Assert.IsFalse(xml.Contains("isDirected=\"false\""));
                }
            }
        }

        [TestMethod]
        public void AccessTest()
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

            using (var Writer = new StreamWriter(Buffer, new System.Text.UTF8Encoding(false), 1024, true))
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
                new Access { identifier = "access1", source= "actor1", target = "object1", accessType = AccessTypeEnum.ReadWrite },
                new Access { identifier = "access2", source= "actor1", target = "object1" },
            };

                new XmlSerializer(typeof(ModelType)).Serialize(Writer, AmeffModel);
            }

            Buffer.Seek(0, SeekOrigin.Begin);
            using (var Reader = new StreamReader(Buffer, new System.Text.UTF8Encoding(false)))
            {
                string xml = Reader.ReadToEnd();
                Buffer.Seek(0, SeekOrigin.Begin);
                using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
                {
                    var myAmeff = (ModelType)new XmlSerializer(typeof(ModelType)).Deserialize(XmlRdr);
                    Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
                    Assert.IsTrue(myAmeff.relationships.OfType<Access>().First().accessType == AccessTypeEnum.ReadWrite);
                    Assert.IsTrue(myAmeff.relationships.OfType<Access>().Last().accessType == AccessTypeEnum.Access);
                    Assert.IsTrue(xml.Contains("accessType=\"ReadWrite\""));
                    Assert.IsFalse(xml.Contains("accessType=\"Access\""));
                }
            }
        }

        [TestMethod]
        public void InfluenceTest()
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

            using (var Writer = new StreamWriter(Buffer, new System.Text.UTF8Encoding(false), 1024, true))
            {
                var AmeffModel = new ModelType();
                AmeffModel.identifier = "id-1";
                AmeffModel.name = new List<LangStringType> { new LangStringType { Value = "influencetest" } };
                AmeffModel.elements = new List<ElementType>
            {
                new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
            };
                AmeffModel.relationships = new List<RelationshipType>
            {
                new Influence { identifier = "inf1", source= "actor1", target = "object1", modifier = "++" },
                new Influence { identifier = "inf2", source= "actor1", target = "object1" },
            };

                new XmlSerializer(typeof(ModelType)).Serialize(Writer, AmeffModel);
            }

            Buffer.Seek(0, SeekOrigin.Begin);
            using (var Reader = new StreamReader(Buffer, new System.Text.UTF8Encoding(false)))
            {
                string xml = Reader.ReadToEnd();
                Buffer.Seek(0, SeekOrigin.Begin);
                using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
                {
                    var myAmeff = (ModelType)new XmlSerializer(typeof(ModelType)).Deserialize(XmlRdr);
                    Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
                    Assert.IsTrue(myAmeff.relationships.OfType<Influence>().First().modifier == "++");
                    Assert.IsTrue(myAmeff.relationships.OfType<Influence>().Last().modifier == null);
                    Assert.IsTrue(xml.Contains("modifier=\"++\""));
                    Assert.IsFalse(xml.Contains("modifier=\"\""));
                }
            }
        }

    }
}

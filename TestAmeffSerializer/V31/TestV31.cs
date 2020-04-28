namespace TestAmeffSerializer.V31
{
    using Adrichem.Serialization.Ameff.V31;
    using Adrichem.Serialization.Ameff.V31.Diagram;
    using Adrichem.Serialization.Ameff.V31.Element;
    using Adrichem.Serialization.Ameff.V31.Relationship;
    using Adrichem.Serialization.Ameff.V31.View;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Xml;
    using System.Xml.Schema;
    using System.Xml.Serialization;
    using System.Diagnostics;

    [TestClass]
    public class TestV3
    {
        #region privates
        private static XmlSchemaSet Schemas;
        
        private XmlReaderSettings ReaderSettings(IList<ValidationEventArgs> ValidationIssues)
        {
            var tmp =  new XmlReaderSettings
            {
                Schemas = Schemas,
                ValidationType = ValidationType.Schema,
                ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints | XmlSchemaValidationFlags.ReportValidationWarnings
            };

            tmp.ValidationEventHandler += new ValidationEventHandler((sender, args) => ValidationIssues.Add(args));
            return tmp;
        }

        private Stream Serialize<T> (T Model, string FileName)
        {
            MemoryStream Buffer = new MemoryStream();
            using (var Writer = new StreamWriter(Buffer, new System.Text.UTF8Encoding(false), 1024, true))
            {
                new XmlSerializer(typeof(T)).Serialize(Writer, Model);
            }
            Buffer.Seek(0, SeekOrigin.Begin);
            using (var Reader = new StreamReader(Buffer, new System.Text.UTF8Encoding(false), true, 1024, true))
            {
                using (var Writer = new StreamWriter(File.Create(FileName)))
                {
                    Writer.Write(Reader.ReadToEnd());
                }
            }

            Buffer.Seek(0, SeekOrigin.Begin);
            return Buffer;
        }

        class DeserializationResult<T>
        {
            public T Model { get; set; }
            public string Xml { get; set; }
        }
        private DeserializationResult<T> Deserialize<T>(Stream Stream, XmlReaderSettings Settings)
        {
            var Result = new DeserializationResult<T>();
            using (var Reader = new StreamReader(Stream, new System.Text.UTF8Encoding(false)))
            {
                Stream.Seek(0, SeekOrigin.Begin);
                Result.Xml = Reader.ReadToEnd();
                Stream.Seek(0, SeekOrigin.Begin);

                using (var XmlRdr = XmlReader.Create(Reader, Settings))
                {
                    Result.Model = (T)new XmlSerializer(typeof(T)).Deserialize(XmlRdr);
                }
            }
            return Result;
        }

        private string TempFileName(string Suffix)
        {
            string FileName = string.Format("{0}{1}.xml"
                , new StackTrace().GetFrame(1).GetMethod().Name
                , Suffix
            );
            return System.IO.Path.Combine(System.IO.Path.GetTempPath(), FileName);
        }

        #endregion

        [AssemblyInitialize]
        public static void TestFixtureSetup(TestContext context)
        {
            Schemas = new XmlSchemaSet
            {
                XmlResolver = new XmlUrlResolver()
            };
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_Model.xsd");
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_View.xsd");
            Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.1/archimate3_Diagram.xsd");
            Schemas.Add("http://purl.org/dc/elements/1.1/", "http://dublincore.org/schemas/xmls/qdc/2008/02/11/dc.xsd");
        }

        [TestMethod]
        public void Model()
        {
            var ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);

            var Buffer = Serialize(
                new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "empty" } }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Any.Count == 0);
            Assert.IsTrue(Result.Model.AnyAttr.Count == 0);
            Assert.IsTrue(Result.Model.Documentation.Count == 0);
            Assert.IsTrue(Result.Model.Elements.Count == 0);
            Assert.IsTrue(Result.Model.Metadata == null);
            Assert.IsTrue(Result.Model.Relationships.Count == 0);
            Assert.IsTrue(Result.Model.Organizations.Count == 0);
            Assert.IsTrue(Result.Model.Properties.Count == 0);
            Assert.IsTrue(Result.Model.PropertyDefinitions.Count == 0);
            Assert.IsTrue(Result.Model.Views == null);
        }

        [TestMethod]
        public void Documentation()
        {
            string ExpectedLanguage1 = null;
            string ExpectedDocumentation1 = "Test documentation1";
            string ExpectedLanguage2 = "test";
            string ExpectedDocumentation2 = "Test documentation2";
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();

            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            
            Stream Buffer = Serialize(new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "empty" } },
                    Documentation = new List<PreservedLangStringType>
                    {
                        new PreservedLangStringType {  Value = ExpectedDocumentation1},
                        new PreservedLangStringType { Lang = ExpectedLanguage2, Value = ExpectedDocumentation2},
                    }
                }, 
                TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.AreEqual(ExpectedLanguage1, Result.Model.Documentation.First().Lang);
            Assert.AreEqual(ExpectedDocumentation1, Result.Model.Documentation.First().Value);
            Assert.AreEqual(ExpectedLanguage2, Result.Model.Documentation.Last().Lang);
            Assert.AreEqual(ExpectedDocumentation2, Result.Model.Documentation.Last().Value);
        }

        [TestMethod]
        public void MetadataWithSchemaInfo()
        {            
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var MetaDataSubDoc = new XmlDocument();
            var ExpectedTitle = MetaDataSubDoc.CreateElement("dc:title");
            ExpectedTitle.InnerText = "title in metadata";
            ExpectedTitle.SetAttribute("xmlns", "http://purl.org/dc/elements/1.1/");

            var ExpectedCreator = MetaDataSubDoc.CreateElement("dc:creator");
            ExpectedCreator.InnerText = "creator in metadata";
            ExpectedCreator.SetAttribute("xmlns", "http://purl.org/dc/elements/1.1/");

            var MyModel = new ModelType
            {
                Identifier = "id-1",
                Name = new List<LangStringType> { new LangStringType { Value = "metadata" } },
                Metadata = new MetadataType
                {
                    Items = new object[]
                    {
                        new SchemaInfoType
                        {
                            Schema = "schema1" ,
                            SchemaVersion = "1",
                            Any = new List<XmlElement>
                            {
                                ExpectedTitle,
                                ExpectedCreator
                            }
                        }
                    },
                    ItemsElementName = new ItemsChoiceType[]
                    {
                        ItemsChoiceType.schemaInfo,
                        ItemsChoiceType.Item,
                        ItemsChoiceType.Item,
                    }
                }
            };

            Stream Buffer = Serialize(MyModel, TempFileName(string.Empty));

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Metadata.Items.Count() == 1);

            SchemaInfoType ActualItem1 = Result.Model.Metadata.Items.First() as SchemaInfoType;
            XmlElement ActualTitle = ActualItem1.Any.First();
            XmlElement ActualCreator = ActualItem1.Any.Skip(1).First();
            Assert.IsTrue(ActualItem1.Schema == "schema1");
            Assert.IsTrue(ActualItem1.SchemaVersion == "1");
            Assert.IsTrue(ActualTitle.InnerText == ExpectedTitle.InnerText);
            Assert.IsTrue(ActualCreator.InnerText == ExpectedCreator.InnerText);
        }

        [TestMethod]
        public void MetadataWithElements()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var MetaDataSubDoc = new XmlDocument();
            var ExpectedTitle = MetaDataSubDoc.CreateElement("dc:title");
            ExpectedTitle.InnerText = "title in metadata";
            ExpectedTitle.SetAttribute("xmlns", "http://purl.org/dc/elements/1.1/");

            var ExpectedCreator = MetaDataSubDoc.CreateElement("dc:creator");
            ExpectedCreator.InnerText = "creator in metadata";
            ExpectedCreator.SetAttribute("xmlns", "http://purl.org/dc/elements/1.1/");

            var MyModel = new ModelType
            {
                Identifier = "id-1",
                Name = new List<LangStringType> { new LangStringType { Value = "metadata" } },
                Metadata = new MetadataType
                {
                    Items = new object[]
                    {
                        "schema1",
                        "1",
                        ExpectedTitle,
                        ExpectedCreator,
                    },
                    ItemsElementName = new ItemsChoiceType[]
                    {
                        ItemsChoiceType.schema,
                        ItemsChoiceType.schemaversion,
                        ItemsChoiceType.Item,
                        ItemsChoiceType.Item,
                    }
                }
            };

            Stream Buffer = Serialize(MyModel, TempFileName(string.Empty));

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Metadata.Items.Count() == 4);

            string ActualSchema = Result.Model.Metadata.Items.First() as string;
            string ActualSchemaVersion = Result.Model.Metadata.Items.Skip(1).First() as string;
            XmlElement ActualTitle = Result.Model.Metadata.Items.Skip(2).First() as XmlElement;
            XmlElement ActualCreator = Result.Model.Metadata.Items.Skip(3).First() as XmlElement;
            Assert.IsTrue(ActualSchema == "schema1");
            Assert.IsTrue(ActualSchemaVersion == "1");
            Assert.IsTrue(ActualTitle.InnerText == ExpectedTitle.InnerText);
            Assert.IsTrue(ActualCreator.InnerText == ExpectedCreator.InnerText);
        }

        [TestMethod]
        public void Properties()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "propertytests" } },

                    PropertyDefinitions = new List<PropertyDefinitionType>
                    {
                        new PropertyDefinitionType
                        {
                            Identifier = "prop1",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property1 (a boolean)"} },
                            Type = DataType.Boolean
                        },
                        new PropertyDefinitionType
                        {
                            Identifier = "prop2",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property2 (a string)"} },
                            Type = DataType.StringText
                        },
                        new PropertyDefinitionType
                        {
                            Identifier = "prop3",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property3 (a currency)"} },
                            Type = DataType.Currency
                        },
                        new PropertyDefinitionType
                        {
                            Identifier = "prop4",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property4 (a date)"} },
                            Type = DataType.Date
                        },
                        new PropertyDefinitionType
                        {
                            Identifier = "prop5",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property5 (a number)"} },
                            Type = DataType.Number
                        },
                        new PropertyDefinitionType
                        {
                            Identifier = "prop6",
                            Name = new List<LangStringType> { new  LangStringType {  Value = "Property6 (a time)"} },
                            Type = DataType.Time
                        }
                    },
                    Properties = new List<PropertyType>
                    {
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop1",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "waar"},
                                new LangStringType { Lang = "en", Value = "true"}
                            }
                        },
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop2",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "Hello"},
                                new LangStringType { Lang = "en", Value = "World"}
                            }
                        },
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop3",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "euro"},
                                new LangStringType { Value = "pound"}
                            }
                        },
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop4",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "23/12/2020"},
                                new LangStringType { Lang = "en-us",  Value = "12/23/2020"}
                            }
                        },
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop5",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "1"},
                                new LangStringType { Lang = "en-us",  Value = "2"}
                            }
                        } ,
                        new PropertyType
                        {
                            PropertyDefinitionRef = "prop6",
                            Value = new List<LangStringType>
                            {
                                new LangStringType { Lang = "nl", Value = "12:00"},
                                new LangStringType { Lang = "en-us",  Value = "23:00"}
                            }
                        }
                    },
                    Elements = new List<ElementType>
                    {
                        new BusinessActor
                        {
                            Identifier = "actor1",
                            Name = new List<LangStringType> { new LangStringType { Value = "actor1"}},
                            Properties = new List<PropertyType>
                            {
                                new PropertyType
                                {
                                    PropertyDefinitionRef = "prop1",
                                    Value = new List<LangStringType>
                                    {
                                        new LangStringType { Lang = "nl", Value = "waar"},
                                        new LangStringType { Lang = "en", Value = "true"}
                                    }
                                }
                            }
                        },
                        new BusinessActor { Identifier = "actor2", Name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                    },
                    Relationships = new List<RelationshipType>
                    {
                        new Composition
                        {
                            Identifier = "composition1",
                            Source = "actor1",
                            Target = "actor2",
                            Properties = new List<PropertyType>
                            {
                                new PropertyType
                                {
                                    PropertyDefinitionRef = "prop2",
                                    Value = new List<LangStringType>
                                    {
                                        new LangStringType { Value = "Hello World"},
                                     }
                                }
                            }

                        },
                    },
                }
                , TempFileName(string.Empty)
            );

            Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));

        }

        [TestMethod]
        public void Organization()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "organizationtests" } },
                    Elements = new List<ElementType>
                    {
                        new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { Identifier = "actor2", Name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { Identifier = "actor3", Name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                        new BusinessObject { Identifier = "object1", Name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                        new BusinessObject { Identifier = "object2", Name = new List<LangStringType> { new LangStringType { Value = "object2"}} },
                        new BusinessObject { Identifier = "object3", Name = new List<LangStringType> { new LangStringType { Value = "object3"}} },
                    },
                    Relationships = new List<RelationshipType>
                    {
                        new Association { Identifier = "association1", Source= "actor1", Target = "object1", IsDirected = true},
                        new Association { Identifier = "association2", Source= "actor1", Target = "object1", IsDirected = false },
                    },
                    Organizations = new List<OrganizationType>
                    {
                        new OrganizationType
                        {
                            Identifier = "org1",
                            Label = new List<LangStringType> { new LangStringType { Value = "Objects" }  },
                            Documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org1" }  },
                            Item = new List<OrganizationType>
                            {

                                new OrganizationType {  IdentifierRef = "actor1"},
                                new OrganizationType {  IdentifierRef = "actor2"},
                                new OrganizationType {  IdentifierRef = "actor3"},
                                new OrganizationType {  IdentifierRef = "object1"},
                                new OrganizationType {  IdentifierRef = "object2"},
                                new OrganizationType {  IdentifierRef = "object3"},
                                new OrganizationType
                                {
                                    Identifier = "org1.1",
                                    Label = new List<LangStringType> { new LangStringType { Value = "Even objects" }  },
                                    Documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org1.1" }  },
                                    Item = new List<OrganizationType>
                                    {
                                        new OrganizationType {  IdentifierRef = "actor2"},
                                        new OrganizationType {  IdentifierRef = "object2"}
                                    }
                                },
                            }
                        },
                        new OrganizationType
                        {
                            Identifier = "org2",
                            Label = new List<LangStringType> { new LangStringType { Value = "Relationships" }  },
                            Documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org2" }  },
                            Item = new List<OrganizationType>
                            {
                                new OrganizationType {  IdentifierRef = "association1"},
                                new OrganizationType {  IdentifierRef = "association2"}
                            }
                        }
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Organizations.Count == 2);
            Assert.IsTrue(Result.Model.Organizations.First().Item.Count == 7);
            Assert.IsTrue(Result.Model.Organizations.First().Item.Last().Item.Count == 2);
            Assert.IsTrue(Result.Model.Organizations.Last().Item.Count == 2);
        }

        [TestMethod]
        public void ViewPoint()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);

            var OrgViewPoint = new ViewpointType
            {
                Identifier = "viewpoint1",
                Name = new List<LangStringType> { new LangStringType { Value = "Custom viewpoint 1" } },
                ModelingNotes = new List<ModelingNoteType>
                {
                    new ModelingNoteType
                    {
                        Documentation = new List<PreservedLangStringType>
                        {
                            new PreservedLangStringType
                            {
                                Value = "documentation on modeling note"
                            }
                        },
                        Type = " type of modeling note"
                    }
                },
                Properties = new List<PropertyType>
                {
                    new PropertyType
                    {
                        PropertyDefinitionRef = "prop1",
                        Value = new List<LangStringType> { new LangStringType { Value = "Property value on a viewpoint" } }
                    }
                },
                Concerns = new List<ConcernType>
                {
                    new ConcernType
                    {
                        Label = new List<LangStringType>
                        {
                            new LangStringType { Value = "Identification of competencies, authority, and responsibilities" }
                        },
                        Documentation = new List<PreservedLangStringType>
                        {
                            new PreservedLangStringType
                            {
                                Value = "default language Documentation on this concern"
                            },
                            new PreservedLangStringType
                            {
                                Lang = "en-us",
                                Value = "en-us documentation on this concern"
                            },
                        },
                        Stakeholders = new List<StakeholderType>
                        {
                            new StakeholderType
                            {
                                Label = new List<LangStringType> { new LangStringType {  Value = "Enterprise" } }
                            },
                            new StakeholderType
                            {
                                Label = new List<LangStringType> { new LangStringType {  Value = "process and domain architects" } }
                            },
                            new StakeholderType
                            {
                                Label = new List<LangStringType> { new LangStringType {  Value = "managers" } }
                            },
                            new StakeholderType
                            {
                                Label = new List<LangStringType> { new LangStringType {  Value = "employees" } }
                            },
                            new StakeholderType
                            {
                                Label = new List<LangStringType> { new LangStringType {  Value = "shareholders" } }
                            }
                        },
                    },
                    new ConcernType
                    {
                        Label = new List<LangStringType>
                        {
                            new LangStringType { Value = "2nd test concern" }
                        },
                    }
                },
                ViewpointContent = "Overview",
                ViewpointPurpose = "Designing",
                AllowedElementTypes = new List<AllowedElementTypeType>
                {
                    new AllowedElementTypeType { Type = typeof(BusinessActor).Name},
                    new AllowedElementTypeType { Type = typeof(BusinessRole).Name},
                    new AllowedElementTypeType { Type = typeof(BusinessCollaboration).Name},
                    new AllowedElementTypeType { Type = typeof(Location).Name},
                    new AllowedElementTypeType { Type = typeof(BusinessInterface).Name},
                },
                AllowedRelationshipTypes = new List<AllowedRelationshipTypeType>
                {
                    new AllowedRelationshipTypeType { Type = AllowedRelationshipType.Composition},
                    new AllowedRelationshipTypeType { Type = AllowedRelationshipType.Association}
                }
            };

            var Buffer = Serialize(
                new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "viewpointtest" } },
                    PropertyDefinitions = new List<PropertyDefinitionType>
                    {
                        new PropertyDefinitionType
                        {
                            Identifier = "prop1",
                            Name = new List<LangStringType> { new LangStringType { Value = "prop1" } },
                            Type = DataType.StringText
                        }
                    },
                    Elements = new List<ElementType>
                    {
                        new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { Identifier = "actor2", Name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { Identifier = "actor3", Name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                    },
                    Relationships = new List<RelationshipType>
                    {
                        new Composition { Identifier = "composition1", Source= "actor1", Target = "actor2"},
                        new Composition { Identifier = "ccomposition2", Source= "actor2", Target = "actor3"},
                    },
                    Views = new ViewsType
                    {
                        Viewpoints = new List<ViewpointType>
                        {
                           OrgViewPoint
                        },
                        Diagrams = new List<Diagram>
                        {
                            new Diagram
                            {
                                Identifier = "view1",
                                Name  = new List<LangStringType> { new LangStringType { Value = "View1"} },
                                ViewpointRef = OrgViewPoint.Identifier,
                            },
                            new Diagram
                            {
                                Identifier = "view2",
                                Name  = new List<LangStringType> { new LangStringType { Value = "View2"} },
                                Viewpoint = "Application Cooperation",
                            }
                        }
                    }
                }
                , TempFileName(string.Empty)
            );

            Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
        }

        [TestMethod]
        public void Diagram()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var MyModel = new ModelType
            {
                Identifier = "id-1",
                Name = new List<LangStringType> { new LangStringType { Value = "diagramtest" } },
                Elements = new List<ElementType>
                    {
                        new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { Identifier = "actor2", Name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { Identifier = "actor3", Name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                    },
                Relationships = new List<RelationshipType>
                    {
                        new Composition { Identifier = "composition1", Source= "actor1", Target = "actor2"},
                        new Composition { Identifier = "composition2", Source= "actor2", Target = "actor3"},
                    },
                Views = new ViewsType
                {
                    Diagrams = new List<Diagram>
                        {
                            new Diagram
                            {
                                Identifier = "view1",
                                Name  = new List<LangStringType> { new LangStringType { Value = "View1"} },
                                Nodes = new List<ViewNodeType>
                                {
                                    new Container
                                    {
                                        Identifier = "node1",
                                        Label = new List<LangStringType> { new LangStringType { Value = "Group that holds nodes"} },
                                        X = 0,
                                        Y = 0,
                                        W = 577,
                                        H = 301,
                                        Style = new StyleType
                                        {
                                            FillColor = new RgbColorType
                                            {
                                                R = 209,
                                                G = 209,
                                                B = 207,
                                            },
                                            LineColor = new RgbColorType
                                            {
                                                R = 255,
                                                G = 0,
                                                B = 0,
                                            },
                                            LineWidth = "5",
                                            Font = new FontType
                                            {
                                                Color = new RgbColorType
                                                {
                                                    R = 255,
                                                    G = 255,
                                                    B = 255,
                                                },
                                                Name = "Lato",
                                                Size = 13.5M,
                                                Style = new List<FontStyle> { FontStyle.bold, FontStyle.italic, FontStyle.underline }
                                            }
                                        },
                                        Nodes = new List<ViewNodeType>
                                        {
                                            new Element
                                            {
                                                Identifier="node1.1",
                                                W = 144,
                                                H = 60,
                                                X = 108,
                                                Y = 132,
                                                ElementRef = "actor1",
                                                Style = new StyleType
                                                {
                                                    FillColor = new RgbColorType
                                                    {
                                                        R = 252,
                                                        G = 193,
                                                        B = 61,
                                                        A = 30
                                                    },
                                                    Font = new FontType
                                                    {
                                                        Color = new RgbColorType
                                                        {
                                                            R = 0,
                                                            G = 0,
                                                            B = 0,
                                                            A = 30,
                                                        },
                                                    }
                                                }
                                            },
                                            new Element
                                            {
                                                Identifier="node1.2",
                                                W = 144,
                                                H = 60,
                                                X = 312,
                                                Y = 132,
                                                ElementRef = "actor2",
                                            }
                                        }

                                    }

                                },
                                Connections = new List<ConnectionType>
                                {
                                    new Relationship
                                    {
                                        Identifier = "r1",
                                        RelationshipRef = "composition1",
                                        Source = "node1.1",
                                        Target = "node1.2",
                                        SourceAttachment = new LocationType
                                        {
                                            X = 108,
                                            Y = 162
                                        },
                                        Bendpoints = new List<LocationType>
                                        {
                                            new LocationType
                                            {
                                                X = 60,
                                                Y = 162,
                                            },
                                            new LocationType
                                            {
                                                X = 60,
                                                Y = 69,
                                            },
                                            new LocationType
                                            {
                                                X = 384,
                                                Y = 69,
                                            }

                                        }
                                    }
                                }
                            },
                            new Diagram
                            {
                                Identifier = "view2",
                                Name  = new List<LangStringType> { new LangStringType { Value = "View2"} },
                            }
                        }
                }
            };



            var Buffer = Serialize(MyModel, TempFileName(string.Empty));
            Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
        }

        [TestMethod]
        public void RelationshipAssociation()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "associationtest" } },
                    Elements = new List<ElementType>
                    {
                        new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessObject { Identifier = "object1", Name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                    },
                    Relationships = new List<RelationshipType>
                    {
                        new Association { Identifier = "association1", Source= "actor1", Target = "object1", IsDirected = true},
                        new Association { Identifier = "association2", Source= "actor1", Target = "object1", IsDirected = false },
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Relationships.OfType<Association>().First().IsDirected);
            Assert.IsFalse(Result.Model.Relationships.OfType<Association>().Last().IsDirected);
            Assert.IsFalse(Result.Xml.Contains("isDirected=\"false\""));
        }

        [TestMethod]
        public void RelationshipAccess()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new ModelType
                {
                    Identifier = "id-1",
                    Name = new List<LangStringType> { new LangStringType { Value = "accesstest" } },
                    Elements = new List<ElementType>
                    {
                        new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessObject { Identifier = "object1", Name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                    },
                    Relationships = new List<RelationshipType>
                    {
                        new Access { Identifier = "access1", Source= "actor1", Target = "object1", AccessType = AccessType.ReadWrite },
                        new Access { Identifier = "access2", Source= "actor1", Target = "object1" },
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Relationships.OfType<Access>().First().AccessType == AccessType.ReadWrite);
            Assert.IsTrue(Result.Model.Relationships.OfType<Access>().Last().AccessType == AccessType.Access);
            Assert.IsTrue(Result.Xml.Contains("accessType=\"ReadWrite\""));
            Assert.IsFalse(Result.Xml.Contains("accessType=\"Access\""));
        }

        [TestMethod]
        public void RelationshipInfluence()
        {
            var ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new ModelType
                 {
                     Identifier = "id-1",
                     Name = new List<LangStringType> { new LangStringType { Value = "influencetest" } },
                     Elements = new List<ElementType>
                        {
                            new BusinessActor { Identifier = "actor1", Name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                            new BusinessObject { Identifier = "object1", Name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                        },
                     Relationships = new List<RelationshipType>
                        {
                            new Influence { Identifier = "inf1", Source= "actor1", Target = "object1", Modifier = "++" },
                            new Influence { Identifier = "inf2", Source= "actor1", Target = "object1" },
                        }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsFalse(ValidationIssues.Any(), string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Relationships.OfType<Influence>().First().Modifier == "++");
            Assert.IsTrue(Result.Model.Relationships.OfType<Influence>().Last().Modifier == null);
            Assert.IsTrue(Result.Xml.Contains("modifier=\"++\""));
            Assert.IsFalse(Result.Xml.Contains("modifier=\"\""));
        }

        [TestMethod]
        public void RGBColor()
        {
            var ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new RgbColorType
                {
                    R = 255,
                    G = 254,
                    B = 0,
                },
                TempFileName("1")
            );

            var Result = Deserialize<RgbColorType>(Buffer, MyXmlReaderSettings);
            var Errors = ValidationIssues
                     .Where(i => i.Severity == XmlSeverityType.Error)
                     .Select(i => i.Exception.ToString())
            ;
            Assert.IsFalse(Errors.Any(), string.Join("\n",Errors));
            Assert.AreEqual(255, Result.Model.R);
            Assert.AreEqual(254, Result.Model.G);
            Assert.AreEqual(0, Result.Model.B);
            Assert.AreEqual(null, Result.Model.A);
            Assert.IsFalse(Result.Xml.Contains("a=\""));

            Buffer = Serialize(
                new RgbColorType
                {
                    R = 255,
                    G = 254,
                    B = 0,
                    A = 30,
                },
                TempFileName("2")
            );
            Result = Deserialize<RgbColorType>(Buffer, MyXmlReaderSettings);
            Errors = ValidationIssues
                     .Where(i => i.Severity == XmlSeverityType.Error)
                     .Select(i => i.Exception.ToString())
            ;
            Assert.IsFalse(Errors.Any(), string.Join("\n", Errors));
            Assert.AreEqual(255, Result.Model.R);
            Assert.AreEqual(254, Result.Model.G);
            Assert.AreEqual(0, Result.Model.B);
            Assert.AreEqual((byte)30, Result.Model.A);
            Assert.IsTrue(Result.Xml.Contains("a=\"30\""));
        }
    }
}

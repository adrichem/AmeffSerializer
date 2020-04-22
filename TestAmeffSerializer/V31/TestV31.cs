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
            Schemas = new XmlSchemaSet();
            Schemas.XmlResolver = new XmlUrlResolver();
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
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "empty" } }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.Any.Count == 0);
            Assert.IsTrue(Result.Model.AnyAttr.Count == 0);
            Assert.IsTrue(Result.Model.documentation.Count == 0);
            Assert.IsTrue(Result.Model.elements.Count == 0);
            Assert.IsTrue(Result.Model.metadata == null);
            Assert.IsTrue(Result.Model.relationships.Count == 0);
            Assert.IsTrue(Result.Model.organizations.Count == 0);
            Assert.IsTrue(Result.Model.properties.Count == 0);
            Assert.IsTrue(Result.Model.propertyDefinitions.Count == 0);
            Assert.IsTrue(Result.Model.views == null);
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
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "empty" } },
                    documentation = new List<PreservedLangStringType>
                    {
                        new PreservedLangStringType {  Value = ExpectedDocumentation1},
                        new PreservedLangStringType { lang = ExpectedLanguage2, Value = ExpectedDocumentation2},
                    }
                }, 
                TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.AreEqual(ExpectedLanguage1, Result.Model.documentation.First().lang);
            Assert.AreEqual(ExpectedDocumentation1, Result.Model.documentation.First().Value);
            Assert.AreEqual(ExpectedLanguage2, Result.Model.documentation.Last().lang);
            Assert.AreEqual(ExpectedDocumentation2, Result.Model.documentation.Last().Value);
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
                identifier = "id-1",
                name = new List<LangStringType> { new LangStringType { Value = "metadata" } },
                metadata = new MetadataType
                {
                    Items = new object[]
                    {
                        new SchemaInfoType
                        {
                            schema = "schema1" ,
                            schemaversion = "1",
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
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.metadata.Items.Count() == 1);

            SchemaInfoType ActualItem1 = Result.Model.metadata.Items.First() as SchemaInfoType;
            XmlElement ActualTitle = ActualItem1.Any.First() as XmlElement;
            XmlElement ActualCreator = ActualItem1.Any.Skip(1).First() as XmlElement;
            Assert.IsTrue(ActualItem1.schema == "schema1");
            Assert.IsTrue(ActualItem1.schemaversion == "1");
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
                identifier = "id-1",
                name = new List<LangStringType> { new LangStringType { Value = "metadata" } },
                metadata = new MetadataType
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
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.metadata.Items.Count() == 4);

            string ActualSchema = Result.Model.metadata.Items.First() as string;
            string ActualSchemaVersion = Result.Model.metadata.Items.Skip(1).First() as string;
            XmlElement ActualTitle = Result.Model.metadata.Items.Skip(2).First() as XmlElement;
            XmlElement ActualCreator = Result.Model.metadata.Items.Skip(3).First() as XmlElement;
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
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "propertytests" } },

                    propertyDefinitions = new List<PropertyDefinitionType>
                    {
                        new PropertyDefinitionType
                        {
                            identifier = "prop1",
                            name = new List<LangStringType> { new  LangStringType {  Value = "Property1 (a boolean)"} },
                            type = DataType.boolean
                        },
                        new PropertyDefinitionType
                        {
                            identifier = "prop2",
                            name = new List<LangStringType> { new  LangStringType {  Value = "Property2 (a string)"} },
                            type = DataType.@string
                        }
                    },
                    properties = new List<PropertyType>
                    {
                        new PropertyType
                        {
                            propertyDefinitionRef = "prop1",
                            value = new List<LangStringType>
                            {
                                new LangStringType { lang = "nl", Value = "waar"},
                                new LangStringType { lang = "en", Value = "true"}
                            }
                        },
                        new PropertyType
                        {
                            propertyDefinitionRef = "prop2",
                            value = new List<LangStringType>
                            {
                                new LangStringType { lang = "nl", Value = "Hello"},
                                new LangStringType { lang = "en", Value = "World"}
                            }
                        }
                    },
                    elements = new List<ElementType>
                    {
                        new BusinessActor
                        {
                            identifier = "actor1",
                            name = new List<LangStringType> { new LangStringType { Value = "actor1"}},
                            properties = new List<PropertyType>
                            {
                                new PropertyType
                                {
                                    propertyDefinitionRef = "prop1",
                                    value = new List<LangStringType>
                                    {
                                        new LangStringType { lang = "nl", Value = "waar"},
                                        new LangStringType { lang = "en", Value = "true"}
                                    }
                                }
                            }
                        },
                        new BusinessActor { identifier = "actor2", name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                    },
                    relationships = new List<RelationshipType>
                    {
                        new Composition
                        {
                            identifier = "composition1",
                            source = "actor1",
                            target = "actor2",
                            properties = new List<PropertyType>
                            {
                                new PropertyType
                                {
                                    propertyDefinitionRef = "prop2",
                                    value = new List<LangStringType>
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

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));

        }

        [TestMethod]
        public void Organization()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(new ModelType
                {
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "organizationtests" } },
                    elements = new List<ElementType>
                    {
                        new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { identifier = "actor2", name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { identifier = "actor3", name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                        new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                        new BusinessObject { identifier = "object2", name = new List<LangStringType> { new LangStringType { Value = "object2"}} },
                        new BusinessObject { identifier = "object3", name = new List<LangStringType> { new LangStringType { Value = "object3"}} },
                    },
                    relationships = new List<RelationshipType>
                    {
                        new Association { identifier = "association1", source= "actor1", target = "object1", isDirected = true},
                        new Association { identifier = "association2", source= "actor1", target = "object1", isDirected = false },
                    },
                    organizations = new List<OrganizationType>
                    {
                        new OrganizationType
                        {
                            identifier = "org1",
                            label = new List<LangStringType> { new LangStringType { Value = "Objects" }  },
                            documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org1" }  },
                            item = new List<OrganizationType>
                            {

                                new OrganizationType {  identifierRef = "actor1"},
                                new OrganizationType {  identifierRef = "actor2"},
                                new OrganizationType {  identifierRef = "actor3"},
                                new OrganizationType {  identifierRef = "object1"},
                                new OrganizationType {  identifierRef = "object2"},
                                new OrganizationType {  identifierRef = "object3"},
                                new OrganizationType
                                {
                                    identifier = "org1.1",
                                    label = new List<LangStringType> { new LangStringType { Value = "Even objects" }  },
                                    documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org1.1" }  },
                                    item = new List<OrganizationType>
                                    {
                                        new OrganizationType {  identifierRef = "actor2"},
                                        new OrganizationType {  identifierRef = "object2"}
                                    }
                                },
                            }
                        },
                        new OrganizationType
                        {
                            identifier = "org2",
                            label = new List<LangStringType> { new LangStringType { Value = "Relationships" }  },
                            documentation = new List<PreservedLangStringType> { new PreservedLangStringType { Value = "This is doc of org2" }  },
                            item = new List<OrganizationType>
                            {
                                new OrganizationType {  identifierRef = "association1"},
                                new OrganizationType {  identifierRef = "association2"}
                            }
                        }
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.organizations.Count() == 2);
            Assert.IsTrue(Result.Model.organizations.First().item.Count() == 7);
            Assert.IsTrue(Result.Model.organizations.First().item.Last().item.Count() == 2);
            Assert.IsTrue(Result.Model.organizations.Last().item.Count() == 2);
        }

        [TestMethod]
        public void ViewPoint()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);

            var OrgViewPoint = new ViewpointType
            {
                identifier = "viewpoint1",
                name = new List<LangStringType> { new LangStringType { Value = "Custom viewpoint 1" } },
                concern = new List<ConcernType>
                {
                    new ConcernType
                    {
                        label = new List<LangStringType>
                        {
                            new LangStringType { Value = "Identification of competencies, authority, and responsibilities" }
                        },
                        stakeholders = new List<StakeholderType>
                        {
                            new StakeholderType
                            {
                                label = new List<LangStringType> { new LangStringType {  Value = "Enterprise" } }
                            },
                            new StakeholderType
                            {
                                label = new List<LangStringType> { new LangStringType {  Value = "process and domain architects" } }
                            },
                            new StakeholderType
                            {
                                label = new List<LangStringType> { new LangStringType {  Value = "managers" } }
                            },
                            new StakeholderType
                            {
                                label = new List<LangStringType> { new LangStringType {  Value = "employees" } }
                            },
                            new StakeholderType
                            {
                                label = new List<LangStringType> { new LangStringType {  Value = "shareholders" } }
                            }
                        },
                    }
                },
                allowedElementType = new List<AllowedElementTypeType>
                {
                    new AllowedElementTypeType { type = typeof(BusinessActor).Name},
                    new AllowedElementTypeType { type = typeof(BusinessRole).Name},
                    new AllowedElementTypeType { type = typeof(BusinessCollaboration).Name},
                    new AllowedElementTypeType { type = typeof(Location).Name},
                    new AllowedElementTypeType { type = typeof(BusinessInterface).Name},
                },
                allowedRelationshipType = new List<AllowedRelationshipTypeType>
                {
                    new AllowedRelationshipTypeType { type = RelationshipTypeEnum.Composition},
                    new AllowedRelationshipTypeType { type = RelationshipTypeEnum.Association}
                }
            };

            var Buffer = Serialize(
                new ModelType
                {
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "viewpointtest" } },
                    elements = new List<ElementType>
                    {
                        new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { identifier = "actor2", name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { identifier = "actor3", name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                    },
                    relationships = new List<RelationshipType>
                    {
                        new Composition { identifier = "composition1", source= "actor1", target = "actor2"},
                        new Composition { identifier = "ccomposition2", source= "actor2", target = "actor3"},
                    },
                    views = new ViewsType
                    {
                        viewpoints = new List<ViewpointType>
                        {
                           OrgViewPoint
                        },
                        diagrams = new List<Diagram>
                        {
                            new Diagram
                            {
                                identifier = "view1",
                                name  = new List<LangStringType> { new LangStringType { Value = "View1"} },
                                viewpointRef = OrgViewPoint.identifier,
                            },
                            new Diagram
                            {
                                identifier = "view2",
                                name  = new List<LangStringType> { new LangStringType { Value = "View2"} },
                                viewpoint = "Application Cooperation",
                            }
                        }
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
        }

        [TestMethod]
        public void Diagram()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var MyModel = new ModelType
            {
                identifier = "id-1",
                name = new List<LangStringType> { new LangStringType { Value = "diagramtest" } },
                elements = new List<ElementType>
                    {
                        new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessActor { identifier = "actor2", name = new List<LangStringType> { new LangStringType { Value = "actor2"}} },
                        new BusinessActor { identifier = "actor3", name = new List<LangStringType> { new LangStringType { Value = "actor3"}} },
                    },
                relationships = new List<RelationshipType>
                    {
                        new Composition { identifier = "composition1", source= "actor1", target = "actor2"},
                        new Composition { identifier = "composition2", source= "actor2", target = "actor3"},
                    },
                views = new ViewsType
                {
                    diagrams = new List<Diagram>
                        {
                            new Diagram
                            {
                                identifier = "view1",
                                name  = new List<LangStringType> { new LangStringType { Value = "View1"} },
                                node = new List<ViewNodeType>
                                {
                                    new Container
                                    {
                                        identifier = "node1",
                                        label = new List<LangStringType> { new LangStringType { Value = "Group that holds nodes"} },
                                        X = 0,
                                        Y = 0,
                                        W = 577,
                                        H = 301,
                                        style = new StyleType
                                        {
                                            fillColor = new RGBColorType
                                            {
                                                R = 209,
                                                G = 209,
                                                B = 207,
                                            },
                                            lineColor = new RGBColorType
                                            {
                                                R = 255,
                                                G = 0,
                                                B = 0,
                                            },
                                            lineWidth = "5",
                                            font = new FontType
                                            {
                                                color = new RGBColorType
                                                {
                                                    R = 255,
                                                    G = 255,
                                                    B = 255,
                                                },
                                                name = "Lato",
                                                size = 13.5M,
                                                style = new List<FontStyleEnum> { FontStyleEnum.bold, FontStyleEnum.italic, FontStyleEnum.underline }
                                            }
                                        },
                                        node = new List<ViewNodeType>
                                        {
                                            new Element
                                            {
                                                identifier="node1.1",
                                                W = 144,
                                                H = 60,
                                                X = 108,
                                                Y = 132,
                                                elementRef = "actor1",
                                                style = new StyleType
                                                {
                                                    fillColor = new RGBColorType
                                                    {
                                                        R = 252,
                                                        G = 193,
                                                        B = 61,
                                                        A = 30
                                                    },
                                                    font = new FontType
                                                    {
                                                        color = new RGBColorType
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
                                                identifier="node1.2",
                                                W = 144,
                                                H = 60,
                                                X = 312,
                                                Y = 132,
                                                elementRef = "actor2",
                                            }
                                        }

                                    }

                                },
                                connection = new List<ConnectionType>
                                {
                                    new Relationship
                                    {
                                        identifier = "r1",
                                        relationshipRef = "composition1",
                                        source = "node1.1",
                                        target = "node1.2",
                                        sourceAttachment = new LocationType
                                        {
                                            X = 108,
                                            Y = 162
                                        },
                                        bendpoint = new List<LocationType>
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
                                identifier = "view2",
                                name  = new List<LangStringType> { new LangStringType { Value = "View2"} },
                            }
                        }
                }
            };



            var Buffer = Serialize(MyModel, TempFileName(string.Empty));
            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
        }

        [TestMethod]
        public void RelationshipAssociation()
        {
            IList<ValidationEventArgs> ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new ModelType
                {
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "associationtest" } },
                    elements = new List<ElementType>
                    {
                        new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                    },
                    relationships = new List<RelationshipType>
                    {
                        new Association { identifier = "association1", source= "actor1", target = "object1", isDirected = true},
                        new Association { identifier = "association2", source= "actor1", target = "object1", isDirected = false },
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.relationships.OfType<Association>().First().isDirected);
            Assert.IsFalse(Result.Model.relationships.OfType<Association>().Last().isDirected);
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
                    identifier = "id-1",
                    name = new List<LangStringType> { new LangStringType { Value = "accesstest" } },
                    elements = new List<ElementType>
                    {
                        new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                        new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                    },
                    relationships = new List<RelationshipType>
                    {
                        new Access { identifier = "access1", source= "actor1", target = "object1", accessType = AccessTypeEnum.ReadWrite },
                        new Access { identifier = "access2", source= "actor1", target = "object1" },
                    }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.relationships.OfType<Access>().First().accessType == AccessTypeEnum.ReadWrite);
            Assert.IsTrue(Result.Model.relationships.OfType<Access>().Last().accessType == AccessTypeEnum.Access);
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
                     identifier = "id-1",
                     name = new List<LangStringType> { new LangStringType { Value = "influencetest" } },
                     elements = new List<ElementType>
                        {
                            new BusinessActor { identifier = "actor1", name = new List<LangStringType> { new LangStringType { Value = "actor1"}} },
                            new BusinessObject { identifier = "object1", name = new List<LangStringType> { new LangStringType { Value = "object1"}} },
                        },
                     relationships = new List<RelationshipType>
                        {
                            new Influence { identifier = "inf1", source= "actor1", target = "object1", modifier = "++" },
                            new Influence { identifier = "inf2", source= "actor1", target = "object1" },
                        }
                }
                , TempFileName(string.Empty)
            );

            var Result = Deserialize<ModelType>(Buffer, MyXmlReaderSettings);
            Assert.IsTrue(ValidationIssues.Count == 0, string.Join("\n", ValidationIssues.Select(i => i.Exception.ToString())));
            Assert.IsTrue(Result.Model.relationships.OfType<Influence>().First().modifier == "++");
            Assert.IsTrue(Result.Model.relationships.OfType<Influence>().Last().modifier == null);
            Assert.IsTrue(Result.Xml.Contains("modifier=\"++\""));
            Assert.IsFalse(Result.Xml.Contains("modifier=\"\""));
        }

        [TestMethod]
        public void RGBColor()
        {
            var ValidationIssues = new List<ValidationEventArgs>();
            var MyXmlReaderSettings = ReaderSettings(ValidationIssues);
            var Buffer = Serialize(
                new RGBColorType
                {
                    R = 255,
                    G = 254,
                    B = 0,
                },
                TempFileName("1")
            );

            var Result = Deserialize<RGBColorType>(Buffer, MyXmlReaderSettings);
            var Errors = ValidationIssues
                     .Where(i => i.Severity == XmlSeverityType.Error)
                     .Select(i => i.Exception.ToString())
            ;
            Assert.IsTrue(Errors.Count() == 0, string.Join("\n",Errors));
            Assert.AreEqual(255, Result.Model.R);
            Assert.AreEqual(254, Result.Model.G);
            Assert.AreEqual(0, Result.Model.B);
            Assert.AreEqual(null, Result.Model.A);
            Assert.IsFalse(Result.Xml.Contains("a=\""));

            Buffer = Serialize(
                new RGBColorType
                {
                    R = 255,
                    G = 254,
                    B = 0,
                    A = 30,
                },
                TempFileName("2")
            );
            Result = Deserialize<RGBColorType>(Buffer, MyXmlReaderSettings);
            Errors = ValidationIssues
                     .Where(i => i.Severity == XmlSeverityType.Error)
                     .Select(i => i.Exception.ToString())
            ;
            Assert.IsTrue(Errors.Count() == 0, string.Join("\n", Errors));
            Assert.AreEqual(255, Result.Model.R);
            Assert.AreEqual(254, Result.Model.G);
            Assert.AreEqual(0, Result.Model.B);
            Assert.AreEqual((byte)30, Result.Model.A);
            Assert.IsTrue(Result.Xml.Contains("a=\"30\""));
        }
    }
}

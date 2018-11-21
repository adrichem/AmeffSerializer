# AmeffSerializer
Serialize and deserialize ArchiMate Model Exchange File Format files (AMEFF). Supports V2.1 and V3.0.

## Deserialization example
```csharp
using Adrichem.Serialization.Ameff.V3

void Deserialize()
{
	string file = @"C:\temp\ArchiSurance V3.xml";
	ModelType MyAmeff;

	XmlSchemaSet Schemas = new XmlSchemaSet();
	Schemas.Add(null, "http://www.opengroup.org/xsd/archimate/3.0/archimate3_Diagram.xsd");
	Schemas.Add("http://purl.org/dc/elements/1.1/", "http://dublincore.org/schemas/xmls/qdc/2008/02/11/dc.xsd");

	var MyXmlReaderSettings = new XmlReaderSettings
	{
		Schemas = Schemas,
		ValidationType = ValidationType.Schema,
		ValidationFlags = XmlSchemaValidationFlags.ProcessIdentityConstraints |
						  XmlSchemaValidationFlags.ReportValidationWarnings
	};

	using (var Reader = new StreamReader(file))
	{
		using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
		{
			MyAmeff = new XmlSerializer(typeof(ModelType))
				.Deserialize(XmlRdr)
				as ModelType;

			MyAmeff
				.views
				.diagrams
				.Select(d => d.name.FirstOrDefault())
				.Dump()
			;
		}
	}
}
```

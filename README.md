# AmeffSerializer
Serialize and deserialize ArchiMate Model Exchange File Format files (AMEFF).

## Deserialization example
```csharp
using Adrichem.Serialization.Ameff.V31;
using Adrichem.Serialization.Ameff.V31.Diagram;
using System.Net;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

void Deserialize()
{
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
	var AmeffStream = WebRequest.Create("http://www.opengroup.org/xsd/archimate/3.1/examples/Model_View.xml").GetResponse().GetResponseStream();
	
	using (var Reader = new StreamReader(AmeffStream))
	{
		using (var XmlRdr = XmlReader.Create(Reader, MyXmlReaderSettings))
		{
			ModelType MyAmeff;
			MyAmeff = new XmlSerializer(typeof(ModelType))
				.Deserialize(XmlRdr)
				as ModelType;

			MyAmeff
				.Views
				.Diagrams
				.Select(d => d.Name.FirstOrDefault())
				.Dump()
			;
		}
	}
}
```

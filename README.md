# AmeffSerializer
Serialize and deserialize ArchiMate Model Exchange File Format files (AMEFF). 

Supports V2.1 and V3.0 (including viewpoints and diagrams)

## Deserialization example
```csharp
using Adrichem.Serialization.Ameff.V3

var Serializer = new XmlSerializer(typeof(ModelType));
var myV3Ameff = Serializer.Deserialize(new StreamReader(@".\ArchiSurance V3.xml")) as ModelType;

myV3Ameff
	.elements
	.Select(el => el.name.First().Value )
	.ForEach(name => System.Console.WriteLine(name))
;	
myV3Ameff
	.views
	.diagrams
	.Select(d => d.name.First().Value)
	.ForEach(name => System.Console.WriteLine(name))
;	
```

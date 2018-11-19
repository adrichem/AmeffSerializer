# AmeffSerializer
Serialize and deserialize ArchiMate Model Exchange File Format files.

## Deserialization example
```csharp
using Adrichem.Serialization.Ameff.V2

var myAmeff = (modelType) new XmlSerializer(typeof(modelType)).Deserialize(new StreamReader("test.xml"));
myAmeff
	.elements
	.Where(el => el is BusinessActor)
	.ForEach(el => System.Console.WriteLine(el.label.FirstOrDefault()))
;	
```

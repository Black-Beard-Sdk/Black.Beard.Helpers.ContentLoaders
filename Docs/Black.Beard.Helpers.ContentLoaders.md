<a name='assembly'></a>
# Black.Beard.Helpers.ContentLoaders

## Contents

- [ConfigurationHelper](#T-Bb-ConfigurationHelper 'Bb.ConfigurationHelper')
  - [DeserializeConfiguration(payload,targetType,options)](#M-Bb-ConfigurationHelper-DeserializeConfiguration-System-String,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ConfigurationHelper.DeserializeConfiguration(System.String,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [DeserializeConfiguration\`\`1(payload,options)](#M-Bb-ConfigurationHelper-DeserializeConfiguration``1-System-String,System-Text-Json-JsonSerializerOptions- 'Bb.ConfigurationHelper.DeserializeConfiguration``1(System.String,System.Text.Json.JsonSerializerOptions)')
  - [GenerateSchemaForConfiguration(type,id,configuration)](#M-Bb-ConfigurationHelper-GenerateSchemaForConfiguration-System-Type,System-Uri,Json-Schema-Generation-SchemaGeneratorConfiguration- 'Bb.ConfigurationHelper.GenerateSchemaForConfiguration(System.Type,System.Uri,Json.Schema.Generation.SchemaGeneratorConfiguration)')
  - [Serialize(schemaBuilder,options)](#M-Bb-ConfigurationHelper-Serialize-Json-Schema-JsonSchemaBuilder,System-Text-Json-JsonSerializerOptions- 'Bb.ConfigurationHelper.Serialize(Json.Schema.JsonSchemaBuilder,System.Text.Json.JsonSerializerOptions)')
  - [Serialize(schema,options)](#M-Bb-ConfigurationHelper-Serialize-Json-Schema-JsonSchema,System-Text-Json-JsonSerializerOptions- 'Bb.ConfigurationHelper.Serialize(Json.Schema.JsonSchema,System.Text.Json.JsonSerializerOptions)')
  - [SerializeConfiguration\`\`1(self,options)](#M-Bb-ConfigurationHelper-SerializeConfiguration``1-``0,System-Text-Json-JsonSerializerOptions- 'Bb.ConfigurationHelper.SerializeConfiguration``1(``0,System.Text.Json.JsonSerializerOptions)')
- [ConfigurationSerializer\`1](#T-Bb-ConfigurationSerializer`1 'Bb.ConfigurationSerializer`1')
  - [Configuration](#P-Bb-ConfigurationSerializer`1-Configuration 'Bb.ConfigurationSerializer`1.Configuration')
- [ContentHelper](#T-Bb-ContentHelper 'Bb.ContentHelper')
  - [ConvertFromBase64(self)](#M-Bb-ContentHelper-ConvertFromBase64-System-String- 'Bb.ContentHelper.ConvertFromBase64(System.String)')
  - [ConvertToBase64(self)](#M-Bb-ContentHelper-ConvertToBase64-System-String- 'Bb.ContentHelper.ConvertToBase64(System.String)')
  - [ConvertToString(self)](#M-Bb-ContentHelper-ConvertToString-System-IO-MemoryStream- 'Bb.ContentHelper.ConvertToString(System.IO.MemoryStream)')
  - [Deserialize(stream,targetType,options)](#M-Bb-ContentHelper-Deserialize-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize(System.IO.Stream,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize(self,sourceType,options)](#M-Bb-ContentHelper-Deserialize-System-String,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize(System.String,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(stream,targetType,options)](#M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.IO.Stream,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(stream,options)](#M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.IO.Stream,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(self,options)](#M-Bb-ContentHelper-Deserialize``1-System-String,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.String,System.Text.Json.JsonSerializerOptions)')
  - [Download(url,fileOutput,initializer)](#M-Bb-ContentHelper-Download-System-Uri,System-IO-FileInfo,System-Action{System-Net-Http-HttpClient}- 'Bb.ContentHelper.Download(System.Uri,System.IO.FileInfo,System.Action{System.Net.Http.HttpClient})')
  - [LoadContentFromText(text)](#M-Bb-ContentHelper-LoadContentFromText-System-Byte[]- 'Bb.ContentHelper.LoadContentFromText(System.Byte[])')
  - [RegisterEncoding()](#M-Bb-ContentHelper-RegisterEncoding 'Bb.ContentHelper.RegisterEncoding')
  - [Serialize(self,options)](#M-Bb-ContentHelper-Serialize-System-Object,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Serialize(System.Object,System.Text.Json.JsonSerializerOptions)')
  - [Serialize(self,indented)](#M-Bb-ContentHelper-Serialize-System-Object,System-Boolean- 'Bb.ContentHelper.Serialize(System.Object,System.Boolean)')
  - [SerializeToMemory(self,options)](#M-Bb-ContentHelper-SerializeToMemory-System-Object,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.SerializeToMemory(System.Object,System.Text.Json.JsonSerializerOptions)')
  - [SerializeToStream(self,stream,options)](#M-Bb-ContentHelper-SerializeToStream-System-Object,System-IO-Stream,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.SerializeToStream(System.Object,System.IO.Stream,System.Text.Json.JsonSerializerOptions)')

<a name='T-Bb-ConfigurationHelper'></a>
## ConfigurationHelper `type`

##### Namespace

Bb

<a name='M-Bb-ConfigurationHelper-DeserializeConfiguration-System-String,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### DeserializeConfiguration(payload,targetType,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the instance to serialize. |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | target Type |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

<a name='M-Bb-ConfigurationHelper-DeserializeConfiguration``1-System-String,System-Text-Json-JsonSerializerOptions-'></a>
### DeserializeConfiguration\`\`1(payload,options) `method`

##### Summary

Deserializes the specified payload into a strongly typed configuration object.

##### Returns

A [](#!-TargetType 'TargetType') instance deserialized from the JSON payload, or null if deserialization fails.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The JSON string payload to deserialize. Must not be null or empty. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Options for deserialization. If null, default options with indented formatting will be used. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target object to deserialize to. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON is invalid or doesn't match the expected structure. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when payload is null. |

##### Example

```C#
public class ServerConfig
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 8080;
}
// JSON string with the configuration in the expected format
string json = "{\"ServerConfig\":{\"Host\":\"example.com\",\"Port\":443}}";
// Deserialize the configuration
ServerConfig config = json.DeserializeConfiguration&lt;ServerConfig&gt;();
Console.WriteLine($"Host: {config.Host}, Port: {config.Port}");
// Output: Host: example.com, Port: 443
```

##### Remarks

This method deserializes a JSON string with a specific structure where
the object is expected to be nested under a property named after its type.
It's designed to work with JSON produced by the SerializeConfiguration method.

<a name='M-Bb-ConfigurationHelper-GenerateSchemaForConfiguration-System-Type,System-Uri,Json-Schema-Generation-SchemaGeneratorConfiguration-'></a>
### GenerateSchemaForConfiguration(type,id,configuration) `method`

##### Summary

Generates a JSON schema from a Type.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the JSON schema representation of the type.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type to generate schema for. Must not be null. |
| id | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | Optional URI identifier for the schema. If null, a default URI will be constructed using the type name. |
| configuration | [Json.Schema.Generation.SchemaGeneratorConfiguration](#T-Json-Schema-Generation-SchemaGeneratorConfiguration 'Json.Schema.Generation.SchemaGeneratorConfiguration') | Optional configuration for schema generation. If null, default settings will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when type is null. |

##### Example

```C#
// Generate schema for a configuration class
public class MyAppConfig
{
    public string ServerUrl { get; set; }
    public int Port { get; set; }
    public bool EnableLogging { get; set; }
}
// Generate schema with default settings
string schema = typeof(MyAppConfig).GenerateSchemaForConfiguration();
// Generate schema with custom URI
Uri schemaId = new Uri("https://mycompany.com/schemas/appconfig");
string customSchema = typeof(MyAppConfig).GenerateSchemaForConfiguration(schemaId);
```

##### Remarks

This method creates a JSON schema that describes the structure of the specified type.
It uses Json.Schema.Generation to generate the schema, then performs post-processing to
rename the root property from "Configuration" to the actual type name.

For more details on schema generation options, see the documentation:
https://docs.json-everything.net/schema/schemagen/data-annotations/

<a name='M-Bb-ConfigurationHelper-Serialize-Json-Schema-JsonSchemaBuilder,System-Text-Json-JsonSerializerOptions-'></a>
### Serialize(schemaBuilder,options) `method`

##### Summary

Serialize to string the specified schema.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the JSON serialized schema.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schemaBuilder | [Json.Schema.JsonSchemaBuilder](#T-Json-Schema-JsonSchemaBuilder 'Json.Schema.JsonSchemaBuilder') | Schema builder to serialize. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Options for serialization. If null, default options with indented formatting will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when schemaBuilder is null. |

##### Example

```C#
// Create a schema builder
var builder = new JsonSchemaBuilder()
    .Schema("https://json-schema.org/draft/2020-12/schema")
    .Id("https://example.com/schemas/person")
    .Title("Person")
    .Type(SchemaValueType.Object)
    .Properties(
        ("name", new JsonSchemaBuilder().Type(SchemaValueType.String)),
        ("age", new JsonSchemaBuilder().Type(SchemaValueType.Integer).Minimum(0))
    );
// Serialize the schema
string schemaJson = builder.Serialize();
// With custom options
var options = new JsonSerializerOptions { WriteIndented = false };
string compactSchemaJson = builder.Serialize(options);
```

##### Remarks

This method builds the schema from the JsonSchemaBuilder and serializes it to a formatted JSON string.
It's useful for saving schema definitions to files or sending them over network.

<a name='M-Bb-ConfigurationHelper-Serialize-Json-Schema-JsonSchema,System-Text-Json-JsonSerializerOptions-'></a>
### Serialize(schema,options) `method`

##### Summary

Serialize to string the specified schema.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the JSON serialized schema.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| schema | [Json.Schema.JsonSchema](#T-Json-Schema-JsonSchema 'Json.Schema.JsonSchema') | Schema to serialize. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Options for serialization. If null, default options with indented formatting will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when schema is null. |

##### Example

```C#
// With an existing JsonSchema object
JsonSchema schema = JsonSchema.FromText("{\"type\":\"object\",\"properties\":{\"name\":{\"type\":\"string\"}}}");
// Serialize the schema
string schemaJson = schema.Serialize();
// With custom options
var options = new JsonSerializerOptions { WriteIndented = false };
string compactSchemaJson = schema.Serialize(options);
```

##### Remarks

This method serializes a JsonSchema object to a formatted JSON string.
It's useful for saving schema definitions to files or sending them over network.

<a name='M-Bb-ConfigurationHelper-SerializeConfiguration``1-``0,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeConfiguration\`\`1(self,options) `method`

##### Summary

Serializes the specified self instance to a configuration JSON string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the serialized configuration, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [\`\`0](#T-``0 '``0') | The instance to serialize. May be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Options for serialization. If null, default options with indented formatting will be used. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the object to serialize. |

##### Example

```C#
public class ServerConfig
{
    public string Host { get; set; } = "localhost";
    public int Port { get; set; } = 8080;
}
// Serialize a configuration
var config = new ServerConfig { Host = "example.com", Port = 443 };
string json = config.SerializeConfiguration();
// Result: {"ServerConfig":{"Host":"example.com","Port":443}}
// With custom serialization options
var options = new JsonSerializerOptions { WriteIndented = false };
string compactJson = config.SerializeConfiguration(options);
```

##### Remarks

This method serializes an object into a JSON string with a specific structure where
the object is nested under a property named after its type. This format is designed
to be compatible with the DeserializeConfiguration method.

<a name='T-Bb-ConfigurationSerializer`1'></a>
## ConfigurationSerializer\`1 `type`

##### Namespace

Bb

##### Summary

Helper struct for serializing a configuration object with a standardized wrapper.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of configuration object to wrap. |

##### Remarks

This struct is used internally by the GenerateSchemaForConfiguration method
to provide a consistent structure for configuration objects in JSON schemas.

<a name='P-Bb-ConfigurationSerializer`1-Configuration'></a>
### Configuration `property`

##### Summary

Gets or sets the configuration object.

<a name='T-Bb-ContentHelper'></a>
## ContentHelper `type`

##### Namespace

Bb

<a name='M-Bb-ContentHelper-ConvertFromBase64-System-String-'></a>
### ConvertFromBase64(self) `method`

##### Summary

Decode the specified base 64 [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') encoded value.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the decoded value, or null if the input is null.
An empty string is returned if the input is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The Base64 encoded string to decode. May be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.FormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.FormatException 'System.FormatException') | Thrown when the input is not a valid Base64 string. |

##### Example

```C#
// Decode a Base64 string
string encoded = "SGVsbG8sIHdvcmxkIQ==";
string decoded = encoded.ConvertFromBase64();
Console.WriteLine(decoded); // Outputs: "Hello, world!"
// Decode an empty string
string emptyResult = "".ConvertFromBase64();
Console.WriteLine(emptyResult); // Outputs: ""
try {
    // This will throw a FormatException
    string invalid = "Not a valid Base64 string!";
    string result = invalid.ConvertFromBase64();
} catch (FormatException ex) {
    Console.WriteLine("Invalid Base64 input");
}
```

##### Remarks

This method decodes a Base64 string back to its original value using UTF-8 encoding.
It's the inverse operation of ConvertToBase64.

<a name='M-Bb-ContentHelper-ConvertToBase64-System-String-'></a>
### ConvertToBase64(self) `method`

##### Summary

Encodes the specified string as a Base64 string.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the Base64 encoded value, or null if the input is null.
An empty string is returned if the input is empty.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. May be null or empty. |

##### Example

```C#
// Encode a regular string to Base64
string original = "Hello, world!";
string encoded = original.ConvertToBase64();
Console.WriteLine(encoded); // Outputs: "SGVsbG8sIHdvcmxkIQ=="
// Encode an empty string
string emptyResult = "".ConvertToBase64();
Console.WriteLine(emptyResult); // Outputs: ""
```

##### Remarks

This method encodes a string to Base64 using UTF-8 encoding.
Base64 encoding is commonly used when binary data needs to be transmitted in text-based formats
or stored in text-based systems.

<a name='M-Bb-ContentHelper-ConvertToString-System-IO-MemoryStream-'></a>
### ConvertToString(self) `method`

##### Summary

Converts a memory stream to a string, detecting the encoding automatically.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the decoded content of the memory stream, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.MemoryStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryStream 'System.IO.MemoryStream') | The memory stream to convert. May be null. |

##### Example

```C#
// Create a memory stream with some content
string original = "Hello, world!";
byte[] bytes = Encoding.UTF8.GetBytes(original);
using (var memoryStream = new MemoryStream(bytes))
{
    // Convert the memory stream to a string
    string result = memoryStream.ConvertToString();
    Console.WriteLine(result); // Outputs: "Hello, world!"
}
```

##### Remarks

This method converts the memory stream to a byte array and then uses the LoadContentFromText method
to detect the encoding and convert it to a string. It handles null input by returning null.

<a name='M-Bb-ContentHelper-Deserialize-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize(stream,targetType,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns

An [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') of the specified type containing the deserialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Source stream containing the JSON data. Must not be null. |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type to generate from the JSON data. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control deserialization behavior. If null, default options will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when stream or targetType is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON data is invalid or doesn't match the target type's structure. |

##### Example

```C#
// Define a class to deserialize into
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
// JSON data in a file
using (var fileStream = File.OpenRead("product.json"))
{
    // Deserialize to the Product type
    var product = fileStream.Deserialize(typeof(Product)) as Product;
    
    if (product != null)
    {
        Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
    }
}
```

##### Remarks

This method deserializes JSON data from a stream into an object of the specified type.
It uses System.Text.Json.JsonSerializer to perform the deserialization.

<a name='M-Bb-ContentHelper-Deserialize-System-String,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize(self,sourceType,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns

An [Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') of the specified type containing the deserialized data, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The JSON string to deserialize. May be null. |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Target type to deserialize the JSON data into. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control deserialization behavior. If null, default options with indented formatting will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when sourceType is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON string is invalid or doesn't match the target type's structure. |

##### Example

```C#
// Define a class to deserialize into
public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
// JSON string data
string json = "{\"Id\":123,\"Name\":\"Widget\",\"Price\":19.99}";
// Get the type at runtime
Type productType = typeof(Product);
// Deserialize to the Product type
var product = json.Deserialize(productType) as Product;
if (product != null)
{
    Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
}
```

##### Remarks

This method deserializes a JSON string into an object of the specified type.
It uses System.Text.Json.JsonSerializer to perform the deserialization.
This non-generic version is useful when the target type is determined at runtime.

<a name='M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(stream,targetType,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns

A `T` object containing the deserialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Source stream containing the JSON data. Must not be null. |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Type to generate from the JSON data. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control deserialization behavior. If null, default options will be used. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to cast the result to. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when stream or targetType is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON data is invalid or doesn't match the target type's structure. |
| [System.InvalidCastException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.InvalidCastException 'System.InvalidCastException') | Thrown when the deserialized object cannot be cast to type T. |

##### Example

```C#
// Base interface
public interface IProduct 
{
    int Id { get; }
    string Name { get; }
}
// Implementation class
public class Product : IProduct
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
}
// JSON data in a memory stream
string json = "{\"Id\":101,\"Name\":\"Widget Pro\",\"Price\":29.99}";
using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
{
    // Deserialize to Product but cast to IProduct interface
    IProduct product = stream.Deserialize&lt;IProduct&gt;(typeof(Product));
    
    Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}");
}
```

##### Remarks

This method deserializes JSON data from a stream into an object of the specified target type,
and then casts the result to type T. This is useful when you need to deserialize to one type but
access the result through a base class or interface.

<a name='M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(stream,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns

A `T` object containing the deserialized data.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | Source stream containing the JSON data. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control deserialization behavior. If null, default options will be used. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Type to generate from the JSON data. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when stream is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON data is invalid or doesn't match the target type's structure. |

##### Example

```C#
// Define a class to deserialize into
public class User
{
    public string Username { get; set; }
    public string Email { get; set; }
    public int Age { get; set; }
}
// JSON data in a memory stream
string json = "{\"Username\":\"jdoe\",\"Email\":\"jdoe@example.com\",\"Age\":25}";
using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
{
    // Deserialize directly to the User type
    User user = stream.Deserialize&lt;User&gt;();
    
    Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Age: {user.Age}");
}
```

##### Remarks

This method deserializes JSON data from a stream directly into an object of type T.
It uses System.Text.Json.JsonSerializer to perform the deserialization.

<a name='M-Bb-ContentHelper-Deserialize``1-System-String,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(self,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns

A `SourceType` object containing the deserialized data, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The JSON string to deserialize. May be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control deserialization behavior. If null, default options with indented formatting will be used. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of object to deserialize the JSON data into. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the JSON string is invalid or doesn't match the target type's structure. |

##### Example

```C#
// Define a class to deserialize into
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string[] Hobbies { get; set; }
}
// JSON string data
string json = @"{
  ""Name"": ""Alice"",
  ""Age"": 28,
  ""Hobbies"": [""Reading"", ""Hiking"", ""Photography""]
}";
// Deserialize to the Person type
Person person = json.Deserialize&lt;Person&gt;();
if (person != null)
{
    Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
    Console.WriteLine("Hobbies: " + string.Join(", ", person.Hobbies));
}
```

##### Remarks

This method deserializes a JSON string into an object of the specified type.
It uses System.Text.Json.JsonSerializer to perform the deserialization.

<a name='M-Bb-ContentHelper-Download-System-Uri,System-IO-FileInfo,System-Action{System-Net-Http-HttpClient}-'></a>
### Download(url,fileOutput,initializer) `method`

##### Summary

Downloads content from a URL and saves it to a local file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL to download content from. Must not be null. |
| fileOutput | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file to save the downloaded content to. Must not be null and must not already exist. |
| initializer | [System.Action{System.Net.Http.HttpClient}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpClient}') | Optional action to configure the HTTP client before the request is made. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileLoadException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileLoadException 'System.IO.FileLoadException') | Thrown when the target file already exists. |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') | Thrown when the HTTP request fails. |
| [System.Net.Http.HttpRequestException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Net.Http.HttpRequestException 'System.Net.Http.HttpRequestException') | Thrown when the HTTP request fails or returns a non-success status code. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when url or fileOutput is null. |

##### Example

```C#
// Basic download example
Uri sourceUrl = new Uri("https://example.com/file.txt");
FileInfo targetFile = new FileInfo("C:\\Downloads\\file.txt");
sourceUrl.Download(targetFile);
// Download with HTTP client configuration
Uri secureUrl = new Uri("https://api.example.com/secured/document.pdf");
FileInfo pdfFile = new FileInfo("C:\\Downloads\\document.pdf");
secureUrl.Download(pdfFile, client =&gt; {
    client.DefaultRequestHeaders.Add("Authorization", "Bearer myToken123");
    client.Timeout = TimeSpan.FromMinutes(5);
});
```

##### Remarks

This method downloads content from the specified URL using an HTTP GET request and saves it to the specified file.
If the file already exists, a FileLoadException is thrown.
The method will await the result of the HTTP request and ensure a successful status code.
If the initializer is provided, it will be used to configure the HttpClient before making the request.

<a name='M-Bb-ContentHelper-LoadContentFromText-System-Byte[]-'></a>
### LoadContentFromText(text) `method`

##### Summary

Loads the content from a byte array and converts it to a string, detecting the encoding automatically.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the decoded text with BOM and other special characters removed, or null if input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The byte array containing the text to load. May be null. |

##### Example

```C#
// Load and detect encoding from a byte array
byte[] fileBytes = File.ReadAllBytes("example.txt");
string content = fileBytes.LoadContentFromText();
// Process text from different encodings
byte[] iso8859Bytes = Encoding.GetEncoding("ISO-8859-1").GetBytes("Café au lait");
string decoded = iso8859Bytes.LoadContentFromText();
Console.WriteLine(decoded); // Correctly displays: "Café au lait"
```

##### Remarks

This method performs the following operations:
1. Detects the character encoding of the text using the Ude.CharsetDetector
2. Converts the byte array to a string using the detected encoding
3. Removes the BOM (Byte Order Mark) if present
4. Converts the text to UTF-8 if it was in a different encoding
5. Removes any special characters like zero-width non-breaking spaces (U+FEFF)

<a name='M-Bb-ContentHelper-RegisterEncoding'></a>
### RegisterEncoding() `method`

##### Summary

Execute : Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
Register exotic encoding provider.

##### Parameters

This method has no parameters.

##### Example

```csharp
ContentHelper.RegisterEncoding();
```

<a name='M-Bb-ContentHelper-Serialize-System-Object,System-Text-Json-JsonSerializerOptions-'></a>
### Serialize(self,options) `method`

##### Summary

Serializes with indentation the specified object.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the JSON representation of the object, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. May be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control JSON serialization behavior. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when options is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the object cannot be serialized to JSON. |

##### Example

```C#
// Create an object to serialize
var person = new { Name = "John", Age = 30 };
// Serialize with default options
var options = new JsonSerializerOptions { WriteIndented = true };
string json = person.Serialize(options);
Console.WriteLine(json);
/* Output:
{
  "Name": "John",
  "Age": 30
}
*/
```

##### Remarks

This method serializes an object to a JSON string using System.Text.Json.
It uses the provided JsonSerializerOptions to control serialization behavior.

<a name='M-Bb-ContentHelper-Serialize-System-Object,System-Boolean-'></a>
### Serialize(self,indented) `method`

##### Summary

Serializes with indentation the specified object.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the JSON representation of the object, or null if the input is null.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. May be null. |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, the JSON output will be indented for better readability; otherwise, it will be compact. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the object cannot be serialized to JSON. |

##### Example

```C#
// Create an object to serialize
var person = new { Name = "John", Age = 30 };
// Serialize with indentation
string prettyJson = person.Serialize(true);
Console.WriteLine(prettyJson);
/* Output:
{
  "Name": "John",
  "Age": 30
}
*/
// Serialize without indentation
string compactJson = person.Serialize(false);
Console.WriteLine(compactJson);
// Output: {"Name":"John","Age":30}
```

##### Remarks

This method is a convenience wrapper around the Serialize method that takes a JsonSerializerOptions parameter.
It creates a new JsonSerializerOptions with the WriteIndented property set to the specified value.

<a name='M-Bb-ContentHelper-SerializeToMemory-System-Object,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeToMemory(self,options) `method`

##### Summary

Serializes the specified self instance in a memory.

##### Returns

A [MemoryStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryStream 'System.IO.MemoryStream') containing the serialized JSON data, positioned at the beginning of the stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. May be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control serialization behavior. If null, default options with indented formatting will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the object cannot be serialized to JSON. |

##### Example

```C#
// Create an object to serialize
var person = new { Name = "Jane", Age = 25 };
// Serialize to a memory stream
using (var stream = person.SerializeToMemory())
{
    // Use the stream, e.g., copy to another stream
    using (var fileStream = File.Create("person.json"))
    {
        stream.CopyTo(fileStream);
    }
    
    // Or read it back as a string
    stream.Position = 0;
    using (var reader = new StreamReader(stream))
    {
        string json = reader.ReadToEnd();
        Console.WriteLine(json);
    }
}
```

##### Remarks

This method serializes an object to a memory stream in JSON format.
It uses the SerializeToStream method internally and ensures that the stream position is reset to the beginning
after serialization so that the stream is ready to be read.

<a name='M-Bb-ContentHelper-SerializeToStream-System-Object,System-IO-Stream,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeToStream(self,stream,options) `method`

##### Summary

Serializes the specified self instance in the stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The object to serialize. May be null. |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | The stream to write the serialized object to. Must not be null. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | Optional [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') to control serialization behavior. If null, default options with indented formatting will be used. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when stream is null. |
| [System.Text.Json.JsonException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonException 'System.Text.Json.JsonException') | Thrown when the object cannot be serialized to JSON. |

##### Example

```C#
// Create an object to serialize
var product = new { Id = 123, Name = "Widget", Price = 19.99 };
// Serialize to a file stream
using (var fileStream = File.Create("product.json"))
{
    product.SerializeToStream(fileStream);
}
// Serialize with custom options
var options = new JsonSerializerOptions { WriteIndented = false };
using (var memoryStream = new MemoryStream())
{
    product.SerializeToStream(memoryStream, options);
    
    // Convert to string if needed
    memoryStream.Position = 0;
    using (var reader = new StreamReader(memoryStream))
    {
        string json = reader.ReadToEnd();
        Console.WriteLine(json); // Compact JSON without indentation
    }
}
```

##### Remarks

This method serializes an object to a stream in JSON format using System.Text.Json.
It uses a Utf8JsonWriter to write directly to the stream, which is more efficient than
serializing to a string first and then writing the string to a stream.

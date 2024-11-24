<a name='assembly'></a>
# Black.Beard.Helpers.ContentLoaders

## Contents

- [ContentHelper](#T-Bb-ContentHelper 'Bb.ContentHelper')
  - [ConvertFromBase64(self)](#M-Bb-ContentHelper-ConvertFromBase64-System-String- 'Bb.ContentHelper.ConvertFromBase64(System.String)')
  - [ConvertToBase64(self)](#M-Bb-ContentHelper-ConvertToBase64-System-String- 'Bb.ContentHelper.ConvertToBase64(System.String)')
  - [ConvertToString(self)](#M-Bb-ContentHelper-ConvertToString-System-IO-MemoryStream- 'Bb.ContentHelper.ConvertToString(System.IO.MemoryStream)')
  - [Deserialize(stream,targetType,options)](#M-Bb-ContentHelper-Deserialize-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize(System.IO.Stream,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize(self,sourceType,options)](#M-Bb-ContentHelper-Deserialize-System-String,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize(System.String,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [DeserializeConfiguration(payload,targetType,options)](#M-Bb-ContentHelper-DeserializeConfiguration-System-String,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.DeserializeConfiguration(System.String,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [DeserializeConfiguration\`\`1(payload,options)](#M-Bb-ContentHelper-DeserializeConfiguration``1-System-String,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.DeserializeConfiguration``1(System.String,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(stream,targetType,options)](#M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.IO.Stream,System.Type,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(stream,options)](#M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.IO.Stream,System.Text.Json.JsonSerializerOptions)')
  - [Deserialize\`\`1(self,options)](#M-Bb-ContentHelper-Deserialize``1-System-String,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Deserialize``1(System.String,System.Text.Json.JsonSerializerOptions)')
  - [Download(url,fileOutput,initializer)](#M-Bb-ContentHelper-Download-System-Uri,System-IO-FileInfo,System-Action{System-Net-Http-HttpClient}- 'Bb.ContentHelper.Download(System.Uri,System.IO.FileInfo,System.Action{System.Net.Http.HttpClient})')
  - [LoadContentFromText(text)](#M-Bb-ContentHelper-LoadContentFromText-System-Byte[]- 'Bb.ContentHelper.LoadContentFromText(System.Byte[])')
  - [RegisterEncoding()](#M-Bb-ContentHelper-RegisterEncoding 'Bb.ContentHelper.RegisterEncoding')
  - [Serialize(self,options)](#M-Bb-ContentHelper-Serialize-System-Object,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.Serialize(System.Object,System.Text.Json.JsonSerializerOptions)')
  - [Serialize(self,indented)](#M-Bb-ContentHelper-Serialize-System-Object,System-Boolean- 'Bb.ContentHelper.Serialize(System.Object,System.Boolean)')
  - [SerializeConfiguration\`\`1(self,options)](#M-Bb-ContentHelper-SerializeConfiguration``1-``0,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.SerializeConfiguration``1(``0,System.Text.Json.JsonSerializerOptions)')
  - [SerializeToMemory(self,options)](#M-Bb-ContentHelper-SerializeToMemory-System-Object,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.SerializeToMemory(System.Object,System.Text.Json.JsonSerializerOptions)')
  - [SerializeToStream(self,stream,options)](#M-Bb-ContentHelper-SerializeToStream-System-Object,System-IO-Stream,System-Text-Json-JsonSerializerOptions- 'Bb.ContentHelper.SerializeToStream(System.Object,System.IO.Stream,System.Text.Json.JsonSerializerOptions)')

<a name='T-Bb-ContentHelper'></a>
## ContentHelper `type`

##### Namespace

Bb

<a name='M-Bb-ContentHelper-ConvertFromBase64-System-String-'></a>
### ConvertFromBase64(self) `method`

##### Summary

decode the specified base 64 [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') encoded value.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-ContentHelper-ConvertToBase64-System-String-'></a>
### ConvertToBase64(self) `method`

##### Summary

encode the specified [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') in base 64 encoded value

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-ContentHelper-ConvertToString-System-IO-MemoryStream-'></a>
### ConvertToString(self) `method`

##### Summary

Read the [MemoryStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryStream 'System.IO.MemoryStream') and return the result in [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String')

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.MemoryStream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.MemoryStream 'System.IO.MemoryStream') |  |

<a name='M-Bb-ContentHelper-Deserialize-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize(stream,targetType,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | source stream |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | type to generate |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | As [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') provides options to be used with [JsonSerializer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializer 'System.Text.Json.JsonSerializer'). |

<a name='M-Bb-ContentHelper-Deserialize-System-String,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize(self,sourceType,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The payload. |
| sourceType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Target type. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

<a name='M-Bb-ContentHelper-DeserializeConfiguration-System-String,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
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

<a name='M-Bb-ContentHelper-DeserializeConfiguration``1-System-String,System-Text-Json-JsonSerializerOptions-'></a>
### DeserializeConfiguration\`\`1(payload,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| payload | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the instance to serialize. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TargetType | The type of the target type. |

<a name='M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Type,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(stream,targetType,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | source stream |
| targetType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | type to generate |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | As [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') provides options to be used with [JsonSerializer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializer 'System.Text.Json.JsonSerializer'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type to cast to return |

<a name='M-Bb-ContentHelper-Deserialize``1-System-IO-Stream,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(stream,options) `method`

##### Summary

Deserializes from the specified stream.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') | source stream |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | As [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') provides options to be used with [JsonSerializer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializer 'System.Text.Json.JsonSerializer'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | type to generate |

<a name='M-Bb-ContentHelper-Deserialize``1-System-String,System-Text-Json-JsonSerializerOptions-'></a>
### Deserialize\`\`1(self,options) `method`

##### Summary

Deserializes the specified self payload.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The payload. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | As [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') provides options to be used with [JsonSerializer](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializer 'System.Text.Json.JsonSerializer'). |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the target type. |

<a name='M-Bb-ContentHelper-Download-System-Uri,System-IO-FileInfo,System-Action{System-Net-Http-HttpClient}-'></a>
### Download(url,fileOutput,initializer) `method`

##### Summary

Downloads the specified file output.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') | The URL. |
| fileOutput | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file output. |
| initializer | [System.Action{System.Net.Http.HttpClient}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{System.Net.Http.HttpClient}') | The initializer. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.FileLoadException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileLoadException 'System.IO.FileLoadException') | local file already exists |
| [System.IO.FileNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileNotFoundException 'System.IO.FileNotFoundException') |  |

<a name='M-Bb-ContentHelper-LoadContentFromText-System-Byte[]-'></a>
### LoadContentFromText(text) `method`

##### Summary

Loads the content from text.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| text | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The text. |

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



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The self object to serialize. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |

<a name='M-Bb-ContentHelper-Serialize-System-Object,System-Boolean-'></a>
### Serialize(self,indented) `method`

##### Summary

Serializes with indentation the specified object.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') | The self object to serialize. |
| indented | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | if set to `true` [indented]. |

<a name='M-Bb-ContentHelper-SerializeConfiguration``1-``0,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeConfiguration\`\`1(self,options) `method`

##### Summary

Serializes the specified self instance.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [\`\`0](#T-``0 '``0') | the instance to serialize. |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') | [JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions')options of serialization |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| SourceType | The type of the target type. |

<a name='M-Bb-ContentHelper-SerializeToMemory-System-Object,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeToMemory(self,options) `method`

##### Summary

Serializes the specified self instance in a memory.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |  |

<a name='M-Bb-ContentHelper-SerializeToStream-System-Object,System-IO-Stream,System-Text-Json-JsonSerializerOptions-'></a>
### SerializeToStream(self,stream,options) `method`

##### Summary

Serializes the specified self instance in the stream.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Object](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Object 'System.Object') |  |
| stream | [System.IO.Stream](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Stream 'System.IO.Stream') |  |
| options | [System.Text.Json.JsonSerializerOptions](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Json.JsonSerializerOptions 'System.Text.Json.JsonSerializerOptions') |  |

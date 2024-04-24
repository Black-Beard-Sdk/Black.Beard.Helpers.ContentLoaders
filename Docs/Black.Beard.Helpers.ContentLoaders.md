<a name='assembly'></a>
# Black.Beard.Helpers.ContentLoaders

## Contents

- [ContentHelper](#T-Bb-ContentHelper 'Bb.ContentHelper')
  - [ConvertFromBase64(self)](#M-Bb-ContentHelper-ConvertFromBase64-System-String- 'Bb.ContentHelper.ConvertFromBase64(System.String)')
  - [ConvertToBase64(self)](#M-Bb-ContentHelper-ConvertToBase64-System-String- 'Bb.ContentHelper.ConvertToBase64(System.String)')
  - [ConvertToString(self)](#M-Bb-ContentHelper-ConvertToString-System-IO-MemoryStream- 'Bb.ContentHelper.ConvertToString(System.IO.MemoryStream)')
  - [Download(url,fileOutput,initializer)](#M-Bb-ContentHelper-Download-System-Uri,System-IO-FileInfo,System-Action{System-Net-Http-HttpClient}- 'Bb.ContentHelper.Download(System.Uri,System.IO.FileInfo,System.Action{System.Net.Http.HttpClient})')
  - [LoadContentFromText(text)](#M-Bb-ContentHelper-LoadContentFromText-System-Byte[]- 'Bb.ContentHelper.LoadContentFromText(System.Byte[])')
  - [RegisterEncoding()](#M-Bb-ContentHelper-RegisterEncoding 'Bb.ContentHelper.RegisterEncoding')
  - [Serialize(self,indented)](#M-Bb-ContentHelper-Serialize-System-Object,System-Boolean- 'Bb.ContentHelper.Serialize(System.Object,System.Boolean)')

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

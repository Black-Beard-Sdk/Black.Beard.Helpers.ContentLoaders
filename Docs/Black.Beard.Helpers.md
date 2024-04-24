<a name='assembly'></a>
# Black.Beard.Helpers

## Contents

- [Crc32](#T-Bb-Crc32 'Bb.Crc32')
  - [CalculateCrc32()](#M-Bb-Crc32-CalculateCrc32-System-Text-StringBuilder- 'Bb.Crc32.CalculateCrc32(System.Text.StringBuilder)')
  - [CalculateCrc32()](#M-Bb-Crc32-CalculateCrc32-System-String- 'Bb.Crc32.CalculateCrc32(System.String)')
- [DirectoryInfoExtension](#T-Bb-DirectoryInfoExtension 'Bb.DirectoryInfoExtension')
  - [AsDirectory(self)](#M-Bb-DirectoryInfoExtension-AsDirectory-System-String- 'Bb.DirectoryInfoExtension.AsDirectory(System.String)')
  - [AsFile(self)](#M-Bb-DirectoryInfoExtension-AsFile-System-String- 'Bb.DirectoryInfoExtension.AsFile(System.String)')
  - [AsFile(sourceFilePath,filename)](#M-Bb-DirectoryInfoExtension-AsFile-System-IO-DirectoryInfo,System-String- 'Bb.DirectoryInfoExtension.AsFile(System.IO.DirectoryInfo,System.String)')
  - [AsFile(sourceFilePath,filename)](#M-Bb-DirectoryInfoExtension-AsFile-System-String,System-String- 'Bb.DirectoryInfoExtension.AsFile(System.String,System.String)')
  - [Combine(self,segments)](#M-Bb-DirectoryInfoExtension-Combine-System-IO-DirectoryInfo,System-String[]- 'Bb.DirectoryInfoExtension.Combine(System.IO.DirectoryInfo,System.String[])')
  - [Combine(self,segments)](#M-Bb-DirectoryInfoExtension-Combine-System-String,System-String[]- 'Bb.DirectoryInfoExtension.Combine(System.String,System.String[])')
  - [Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.String,System.String,System.IO.DirectoryInfo,System.Boolean)')
  - [Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.IO.DirectoryInfo,System.String,System.IO.DirectoryInfo,System.Boolean)')
  - [Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.IO.DirectoryInfo,System.String,System.String,System.Boolean)')
  - [Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.String,System.String,System.String,System.Boolean)')
  - [CopyToDirectory(sourceFilePath,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.CopyToDirectory(System.IO.FileInfo,System.String,System.Boolean)')
  - [CopyToDirectory(sourceFilePath,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.CopyToDirectory(System.IO.FileInfo,System.IO.DirectoryInfo,System.Boolean)')
  - [CreateFolderIfNotExists(self)](#M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-String- 'Bb.DirectoryInfoExtension.CreateFolderIfNotExists(System.String)')
  - [CreateFolderIfNotExists(self)](#M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-IO-DirectoryInfo- 'Bb.DirectoryInfoExtension.CreateFolderIfNotExists(System.IO.DirectoryInfo)')
  - [DeleteFolderIfExists(self,recursive)](#M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-String,System-Boolean- 'Bb.DirectoryInfoExtension.DeleteFolderIfExists(System.String,System.Boolean)')
  - [DeleteFolderIfExists(self)](#M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.DeleteFolderIfExists(System.IO.DirectoryInfo,System.Boolean)')
- [HttpHelper](#T-Bb-HttpHelper 'Bb.HttpHelper')
  - [GetAvailablePort(startingPort)](#M-Bb-HttpHelper-GetAvailablePort-System-Int32- 'Bb.HttpHelper.GetAvailablePort(System.Int32)')
  - [GetLocalUri(securised,port)](#M-Bb-HttpHelper-GetLocalUri-System-Boolean,System-Int32- 'Bb.HttpHelper.GetLocalUri(System.Boolean,System.Int32)')
  - [GetUri(securised,host,port)](#M-Bb-HttpHelper-GetUri-System-Boolean,System-String,System-Int32- 'Bb.HttpHelper.GetUri(System.Boolean,System.String,System.Int32)')
- [UriExtensions](#T-Bb-UriExtensions 'Bb.UriExtensions')
  - [AddLocalhostSecureUrlWithDynamicPort(host,startingPort)](#M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@- 'Bb.UriExtensions.AddLocalhostSecureUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@)')
  - [AddLocalhostUrl(scheme,startPorts,count)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.Int32)')
  - [AddLocalhostUrl(scheme,port)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32)')
  - [AddLocalhostUrlWithDynamicPort(host,startingPort)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@)')
  - [AddLocalhostUrlWithDynamicPort(scheme,host,startingPort)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32@)')
  - [AddUrl(scheme,hostName,port)](#M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32- 'Bb.UriExtensions.AddUrl(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32)')
  - [Combine(parts)](#M-Bb-UriExtensions-Combine-System-String[]- 'Bb.UriExtensions.Combine(System.String[])')
  - [ConcatUrl(urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri}- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri})')
  - [ConcatUrl(sb,urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri},System-Text-StringBuilder- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri},System.Text.StringBuilder)')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-UriExtensions-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.UriExtensions.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [ToUri(url,segments)](#M-Bb-UriExtensions-ToUri-System-String,System-String[]- 'Bb.UriExtensions.ToUri(System.String,System.String[])')
  - [ToUri(scheme,host,port,segments)](#M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.ToUri(System.String,System.String,System.Int32,System.String[])')

<a name='T-Bb-Crc32'></a>
## Crc32 `type`

##### Namespace

Bb

##### Summary

Generate Crc32 checksums for strings and byte arrays.

##### Example

```csharp
    var crc = Crc32.CalculateCrc32("Hello World");
```

<a name='M-Bb-Crc32-CalculateCrc32-System-Text-StringBuilder-'></a>
### CalculateCrc32() `method`

##### Summary

Calculate the CRC (Cyclic Redundancy Check) for a range of bytes 
See RFC1952 for details.

CRCs can be computed in chunks, where you take the CRC of the preceding block of data and use
this as the 'crc32' to compute the next chunk.

##### Parameters

This method has no parameters.

<a name='M-Bb-Crc32-CalculateCrc32-System-String-'></a>
### CalculateCrc32() `method`

##### Summary

Calculate the CRC (Cyclic Redundancy Check) for a range of bytes 
See RFC1952 for details.

CRCs can be computed in chunks, where you take the CRC of the preceding block of data and use
this as the 'crc32' to compute the next chunk.

##### Parameters

This method has no parameters.

<a name='T-Bb-DirectoryInfoExtension'></a>
## DirectoryInfoExtension `type`

##### Namespace

Bb

<a name='M-Bb-DirectoryInfoExtension-AsDirectory-System-String-'></a>
### AsDirectory(self) `method`

##### Summary

Convert text to directory

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path directory name |

##### Example

```csharp
var directory = "c:\\temp\\".AsDirectory();
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String-'></a>
### AsFile(self) `method`

##### Summary

Convert text to file info

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path filename |

##### Example

```csharp
var file = "c:\\temp\\file.cs".AsFile();
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-IO-DirectoryInfo,System-String-'></a>
### AsFile(sourceFilePath,filename) `method`

##### Summary

Return a file from a directory and specified filename

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | file to copy in the target folder |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |

##### Example

```csharp
var file = "c:\\temp\\".AsDirectory().AsFile("filename.cs");
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String,System-String-'></a>
### AsFile(sourceFilePath,filename) `method`

##### Summary

Return a file from a directory and specified filename

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file to copy in the target folder |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |

##### Example

```csharp
var file = "c:\\temp\\".AsFile("filename.cs");
```

<a name='M-Bb-DirectoryInfoExtension-Combine-System-IO-DirectoryInfo,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Concatenate the directory with the segments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') |  |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
new DirectoryInfo("c:\\temp").Combine("subfolder1", "subfolder2", "subfolder3");
```

<a name='M-Bb-DirectoryInfoExtension-Combine-System-String,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Concatenate the directory path with the segments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | first segment |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
var path = "c:\\temp".Combine("subfolder1", "subfolder2", "subfolder3");
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".Copy("target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceDirectoryPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".AsDirectory().Copy("filename", "target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-String,System-Boolean-'></a>
### Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceDirectoryPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".AsDirectory().Copy("filename", "target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-String,System-Boolean-'></a>
### Copy(sourceDirectoryPath,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceDirectoryPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".Copy("filename", "target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-String,System-Boolean-'></a>
### CopyToDirectory(sourceFilePath,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-IO-DirectoryInfo,System-Boolean-'></a>
### CopyToDirectory(sourceFilePath,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sourceFilePath | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-String-'></a>
### CreateFolderIfNotExists(self) `method`

##### Summary

Create the directory if not exists

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

##### Example

```csharp
"c:\\temp\\".CreateFolderIfNotExists();
```

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-IO-DirectoryInfo-'></a>
### CreateFolderIfNotExists(self) `method`

##### Summary

Create the directory if not exists

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') |  |

##### Example

```csharp
"c:\\temp\\".AsDirectory().CreateFolderIfNotExists();
```

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-String,System-Boolean-'></a>
### DeleteFolderIfExists(self,recursive) `method`

##### Summary

Delete the directory if exists

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

##### Example

```csharp
"c:\\temp\\".DeleteFolderIfExists();
```

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-IO-DirectoryInfo,System-Boolean-'></a>
### DeleteFolderIfExists(self) `method`

##### Summary

Delete the directory if not exists

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') |  |

##### Example

```csharp
"c:\\temp\\".AsDirectory().DeleteFolderIfExists();
```

<a name='T-Bb-HttpHelper'></a>
## HttpHelper `type`

##### Namespace

Bb

##### Summary

get available port

<a name='M-Bb-HttpHelper-GetAvailablePort-System-Int32-'></a>
### GetAvailablePort(startingPort) `method`

##### Summary

Gets the first available port.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startingPort | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The starting port. |

##### Example

```csharp
int port = HttpHelper.GetAvailable(8080);
```

<a name='M-Bb-HttpHelper-GetLocalUri-System-Boolean,System-Int32-'></a>
### GetLocalUri(securised,port) `method`

##### Summary

Return a local uri with first available port from specified port.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| securised | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

##### Example

```csharp
Uri uri = HttpHelper.GetLocalUri(true, 8080);
```

<a name='M-Bb-HttpHelper-GetUri-System-Boolean,System-String,System-Int32-'></a>
### GetUri(securised,host,port) `method`

##### Summary

Return a uri with first available port from specified port.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| securised | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |

##### Example

```csharp
Uri uri = HttpHelper.GetLocalUri(true, "localhost", 8080);
```

<a name='T-Bb-UriExtensions'></a>
## UriExtensions `type`

##### Namespace

Bb

<a name='M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@-'></a>
### AddLocalhostSecureUrlWithDynamicPort(host,startingPort) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-Int32-'></a>
### AddLocalhostUrl(scheme,startPorts,count) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| startPorts | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The starting range port |
| count | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The count range port |

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32-'></a>
### AddLocalhostUrl(scheme,port) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@-'></a>
### AddLocalhostUrlWithDynamicPort(host,startingPort) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@-'></a>
### AddLocalhostUrlWithDynamicPort(scheme,host,startingPort) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |

<a name='M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32-'></a>
### AddUrl(scheme,hostName,port) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| hostName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name to listen |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen. |

<a name='M-Bb-UriExtensions-Combine-System-String[]-'></a>
### Combine(parts) `method`

##### Summary

Basically a Path.Combine for URLs. Ensures exactly one '/' separates each segment,
and exactly on '&' separates each query parameter.
URL-encodes illegal characters but not reserved characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parts | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | URL parts to combine. |

##### Example

```csharp
string  path = UriExtensions.Combine("segment1", , "segment2");
```

<a name='M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri}-'></a>
### ConcatUrl(urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urls | [System.Collections.Generic.IEnumerable{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Uri}') | [](#!-Url 'Url') |

##### Example

```csharp
var list = new List&lt;Uri&gt;();
list.Add(new Uri("http://localhost:8080"));
list.Add(new Uri("http1://localhost:8081"));
StringBuilder paths = list.ConcatUrl();
```

<a name='M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri},System-Text-StringBuilder-'></a>
### ConcatUrl(sb,urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sb | [System.Collections.Generic.IEnumerable{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Uri}') | [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') |
| urls | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | [](#!-Url 'Url') |

##### Example

```csharp
var list = new List&lt;Uri&gt;();
list.Add(new Uri("http://localhost:8080"));
list.Add(new Uri("http1://localhost:8081"));
list.ConcatUrl(new StringBuilder(200));
```

<a name='M-Bb-UriExtensions-EncodeIllegalCharacters-System-String,System-Boolean-'></a>
### EncodeIllegalCharacters(s,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes characters in a string that are neither reserved nor unreserved. Avoids encoding reserved characters such as '/' and '?'. Avoids encoding '%' if it begins a %-hex-hex sequence (i.e. avoids double-encoding).

##### Returns

The encoded URL.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20. |

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String[]-'></a>
### ToUri(url,segments) `method`

##### Summary

Create uri from string and segments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
Uri uri = @"http://localhost:80".ToUri("segment1");
```

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32,System-String[]-'></a>
### ToUri(scheme,host,port,segments) `method`

##### Summary

Create uri from string and segments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') |  |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
Uri uri = @"http".ToUri("localhost", 80, "segment1", , "segment2");
```

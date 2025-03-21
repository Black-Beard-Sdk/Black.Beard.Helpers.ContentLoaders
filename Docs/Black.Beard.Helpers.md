<a name='assembly'></a>
# Black.Beard.Helpers

## Contents

- [Crc32](#T-Bb-Crc32 'Bb.Crc32')
  - [CalculateCrc32()](#M-Bb-Crc32-CalculateCrc32-System-Text-StringBuilder- 'Bb.Crc32.CalculateCrc32(System.Text.StringBuilder)')
  - [CalculateCrc32()](#M-Bb-Crc32-CalculateCrc32-System-String- 'Bb.Crc32.CalculateCrc32(System.String)')
  - [CalculateCrc32()](#M-Bb-Crc32-CalculateCrc32-System-Byte[]- 'Bb.Crc32.CalculateCrc32(System.Byte[])')
- [DirectoryInfoExtension](#T-Bb-DirectoryInfoExtension 'Bb.DirectoryInfoExtension')
  - [AsDirectory(self,format)](#M-Bb-DirectoryInfoExtension-AsDirectory-System-String,System-Boolean- 'Bb.DirectoryInfoExtension.AsDirectory(System.String,System.Boolean)')
  - [AsFile(self,format)](#M-Bb-DirectoryInfoExtension-AsFile-System-String,System-Boolean- 'Bb.DirectoryInfoExtension.AsFile(System.String,System.Boolean)')
  - [AsFile(self,filename,format)](#M-Bb-DirectoryInfoExtension-AsFile-System-IO-DirectoryInfo,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.AsFile(System.IO.DirectoryInfo,System.String,System.Boolean)')
  - [AsFile(self,filename,format)](#M-Bb-DirectoryInfoExtension-AsFile-System-String,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.AsFile(System.String,System.String,System.Boolean)')
  - [Combine(self,segments)](#M-Bb-DirectoryInfoExtension-Combine-System-IO-DirectoryInfo,System-String[]- 'Bb.DirectoryInfoExtension.Combine(System.IO.DirectoryInfo,System.String[])')
  - [Combine(self,segments)](#M-Bb-DirectoryInfoExtension-Combine-System-String,System-String[]- 'Bb.DirectoryInfoExtension.Combine(System.String,System.String[])')
  - [Copy(self,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.String,System.String,System.IO.DirectoryInfo,System.Boolean)')
  - [Copy(self,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.IO.DirectoryInfo,System.String,System.IO.DirectoryInfo,System.Boolean)')
  - [Copy(self,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.IO.DirectoryInfo,System.String,System.String,System.Boolean)')
  - [Copy(self,filename,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.Copy(System.String,System.String,System.String,System.Boolean)')
  - [CopyToDirectory(self,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-String,System-Boolean- 'Bb.DirectoryInfoExtension.CopyToDirectory(System.IO.FileInfo,System.String,System.Boolean)')
  - [CopyToDirectory(self,directoryTargetPath,overwrite)](#M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.CopyToDirectory(System.IO.FileInfo,System.IO.DirectoryInfo,System.Boolean)')
  - [CreateFolderIfNotExists(self,format)](#M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-String,System-Boolean- 'Bb.DirectoryInfoExtension.CreateFolderIfNotExists(System.String,System.Boolean)')
  - [CreateFolderIfNotExists(self)](#M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-IO-DirectoryInfo- 'Bb.DirectoryInfoExtension.CreateFolderIfNotExists(System.IO.DirectoryInfo)')
  - [DeleteFolderIfExists(self,recursive)](#M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-String,System-Boolean- 'Bb.DirectoryInfoExtension.DeleteFolderIfExists(System.String,System.Boolean)')
  - [DeleteFolderIfExists(self,recursive)](#M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-IO-DirectoryInfo,System-Boolean- 'Bb.DirectoryInfoExtension.DeleteFolderIfExists(System.IO.DirectoryInfo,System.Boolean)')
  - [DirectoryPathIsAbsolute(path)](#M-Bb-DirectoryInfoExtension-DirectoryPathIsAbsolute-System-String- 'Bb.DirectoryInfoExtension.DirectoryPathIsAbsolute(System.String)')
  - [FilePathIsAbsolute(path)](#M-Bb-DirectoryInfoExtension-FilePathIsAbsolute-System-String- 'Bb.DirectoryInfoExtension.FilePathIsAbsolute(System.String)')
  - [FormatPath(self)](#M-Bb-DirectoryInfoExtension-FormatPath-System-String- 'Bb.DirectoryInfoExtension.FormatPath(System.String)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-DirectoryInfo,System-IO-DirectoryInfo- 'Bb.DirectoryInfoExtension.IsPathEquals(System.IO.DirectoryInfo,System.IO.DirectoryInfo)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-FileInfo,System-IO-FileInfo- 'Bb.DirectoryInfoExtension.IsPathEquals(System.IO.FileInfo,System.IO.FileInfo)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-String,System-String- 'Bb.DirectoryInfoExtension.IsPathEquals(System.String,System.String)')
- [HttpHelper](#T-Bb-HttpHelper 'Bb.HttpHelper')
  - [GetAvailablePort(startingPort)](#M-Bb-HttpHelper-GetAvailablePort-System-Int32- 'Bb.HttpHelper.GetAvailablePort(System.Int32)')
  - [GetLocalUri(securised,port)](#M-Bb-HttpHelper-GetLocalUri-System-Boolean,System-Int32- 'Bb.HttpHelper.GetLocalUri(System.Boolean,System.Int32)')
  - [GetUri(securised,host,port)](#M-Bb-HttpHelper-GetUri-System-Boolean,System-String,System-Int32- 'Bb.HttpHelper.GetUri(System.Boolean,System.String,System.Int32)')
- [PathComparer](#T-Bb-PathComparer 'Bb.PathComparer')
  - [Equals(x,y)](#M-Bb-PathComparer-Equals-System-String,System-String- 'Bb.PathComparer.Equals(System.String,System.String)')
  - [GetHashCode(obj)](#M-Bb-PathComparer-GetHashCode-System-String- 'Bb.PathComparer.GetHashCode(System.String)')
- [UriExtensions](#T-Bb-UriExtensions 'Bb.UriExtensions')
  - [AddLocalhostSecureUrlWithDynamicPort(host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostSecureUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.String[])')
  - [AddLocalhostSecureUrlWithDynamicPort(host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostSecureUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrl(scheme,startPorts,count)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.Int32)')
  - [AddLocalhostUrl(scheme,port,segments)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32,System.String[])')
  - [AddLocalhostUrl(scheme,startPorts,count)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.Int32)')
  - [AddLocalhostUrl(scheme,port,segments)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.ICollection{System.String},System.String,System.Int32,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(scheme,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(scheme,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.String,System.Int32@,System.String[])')
  - [AddUrl(scheme,hostName,port,segments)](#M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddUrl(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32,System.String[])')
  - [AddUrl(scheme,hostName,port,segments)](#M-Bb-UriExtensions-AddUrl-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddUrl(System.Collections.Generic.ICollection{System.String},System.String,System.String,System.Int32,System.String[])')
  - [Combine(parts)](#M-Bb-UriExtensions-Combine-System-String[]- 'Bb.UriExtensions.Combine(System.String[])')
  - [ConcatUrl(urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri}- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri})')
  - [ConcatUrl(sb,urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri},System-Text-StringBuilder- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri},System.Text.StringBuilder)')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-UriExtensions-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.UriExtensions.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [ToUri(url,segments)](#M-Bb-UriExtensions-ToUri-System-String,System-String[]- 'Bb.UriExtensions.ToUri(System.String,System.String[])')
  - [ToUri(scheme,host,port,segments)](#M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.ToUri(System.String,System.String,System.Int32,System.String[])')
  - [ToUri(scheme,host,port,segments)](#M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.ToUri(System.String,System.String,System.Int32@,System.String[])')

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

<a name='M-Bb-Crc32-CalculateCrc32-System-Byte[]-'></a>
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

<a name='M-Bb-DirectoryInfoExtension-AsDirectory-System-String,System-Boolean-'></a>
### AsDirectory(self,format) `method`

##### Summary

Convert text to directory

##### Returns

the [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path directory name |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | format the path |

##### Example

```csharp
var directory = "c:\\temp\\".AsDirectory();
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String,System-Boolean-'></a>
### AsFile(self,format) `method`

##### Summary

Convert text to file info

##### Returns

the [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | full path filename |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | format the path |

##### Example

```csharp
var file = "c:\\temp\\file.cs".AsFile();
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-IO-DirectoryInfo,System-String,System-Boolean-'></a>
### AsFile(self,filename,format) `method`

##### Summary

Return a file from a directory and specified filename

##### Returns

the [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | file to copy in the target folder |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | format the path |

##### Example

```csharp
var file = "c:\\temp\\".AsDirectory().AsFile("filename.cs");
```

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String,System-String,System-Boolean-'></a>
### AsFile(self,filename,format) `method`

##### Summary

Return a file from a directory and specified filename

##### Returns

the [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo')

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | file to copy in the target folder |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | format the path |

##### Example

```csharp
var file = "c:\\temp\\".AsFile("filename.cs");
```

<a name='M-Bb-DirectoryInfoExtension-Combine-System-IO-DirectoryInfo,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Concatenate the directory with the segments

##### Returns

the concatenated path

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | root directory path |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | segments to add |

##### Example

```csharp
new DirectoryInfo("c:\\temp").Combine("subfolder1", "subfolder2", "subfolder3");
```

<a name='M-Bb-DirectoryInfoExtension-Combine-System-String,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Concatenate the directory path with the segments

##### Returns

the concatenated path

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | first segment |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | segments to add |

##### Example

```csharp
var path = "c:\\temp".Combine("subfolder1", "subfolder2", "subfolder3");
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".Copy("target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".AsDirectory().Copy("filename", "target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-String,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".AsDirectory().Copy("filename", "target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-String,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | source directory where found the file |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | filename to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp".Copy("filename", "target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-String,System-Boolean-'></a>
### CopyToDirectory(self,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file to copy in the target folder |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path", true);
```

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-IO-DirectoryInfo,System-Boolean-'></a>
### CopyToDirectory(self,directoryTargetPath,overwrite) `method`

##### Summary

Copy the specified file to a directory

##### Returns

return true if the copy is successfully

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file to copy in the target folder |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | target directory to copy source file |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | override file if already exists |

##### Example

```csharp
"c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path".AsDirectory(), true);
```

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-String,System-Boolean-'></a>
### CreateFolderIfNotExists(self,format) `method`

##### Summary

Create the directory if not exists

##### Returns

source folder to create

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | folder path |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | format the path |

##### Example

```csharp
"c:\\temp\\".CreateFolderIfNotExists();
```

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-IO-DirectoryInfo-'></a>
### CreateFolderIfNotExists(self) `method`

##### Summary

Create the directory if not exists

##### Returns

source folder to create

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | folder path |

##### Example

```csharp
"c:\\temp\\".AsDirectory().CreateFolderIfNotExists();
```

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-String,System-Boolean-'></a>
### DeleteFolderIfExists(self,recursive) `method`

##### Summary

Delete the directory if exists

##### Returns

source folder to delete

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | folder path |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | delete all children |

##### Example

```csharp
"c:\\temp\\".DeleteFolderIfExists();
```

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-IO-DirectoryInfo,System-Boolean-'></a>
### DeleteFolderIfExists(self,recursive) `method`

##### Summary

Delete the directory if not exists

##### Returns

source folder to delete

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | folder path |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | delete all children |

##### Example

```csharp
"c:\\temp\\".AsDirectory().DeleteFolderIfExists();
```

<a name='M-Bb-DirectoryInfoExtension-DirectoryPathIsAbsolute-System-String-'></a>
### DirectoryPathIsAbsolute(path) `method`

##### Summary

return true if the directory path is absolute

##### Returns

true if the path is absolute form

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | path to evaluate |

##### Example

```csharp
    if("directory".DirectoryPathIsAbsolute())
    {
    }
```

<a name='M-Bb-DirectoryInfoExtension-FilePathIsAbsolute-System-String-'></a>
### FilePathIsAbsolute(path) `method`

##### Summary

return true if the file path is absolute

##### Returns

true if the path is absolute form

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | path to evaluate |

##### Example

```csharp
    if("file".FilePathIsAbsolute())
    {
    }
```

<a name='M-Bb-DirectoryInfoExtension-FormatPath-System-String-'></a>
### FormatPath(self) `method`

##### Summary

Formats the specified path to a standard format.

##### Returns

The formatted path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path to format. |

##### Example

```C#
string path = "file:///C:/Path1";
string formattedPath = path.FormatPath();
```

##### Remarks

This method converts the path to a lower-case invariant string and removes URI encoding.

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-DirectoryInfo,System-IO-DirectoryInfo-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Determines whether the specified directory paths are equal.

##### Returns

`true` if the specified paths are equal; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The first directory path. |
| path2 | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The second directory path. |

##### Example

```C#
var dir1 = new DirectoryInfo("C:\\Path1");
var dir2 = new DirectoryInfo("C:\\path1");
bool areEqual = dir1.IsPathEquals(dir2);
```

##### Remarks

This method compares the full names of the directories in a case-insensitive manner.

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-FileInfo,System-IO-FileInfo-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Determines whether the specified file paths are equal.

##### Returns

`true` if the specified paths are equal; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The first file path. |
| path2 | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The second file path. |

##### Example

```C#
var file1 = new FileInfo("C:\\Path1\\file.txt");
var file2 = new FileInfo("C:\\path1\\FILE.TXT");
bool areEqual = file1.IsPathEquals(file2);
```

##### Remarks

This method compares the full names of the files in a case-insensitive manner.

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-String,System-String-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Determines whether the specified string paths are equal.

##### Returns

`true` if the specified paths are equal; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The first string path. |
| path2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The second string path. |

##### Example

```C#
string path1 = "C:\\Path1";
string path2 = "C:\\path1";
bool areEqual = path1.IsPathEquals(path2);
```

##### Remarks

This method compares the formatted paths in a case-insensitive manner.

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

<a name='T-Bb-PathComparer'></a>
## PathComparer `type`

##### Namespace

Bb

##### Summary

Compares file and directory paths for equality.

<a name='M-Bb-PathComparer-Equals-System-String,System-String-'></a>
### Equals(x,y) `method`

##### Summary

Determines whether the specified paths are equal.

##### Returns

`true` if the specified paths are equal; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| x | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The first path. |
| y | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The second path. |

##### Remarks

This method compares the full paths in a case-insensitive manner.

<a name='M-Bb-PathComparer-GetHashCode-System-String-'></a>
### GetHashCode(obj) `method`

##### Summary

Returns a hash code for the specified path.

##### Returns

A hash code for the specified path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| obj | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null. |

##### Remarks

This method returns a hash code for the full path in a case-insensitive manner.

<a name='T-Bb-UriExtensions'></a>
## UriExtensions `type`

##### Namespace

Bb

<a name='M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostSecureUrlWithDynamicPort(host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostSecureUrlWithDynamicPort(host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

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

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32,System-String[]-'></a>
### AddLocalhostUrl(scheme,port,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen |
| segments | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-Int32-'></a>
### AddLocalhostUrl(scheme,startPorts,count) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The scheme protocol. |
| startPorts | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The starting range port |
| count | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The count range port |

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32,System-String[]-'></a>
### AddLocalhostUrl(scheme,port,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The scheme protocol. |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen |
| segments | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(scheme,host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| host | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(scheme,host,startingPort,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The scheme protocol. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. if null localhost is used by default |
| startingPort | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | starting port to search. |
| segments | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32,System-String[]-'></a>
### AddUrl(scheme,hostName,port,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The scheme protocol. |
| hostName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name to listen |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen. |
| segments | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The segments to add to the url |

<a name='M-Bb-UriExtensions-AddUrl-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32,System-String[]-'></a>
### AddUrl(scheme,hostName,port,segments) `method`

##### Summary

Adds an [](#!-Url 'Url') on the list of listeners.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The scheme protocol. |
| hostName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name to listen |
| port | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The port to listen. |
| segments | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The segments to add to the url |

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

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32@,System-String[]-'></a>
### ToUri(scheme,host,port,segments) `method`

##### Summary

Create uri from string and segments

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | the first port available |
| port | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') |  |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

##### Example

```csharp
int port = 80;
Uri uri = @"http".ToUri("localhost", ref int port, "segment1", , "segment2");
```

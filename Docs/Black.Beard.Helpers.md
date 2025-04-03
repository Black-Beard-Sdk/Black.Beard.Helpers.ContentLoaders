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
  - [GetDirectory(self)](#M-Bb-DirectoryInfoExtension-GetDirectory-System-Reflection-Assembly- 'Bb.DirectoryInfoExtension.GetDirectory(System.Reflection.Assembly)')
  - [GetTempPath(context)](#M-Bb-DirectoryInfoExtension-GetTempPath-System-String- 'Bb.DirectoryInfoExtension.GetTempPath(System.String)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-DirectoryInfo,System-IO-DirectoryInfo- 'Bb.DirectoryInfoExtension.IsPathEquals(System.IO.DirectoryInfo,System.IO.DirectoryInfo)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-FileInfo,System-IO-FileInfo- 'Bb.DirectoryInfoExtension.IsPathEquals(System.IO.FileInfo,System.IO.FileInfo)')
  - [IsPathEquals(path1,path2)](#M-Bb-DirectoryInfoExtension-IsPathEquals-System-String,System-String- 'Bb.DirectoryInfoExtension.IsPathEquals(System.String,System.String)')
  - [WriteFile(self,filename,content,encoding)](#M-Bb-DirectoryInfoExtension-WriteFile-System-IO-DirectoryInfo,System-String,System-String,System-Text-Encoding- 'Bb.DirectoryInfoExtension.WriteFile(System.IO.DirectoryInfo,System.String,System.String,System.Text.Encoding)')
- [FileInfoExtension](#T-Bb-FileInfoExtension 'Bb.FileInfoExtension')
  - [WriteFile(self,content,encoding)](#M-Bb-FileInfoExtension-WriteFile-System-IO-FileInfo,System-String,System-Text-Encoding- 'Bb.FileInfoExtension.WriteFile(System.IO.FileInfo,System.String,System.Text.Encoding)')
- [HttpHelper](#T-Bb-HttpHelper 'Bb.HttpHelper')
  - [GetAvailablePort(startingPort)](#M-Bb-HttpHelper-GetAvailablePort-System-Int32- 'Bb.HttpHelper.GetAvailablePort(System.Int32)')
  - [GetLocalUri(securised,port)](#M-Bb-HttpHelper-GetLocalUri-System-Boolean,System-Int32- 'Bb.HttpHelper.GetLocalUri(System.Boolean,System.Int32)')
  - [GetUri(securised,host,port)](#M-Bb-HttpHelper-GetUri-System-Boolean,System-String,System-Int32- 'Bb.HttpHelper.GetUri(System.Boolean,System.String,System.Int32)')
- [PathComparer](#T-Bb-PathComparer 'Bb.PathComparer')
  - [Equals(x,y)](#M-Bb-PathComparer-Equals-System-String,System-String- 'Bb.PathComparer.Equals(System.String,System.String)')
  - [GetHashCode(obj)](#M-Bb-PathComparer-GetHashCode-System-String- 'Bb.PathComparer.GetHashCode(System.String)')
- [StaticContainer](#T-Bb-StaticContainer 'Bb.StaticContainer')
  - [Set\`\`1(self)](#M-Bb-StaticContainer-Set``1-``0- 'Bb.StaticContainer.Set``1(``0)')
- [StaticThreadContainer](#T-Bb-StaticThreadContainer 'Bb.StaticThreadContainer')
  - [Set\`\`1(self)](#M-Bb-StaticThreadContainer-Set``1-``0- 'Bb.StaticThreadContainer.Set``1(``0)')
- [UriExtensions](#T-Bb-UriExtensions 'Bb.UriExtensions')
  - [AddLocalhostSecureUrlWithDynamicPort(self,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostSecureUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.String[])')
  - [AddLocalhostSecureUrlWithDynamicPort(self,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostSecureUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrl(self,scheme,startPorts,count)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.Int32)')
  - [AddLocalhostUrl(self,scheme,port,segments)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.List{System.Uri},System.String,System.Int32,System.String[])')
  - [AddLocalhostUrl(self,scheme,startPorts,count)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-Int32- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.Int32)')
  - [AddLocalhostUrl(self,scheme,port,segments)](#M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddLocalhostUrl(System.Collections.Generic.ICollection{System.String},System.String,System.Int32,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(self,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(self,scheme,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(self,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.Int32@,System.String[])')
  - [AddLocalhostUrlWithDynamicPort(self,scheme,host,startingPort,segments)](#M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32@,System-String[]- 'Bb.UriExtensions.AddLocalhostUrlWithDynamicPort(System.Collections.Generic.ICollection{System.String},System.String,System.String,System.Int32@,System.String[])')
  - [AddUrl(self,scheme,hostName,port,segments)](#M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddUrl(System.Collections.Generic.List{System.Uri},System.String,System.String,System.Int32,System.String[])')
  - [AddUrl(self,scheme,hostName,port,segments)](#M-Bb-UriExtensions-AddUrl-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32,System-String[]- 'Bb.UriExtensions.AddUrl(System.Collections.Generic.ICollection{System.String},System.String,System.String,System.Int32,System.String[])')
  - [Combine(parts)](#M-Bb-UriExtensions-Combine-System-String[]- 'Bb.UriExtensions.Combine(System.String[])')
  - [ConcatUrl(urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri}- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri})')
  - [ConcatUrl(sb,urls)](#M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri},System-Text-StringBuilder- 'Bb.UriExtensions.ConcatUrl(System.Collections.Generic.IEnumerable{System.Uri},System.Text.StringBuilder)')
  - [EncodeIllegalCharacters(s,encodeSpaceAsPlus)](#M-Bb-UriExtensions-EncodeIllegalCharacters-System-String,System-Boolean- 'Bb.UriExtensions.EncodeIllegalCharacters(System.String,System.Boolean)')
  - [OrdinalContains(s,value,ignoreCase)](#M-Bb-UriExtensions-OrdinalContains-System-String,System-String,System-Boolean- 'Bb.UriExtensions.OrdinalContains(System.String,System.String,System.Boolean)')
  - [OrdinalEndsWith(s,value,ignoreCase)](#M-Bb-UriExtensions-OrdinalEndsWith-System-String,System-String,System-Boolean- 'Bb.UriExtensions.OrdinalEndsWith(System.String,System.String,System.Boolean)')
  - [OrdinalStartsWith(s,value,ignoreCase)](#M-Bb-UriExtensions-OrdinalStartsWith-System-String,System-String,System-Boolean- 'Bb.UriExtensions.OrdinalStartsWith(System.String,System.String,System.Boolean)')
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

Converts a string path to a DirectoryInfo object.

##### Returns

A [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') object representing the directory path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path to convert. Must not be null or empty. |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, formats the path before creating the DirectoryInfo object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null or empty. |

##### Example

```C#
// Convert string path to DirectoryInfo
string path = @"C:\temp";
DirectoryInfo dirInfo = path.AsDirectory();
// Without formatting
DirectoryInfo dirInfo2 = path.AsDirectory(format: false);
```

##### Remarks

This method creates a DirectoryInfo object from a string path. If format is true, 
the path is normalized using FormatPath before creating the DirectoryInfo.

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String,System-Boolean-'></a>
### AsFile(self,format) `method`

##### Summary

Converts a string path to a FileInfo object.

##### Returns

A [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') object representing the file path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file path to convert. Must not be null or empty. |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, formats the path before creating the FileInfo object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null or empty. |

##### Example

```C#
// Convert string path to FileInfo
string path = @"C:\temp\file.txt";
FileInfo fileInfo = path.AsFile();
// Without formatting
FileInfo fileInfo2 = path.AsFile(format: false);
```

##### Remarks

This method creates a FileInfo object from a string path. If format is true, 
the path is normalized using FormatPath before creating the FileInfo.

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-IO-DirectoryInfo,System-String,System-Boolean-'></a>
### AsFile(self,filename,format) `method`

##### Summary

Creates a FileInfo object for a file in the specified directory.

##### Returns

A [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') object representing the file in the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The directory containing the file. Must not be null. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file. |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, formats the combined path before creating the FileInfo object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory is null or the filename is null or empty. |

##### Example

```C#
// Get FileInfo for a file in a directory
var directory = new DirectoryInfo(@"C:\temp");
FileInfo fileInfo = directory.AsFile("example.txt");
```

##### Remarks

This method combines the directory path with the filename, then creates a FileInfo object 
from the combined path. If format is true, the path is normalized using FormatPath.

<a name='M-Bb-DirectoryInfoExtension-AsFile-System-String,System-String,System-Boolean-'></a>
### AsFile(self,filename,format) `method`

##### Summary

Creates a FileInfo object for a file in the specified directory path.

##### Returns

A [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') object representing the file in the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path containing the file. Must not be null or empty. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file. |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, formats the combined path before creating the FileInfo object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory path is null or empty, or when the filename is null or empty. |

##### Example

```C#
// Get FileInfo for a file in a directory
string dirPath = @"C:\temp";
FileInfo fileInfo = dirPath.AsFile("example.txt");
```

##### Remarks

This method combines the directory path with the filename, then creates a FileInfo object 
from the combined path. If format is true, the path is normalized using FormatPath.

<a name='M-Bb-DirectoryInfoExtension-Combine-System-IO-DirectoryInfo,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Combines a DirectoryInfo path with additional path segments.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the combined path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The base directory. Must not be null. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The additional path segments to combine with the base directory. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory (self) is null. |

##### Example

```C#
// Combine directory with path segments
var directory = new DirectoryInfo(@"C:\temp");
string path = directory.Combine("subfolder", "file.txt"); // Returns "C:\temp\subfolder\file.txt"
```

##### Remarks

This method creates a combined path by using the FullName of the DirectoryInfo and appending
the provided path segments using Path.Combine.

<a name='M-Bb-DirectoryInfoExtension-Combine-System-String,System-String[]-'></a>
### Combine(self,segments) `method`

##### Summary

Combines a string path with additional path segments.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the combined path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base path. Must not be null or empty. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The additional path segments to combine with the base path. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the base path is null or empty. |

##### Example

```C#
// Combine path with additional segments
string basePath = @"C:\temp";
string path = basePath.Combine("subfolder", "file.txt"); // Returns "C:\temp\subfolder\file.txt"
```

##### Remarks

This method creates a combined path by appending the provided path segments to the base path
using Path.Combine.

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file from the source directory to a target directory.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The source directory path. Must not be null or empty. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file to copy. Must not be null or empty. |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The target directory where the file will be copied. Must not be null. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the source directory path or filename is null or empty, or the target directory is null. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file from a source directory to a target directory
string sourceDir = @"C:\source";
var targetDir = new DirectoryInfo(@"C:\target");
bool success = sourceDir.Copy("document.txt", targetDir);
// Overwrite existing file
bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
```

##### Remarks

This method copies a file specified by filename from the source directory to the target directory.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-IO-DirectoryInfo,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file from the source directory to a target directory.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The source directory. Must not be null. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file to copy. Must not be null or empty. |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The target directory where the file will be copied. Must not be null. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the source directory, filename, or target directory is null. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file from a source directory to a target directory
var sourceDir = new DirectoryInfo(@"C:\source");
var targetDir = new DirectoryInfo(@"C:\target");
bool success = sourceDir.Copy("document.txt", targetDir);
// Overwrite existing file
bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
```

##### Remarks

This method copies a file specified by filename from the source directory to the target directory.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-Copy-System-IO-DirectoryInfo,System-String,System-String,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file from the source directory to a target directory path.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The source directory. Must not be null. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file to copy. Must not be null or empty. |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The target directory path where the file will be copied. Must not be null or empty. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the source directory is null, or filename or target directory path is null or empty. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file from a source directory to a target directory path
var sourceDir = new DirectoryInfo(@"C:\source");
bool success = sourceDir.Copy("document.txt", @"C:\target");
// Overwrite existing file
bool success2 = sourceDir.Copy("document.txt", @"C:\target", overwrite: true);
```

##### Remarks

This method copies a file specified by filename from the source directory to the target directory path.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-Copy-System-String,System-String,System-String,System-Boolean-'></a>
### Copy(self,filename,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file from a source directory path to a target directory path.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The source directory path. Must not be null or empty. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file to copy. Must not be null or empty. |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The target directory path where the file will be copied. Must not be null or empty. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when any of the parameters (self, filename, directoryTargetPath) is null or empty. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file from a source directory path to a target directory path
string sourceDir = @"C:\source";
string targetDir = @"C:\target";
bool success = sourceDir.Copy("document.txt", targetDir);
// Overwrite existing file
bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
```

##### Remarks

This method copies a file specified by filename from the source directory path to the target directory path.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-String,System-Boolean-'></a>
### CopyToDirectory(self,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file to the specified target directory.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file to copy. Must not be null. |
| directoryTargetPath | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The target directory path where the file will be copied. Must not be null or empty. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the file (self) is null or the target directory path is null or empty. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file to a target directory
var file = new FileInfo(@"C:\source\document.txt");
bool success = file.CopyToDirectory(@"C:\target");
// Overwrite existing file
bool success2 = file.CopyToDirectory(@"C:\target", overwrite: true);
```

##### Remarks

This method copies a file to the specified target directory while preserving the original filename.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-CopyToDirectory-System-IO-FileInfo,System-IO-DirectoryInfo,System-Boolean-'></a>
### CopyToDirectory(self,directoryTargetPath,overwrite) `method`

##### Summary

Copies a file to the specified target directory.

##### Returns

`true` if the file was successfully copied; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The file to copy. Must not be null. |
| directoryTargetPath | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The target directory where the file will be copied. Must not be null. |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, overwrites the destination file if it exists. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the file (self) is null or the target directory is null. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller does not have the required permission. |

##### Example

```C#
// Copy a file to a target directory
var file = new FileInfo(@"C:\source\document.txt");
var targetDir = new DirectoryInfo(@"C:\target");
bool success = file.CopyToDirectory(targetDir);
// Overwrite existing file
bool success2 = file.CopyToDirectory(targetDir, overwrite: true);
```

##### Remarks

This method copies a file to the specified target directory while preserving the original filename.
It returns false if the source file doesn't exist. After copying, it refreshes the target file
information to ensure it reflects the current state of the file system.

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-String,System-Boolean-'></a>
### CreateFolderIfNotExists(self,format) `method`

##### Summary

Creates a directory from a string path if it doesn't exist.

##### Returns

A [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') object representing the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path to check and create. Must not be null or empty. |
| format | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, formats the path before creating the DirectoryInfo object. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null or empty. |

##### Example

```C#
// Create a directory if it doesn't exist from a string path
string path = @"C:\temp\newFolder";
DirectoryInfo directory = path.CreateFolderIfNotExists();
// Without formatting
DirectoryInfo directory2 = path.CreateFolderIfNotExists(format: false);
```

##### Remarks

This method converts the string path to a DirectoryInfo object and then creates
the directory if it doesn't exist. The format parameter determines whether to normalize
the path using FormatPath before creating the DirectoryInfo.

<a name='M-Bb-DirectoryInfoExtension-CreateFolderIfNotExists-System-IO-DirectoryInfo-'></a>
### CreateFolderIfNotExists(self) `method`

##### Summary

Creates the directory if it doesn't exist.

##### Returns

The [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The directory to check and create. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory (self) is null. |

##### Example

```C#
// Create a directory if it doesn't exist
var directory = new DirectoryInfo(@"C:\temp\newFolder");
directory.CreateFolderIfNotExists();
// Method chaining example
var dir = new DirectoryInfo(@"C:\temp\project")
    .CreateFolderIfNotExists()
    .WriteFile("example.txt", "Hello World!");
```

##### Remarks

This method checks if the specified directory exists and creates it if it doesn't.
It calls Refresh() to ensure the DirectoryInfo reflects the current state of the directory
before checking existence and after creating the directory.

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-String,System-Boolean-'></a>
### DeleteFolderIfExists(self,recursive) `method`

##### Summary

Deletes a directory if it exists.

##### Returns

A [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') object representing the directory.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path to check and delete. Must not be null or empty. |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, removes all files and subdirectories recursively; otherwise, the directory must be empty to be removed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null or empty. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when the directory is not empty and recursive is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the user does not have the required permission. |

##### Example

```C#
// Delete a directory if it exists
string path = @"C:\temp\oldFolder";
DirectoryInfo directory = path.DeleteFolderIfExists();
// Delete recursively
string path2 = @"C:\temp\oldFolderWithContents";
DirectoryInfo directory2 = path2.DeleteFolderIfExists(recursive: true);
```

##### Remarks

This method converts the string path to a DirectoryInfo object and then deletes
the directory if it exists. The recursive parameter determines whether to delete
all contents recursively or require an empty directory.

<a name='M-Bb-DirectoryInfoExtension-DeleteFolderIfExists-System-IO-DirectoryInfo,System-Boolean-'></a>
### DeleteFolderIfExists(self,recursive) `method`

##### Summary

Deletes a directory if it exists.

##### Returns

The [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The directory to check and delete. Must not be null. |
| recursive | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, removes all files and subdirectories recursively; otherwise, the directory must be empty to be removed. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory (self) is null. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when the directory is not empty and recursive is false. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the user does not have the required permission. |

##### Example

```C#
// Delete a directory if it exists
var directory = new DirectoryInfo(@"C:\temp\oldFolder");
directory.DeleteFolderIfExists();
// Delete recursively
var directory2 = new DirectoryInfo(@"C:\temp\oldFolderWithContents");
directory2.DeleteFolderIfExists(recursive: true);
```

##### Remarks

This method checks if the specified directory exists and deletes it if it does.
It calls Refresh() to ensure the DirectoryInfo reflects the current state of the directory
before checking existence and after deleting the directory.
The recursive parameter determines whether to delete all contents recursively or require an empty directory.

<a name='M-Bb-DirectoryInfoExtension-DirectoryPathIsAbsolute-System-String-'></a>
### DirectoryPathIsAbsolute(path) `method`

##### Summary

Determines if a directory path is absolute.

##### Returns

`true` if the path is absolute; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The directory path to check. Can be null or empty. |

##### Example

```C#
// Check if a path is absolute
string path1 = @"C:\temp\";
bool isAbsolute1 = path1.DirectoryPathIsAbsolute(); // Returns true
string path2 = "temp";
bool isAbsolute2 = path2.DirectoryPathIsAbsolute(); // Returns false
```

##### Remarks

This method checks if the given path is an absolute directory path by creating a DirectoryInfo object
and comparing the original path with the FullName property.

<a name='M-Bb-DirectoryInfoExtension-FilePathIsAbsolute-System-String-'></a>
### FilePathIsAbsolute(path) `method`

##### Summary

Determines if a file path is absolute.

##### Returns

`true` if the path is absolute; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The file path to check. Can be null or empty. |

##### Example

```C#
// Check if a path is absolute
string path1 = @"C:\temp\file.txt";
bool isAbsolute1 = path1.FilePathIsAbsolute(); // Returns true
string path2 = "file.txt";
bool isAbsolute2 = path2.FilePathIsAbsolute(); // Returns false
```

##### Remarks

This method checks if the given path is an absolute file path by creating a FileInfo object
and comparing the original path with the FullName property.

<a name='M-Bb-DirectoryInfoExtension-FormatPath-System-String-'></a>
### FormatPath(self) `method`

##### Summary

Formats a file or directory path to a standard format.

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') containing the formatted path.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The path to format. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the path is null or empty. |

##### Example

```C#
// Format various paths
string path1 = "file:///C:/temp/my%20folder/";
string formatted1 = path1.FormatPath(); // Returns "c:\temp\my folder" on Windows
string path2 = @".\relative\path";
string formatted2 = path2.FormatPath(); // Returns full path with relative portion resolved
string path3 = @"C:\TEMP\";
string formatted3 = path3.FormatPath(); // Returns "c:\temp" on Windows (lowercase, no trailing separator)
```

##### Remarks

This method standardizes paths by:
1. Converting URI file paths to local file system paths
2. Unescaping URI-encoded characters
3. Converting to absolute path format
4. Trimming trailing directory separators
5. Converting to lowercase on Windows platforms for case-insensitive comparison

<a name='M-Bb-DirectoryInfoExtension-GetDirectory-System-Reflection-Assembly-'></a>
### GetDirectory(self) `method`

##### Summary

get the directory of the assembly

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Reflection.Assembly](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Reflection.Assembly 'System.Reflection.Assembly') |  |

<a name='M-Bb-DirectoryInfoExtension-GetTempPath-System-String-'></a>
### GetTempPath(context) `method`

##### Summary

return a temporary path for a context.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| context | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-DirectoryInfo,System-IO-DirectoryInfo-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Compares two DirectoryInfo objects to check if they represent the same path.

##### Returns

`true` if the paths are equal according to the path comparer; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The first DirectoryInfo to compare. Must not be null. |
| path2 | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The second DirectoryInfo to compare. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when either path1 or path2 is null. |

##### Example

```C#
// Compare two directory paths
var dir1 = new DirectoryInfo(@"C:\temp");
var dir2 = new DirectoryInfo(@"C:\Temp");
bool areEqual = dir1.IsPathEquals(dir2); // On Windows, returns true due to case insensitivity
```

##### Remarks

This method compares the full paths of the two DirectoryInfo objects using a path comparer
that is platform-aware and handles case sensitivity according to the current operating system.
On Windows, the comparison is case-insensitive, while on Unix-based systems it is case-sensitive.

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-IO-FileInfo,System-IO-FileInfo-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Compares two FileInfo objects to check if they represent the same path.

##### Returns

`true` if the paths are equal according to the path comparer; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The first FileInfo to compare. Must not be null. |
| path2 | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | The second FileInfo to compare. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when either path1 or path2 is null. |

##### Example

```C#
// Compare two file paths
var file1 = new FileInfo(@"C:\temp\file.txt");
var file2 = new FileInfo(@"C:\Temp\File.txt");
bool areEqual = file1.IsPathEquals(file2); // On Windows, returns true due to case insensitivity
```

##### Remarks

This method compares the full paths of the two FileInfo objects using a path comparer
that is platform-aware and handles case sensitivity according to the current operating system.
On Windows, the comparison is case-insensitive, while on Unix-based systems it is case-sensitive.

<a name='M-Bb-DirectoryInfoExtension-IsPathEquals-System-String,System-String-'></a>
### IsPathEquals(path1,path2) `method`

##### Summary

Compares two string paths to check if they represent the same path.

##### Returns

`true` if the paths are equal after normalization; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| path1 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The first path to compare. Must not be null or empty. |
| path2 | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The second path to compare. Must not be null or empty. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when either path1 or path2 is null or empty. |

##### Example

```C#
// Compare two string paths
string path1 = @"C:\temp\file.txt";
string path2 = @"C:\Temp\File.txt";
bool areEqual = path1.IsPathEquals(path2); // On Windows, returns true due to case insensitivity
// Compare with relative path
string path3 = @".\temp\file.txt";
bool areEqual2 = path1.IsPathEquals(path3); // Returns true if paths resolve to same location
```

##### Remarks

This method first normalizes both paths using FormatPath, then compares them using a path comparer
that is platform-aware and handles case sensitivity appropriately. The normalization process
resolves relative paths, removes trailing separators, and adjusts case according to the platform.

<a name='M-Bb-DirectoryInfoExtension-WriteFile-System-IO-DirectoryInfo,System-String,System-String,System-Text-Encoding-'></a>
### WriteFile(self,filename,content,encoding) `method`

##### Summary

Writes content to a file in the specified directory.

##### Returns

The [DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') | The directory where the file will be created or updated. |
| filename | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The name of the file to write to. Must not be null or empty. |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The content to write to the file. |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding to use when writing the file. If null, defaults to UTF-8. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the directory (self) or filename is null. |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | Thrown when an I/O error occurs while writing to the file. |
| [System.UnauthorizedAccessException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UnauthorizedAccessException 'System.UnauthorizedAccessException') | Thrown when the caller doesn't have the required permission. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Thrown when the specified directory path is invalid. |

##### Example

```C#
// Write content to a file in a directory
var directory = new DirectoryInfo(@"C:\temp");
directory.WriteFile("example.txt", "Hello World!");
// With specific encoding
directory.WriteFile("example2.txt", "Hello World!", Encoding.ASCII);
// With method chaining
directory.WriteFile("example3.txt", "Hello World!").CreateFolderIfNotExists();
```

##### Remarks

This method creates or updates a file with the specified filename within the directory.
The file will be created if it doesn't exist, or overwritten if it already exists.
The content is written to the file using the specified encoding or UTF-8 if no encoding is provided.

<a name='T-Bb-FileInfoExtension'></a>
## FileInfoExtension `type`

##### Namespace

Bb

##### Summary

Provides extension methods for the [FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') class.

<a name='M-Bb-FileInfoExtension-WriteFile-System-IO-FileInfo,System-String,System-Text-Encoding-'></a>
### WriteFile(self,content,encoding) `method`

##### Summary

Write content to a file

##### Returns

The FileInfo instance that was written to, enabling method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.IO.FileInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileInfo 'System.IO.FileInfo') | file to write |
| content | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | content to write |
| encoding | [System.Text.Encoding](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.Encoding 'System.Text.Encoding') | The encoding to use when writing the file. If null, defaults to UTF-8. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.IOException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.IOException 'System.IO.IOException') | An I/O error occurs while opening or writing to the file. |
| [UnauthorizedAccessException](#!-UnauthorizedAccessException 'UnauthorizedAccessException') | The caller doesn't have the required permission. |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | The specified path is invalid, such as being on an unmapped drive. |
| [System.Security.SecurityException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Security.SecurityException 'System.Security.SecurityException') | The caller doesn't have the required permission. |

##### Example

```C#
// Create a new file and write content to it
var file = new FileInfo("example.txt");
file.WriteFile("Hello, World!"); // Uses default UTF-8 encoding
// Using specific encoding
file.WriteFile("Hello with encoding!", Encoding.ASCII);
// Method chaining example
file.WriteFile("New content").Refresh();
```

##### Remarks

This method writes the specified content to the file represented by the FileInfo object.
If the file already exists, it will be overwritten.
If the file doesn't exist, it will be created.

<a name='T-Bb-HttpHelper'></a>
## HttpHelper `type`

##### Namespace

Bb

##### Summary

Helper class for HTTP related operations

##### Remarks

This class provides utilities for working with HTTP, including generating URIs
and finding available network ports.

<a name='M-Bb-HttpHelper-GetAvailablePort-System-Int32-'></a>
### GetAvailablePort(startingPort) `method`

##### Summary

Finds an available TCP port starting from the specified port number

##### Returns

An available port number, or -1 if no ports are available

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| startingPort | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The minimum port number to consider. Must be between 1 and 65535 |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is less than 1 or greater than 65535 |

##### Example

```C#
// Find an available port starting from 8000
int port = HttpHelper.GetAvailablePort(8000);
Console.WriteLine($"Found available port: {port}");
// Use the port in a URI
Uri uri = HttpHelper.GetLocalUri(false, port);
```

##### Remarks

This method searches for an available port by:
1. Getting all currently used ports from active TCP connections
2. Getting all ports from active TCP listeners
3. Getting all ports from active UDP listeners
4. Finding the first available port number starting from the specified port

It's important to note that there is a small race condition where the port might become
unavailable between the check and when you actually use it.

<a name='M-Bb-HttpHelper-GetLocalUri-System-Boolean,System-Int32-'></a>
### GetLocalUri(securised,port) `method`

##### Summary

Creates a URI for the local machine (localhost)

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') for accessing the local machine with the specified protocol and port

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| securised | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, uses HTTPS protocol; otherwise, uses HTTP |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. If 0, the default port for the protocol will be used |

##### Example

```C#
// Get a URI for HTTP localhost
Uri httpUri = HttpHelper.GetLocalUri(false);  // http://localhost/
// Get a URI for HTTPS localhost with specific port
Uri httpsUri = HttpHelper.GetLocalUri(true, 8443);  // https://localhost:8443/
```

##### Remarks

This method creates a URI for the local machine using either HTTP or HTTPS protocol.
It's a convenience wrapper around GetUri that uses "localhost" as the host name.

<a name='M-Bb-HttpHelper-GetUri-System-Boolean,System-String,System-Int32-'></a>
### GetUri(securised,host,port) `method`

##### Summary

Creates a URI for the specified host

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') for accessing the specified host with the specified protocol and port

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| securised | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, uses HTTPS protocol; otherwise, uses HTTP |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name or IP address. Must not be null or empty |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. If 0, the default port for the protocol will be used |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when host is null |

##### Example

```C#
// Get a URI for HTTP
Uri httpUri = HttpHelper.GetUri(false, "example.com");  // http://example.com/
// Get a URI for HTTPS with specific port
Uri httpsUri = HttpHelper.GetUri(true, "example.com", 8443);  // https://example.com:8443/
// Get a URI with an IP address
Uri ipUri = HttpHelper.GetUri(false, "192.168.1.100", 8080);  // http://192.168.1.100:8080/
```

##### Remarks

This method creates a URI using the specified host, protocol, and port.
If port is 0, the default port for the protocol will be used (80 for HTTP, 443 for HTTPS).

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

<a name='T-Bb-StaticContainer'></a>
## StaticContainer `type`

##### Namespace

Bb

<a name='M-Bb-StaticContainer-Set``1-``0-'></a>
### Set\`\`1(self) `method`

##### Summary

Sets the instance of the specified type in the static container.

##### Returns

The same instance that was passed as a parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [\`\`0](#T-``0 '``0') | The instance to store in the container. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the object to store in the container. Must be a reference type. |

##### Example

```C#
// Store an instance in the static container
var myObject = new MyClass();
StaticContainer.Set(myObject);
// Retrieve the stored instance
var retrievedObject = StaticContainer.Get&lt;MyClass&gt;();
Console.WriteLine(retrievedObject == myObject); // Outputs: True
```

##### Remarks

This method allows you to store a single instance of a specified type in a static container.
The stored instance can later be retrieved using the [Get\`\`1](#M-Bb-StaticContainer-Get``1 'Bb.StaticContainer.Get``1') method.

<a name='T-Bb-StaticThreadContainer'></a>
## StaticThreadContainer `type`

##### Namespace

Bb

<a name='M-Bb-StaticThreadContainer-Set``1-``0-'></a>
### Set\`\`1(self) `method`

##### Summary

Sets the instance of the specified type in the thread-local static container.

##### Returns

The same instance that was passed as a parameter.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [\`\`0](#T-``0 '``0') | The instance to store in the container. Must not be null. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the object to store in the container. Must be a reference type. |

##### Example

```C#
// Store an instance in the thread-local static container
var myObject = new MyClass();
StaticThreadContainer.Set(myObject);
// Retrieve the stored instance
var retrievedObject = StaticThreadContainer.Get&lt;MyClass&gt;();
Console.WriteLine(retrievedObject == myObject); // Outputs: True
```

##### Remarks

This method allows you to store a single instance of a specified type in a thread-local static container.
Each thread will have its own instance of the object.

<a name='T-Bb-UriExtensions'></a>
## UriExtensions `type`

##### Namespace

Bb

<a name='M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostSecureUrlWithDynamicPort(self,host,startingPort,segments) `method`

##### Summary

Adds a secure (HTTPS) localhost URI with a dynamically selected available port to the list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
int port = 8000;
// Add a secure localhost URI with a dynamically selected port
uris.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "secure");
// Result might be: https://localhost:8000/api/secure if port 8000 is available
// port will be set to 8000
// Add another URI, will use a different port
uris.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "users");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds an HTTPS URI to the list with a dynamically selected available port.
It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "https" as the scheme.
The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostSecureUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostSecureUrlWithDynamicPort(self,host,startingPort,segments) `method`

##### Summary

Adds a secure (HTTPS) localhost URL with a dynamically selected available port to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var urls = new List&lt;string&gt;();
int port = 8000;
// Add a secure localhost URL with a dynamically selected port
urls.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "secure");
// Result might be: ["https://localhost:8000/api/secure"] if port 8000 is available
// port will be set to 8000
// Add another URL, will use a different port
urls.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "users");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds an HTTPS URL to the collection with a dynamically selected available port.
It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "https" as the scheme.
The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-Int32-'></a>
### AddLocalhostUrl(self,scheme,startPorts,count) `method`

##### Summary

Adds multiple localhost URLs with dynamically selected available ports to a URI list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| startPorts | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the last used port + 1. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of URIs to add. Must be greater than 0. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when count is less than 1 or startPorts is outside the valid port range. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
int startPort = 8000;
// Add 3 localhost URIs with HTTP scheme and available ports
uris.AddLocalhostUrl("http", ref startPort, 3);
// Result might be: http://localhost:8000, http://localhost:8001, http://localhost:8002
// startPort will be set to the last used port + 1 (e.g., 8003)
// Add 2 more URIs with HTTPS scheme
uris.AddLocalhostUrl("https", ref startPort, 2);
// Result might add: https://localhost:8003, https://localhost:8004
// startPort will be updated again
```

##### Remarks

This method adds multiple localhost URIs to the list, each with a dynamically selected available port.
It finds sequential available ports starting from the startPorts parameter.
The startPorts parameter is updated to the last used port + 1 when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-List{System-Uri},System-String,System-Int32,System-String[]-'></a>
### AddLocalhostUrl(self,scheme,port,segments) `method`

##### Summary

Adds a localhost URI with the specified scheme, port, and path segments to the list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URI is not valid. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
// Add a simple localhost URI
uris.AddLocalhostUrl("http", 8080);
// Result: [http://localhost:8080/]
// Add a localhost URI with path segments
uris.AddLocalhostUrl("https", 443, "api", "status");
// Result: [http://localhost:8080/, https://localhost:443/api/status]
// Method chaining
uris.AddLocalhostUrl("http", 9000)
    .AddLocalhostUrl("http", 9001);
```

##### Remarks

This method is a convenience wrapper around the AddUrl method that uses "localhost" as the host name.
It creates a new URI with the specified scheme, "localhost" as the host, the provided port, and path segments,
then adds it to the list.

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-Int32-'></a>
### AddLocalhostUrl(self,scheme,startPorts,count) `method`

##### Summary

Adds multiple localhost URLs with dynamically selected available ports to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL scheme (e.g., "http", "https"). Must not be null or empty. |
| startPorts | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the last used port. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of URLs to add. Must be greater than 0. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when count is less than 1 or startPorts is outside the valid port range. |

##### Example

```C#
var urls = new List&lt;string&gt;();
int startPort = 8000;
// Add 3 localhost URLs with HTTP scheme and available ports
urls.AddLocalhostUrl("http", ref startPort, 3);
// Result might be: ["http://localhost:8001/", "http://localhost:8002/", "http://localhost:8003/"]
// startPort will be set to the last used port (e.g., 8003)
// Add 2 more URLs with HTTPS scheme
urls.AddLocalhostUrl("https", ref startPort, 2);
// Result might add: ["https://localhost:8004/", "https://localhost:8005/"]
// startPort will be updated again
```

##### Remarks

This method adds multiple localhost URLs to the string collection, each with a dynamically selected available port.
It finds sequential available ports starting from the startPorts parameter.
The startPorts parameter is updated to the last used port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrl-System-Collections-Generic-ICollection{System-String},System-String,System-Int32,System-String[]-'></a>
### AddLocalhostUrl(self,scheme,port,segments) `method`

##### Summary

Adds a localhost URL with the specified scheme, port, and path segments to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL scheme (e.g., "http", "https"). Must not be null or empty. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URL is not valid. |

##### Example

```C#
var urls = new List&lt;string&gt;();
// Add a simple localhost URL
urls.AddLocalhostUrl("http", 8080);
// Result: ["http://localhost:8080/"]
// Add a localhost URL with path segments
urls.AddLocalhostUrl("https", 443, "api", "status");
// Result: ["http://localhost:8080/", "https://localhost:443/api/status"]
// Method chaining
urls.AddLocalhostUrl("http", 9000)
    .AddLocalhostUrl("http", 9001);
```

##### Remarks

This method is a convenience wrapper around the AddUrl method that uses "localhost" as the host name.
It creates a new URL with the specified scheme, "localhost" as the host, the provided port, and path segments,
then adds it as a string to the collection.

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(self,host,startingPort,segments) `method`

##### Summary

Adds a non-secure (HTTP) localhost URI with a dynamically selected available port to the list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
int port = 8000;
// Add a non-secure localhost URI with a dynamically selected port
uris.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "public");
// Result might be: http://localhost:8000/api/public if port 8000 is available
// port will be set to 8000
// Add another URI, will use a different port
uris.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "metrics");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds an HTTP URI to the list with a dynamically selected available port.
It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "http" as the scheme.
The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(self,scheme,host,startingPort,segments) `method`

##### Summary

Adds a URI with the specified scheme, host, and a dynamically selected available port to the list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
int port = 8000;
// Add a URI with a dynamically selected port
uris.AddLocalhostUrlWithDynamicPort("http", "example.local", ref port, "api");
// Result might be: http://example.local:8000/api if port 8000 is available
// port will be set to 8000
// Add another URI with a different scheme
uris.AddLocalhostUrlWithDynamicPort("https", "secure.local", ref port, "api", "v1");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds a URI to the list with a dynamically selected available port.
It finds an available port starting from the startingPort parameter, ensuring the port is not already used
by any URI in the list. The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(self,host,startingPort,segments) `method`

##### Summary

Adds a non-secure (HTTP) localhost URL with a dynamically selected available port to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var urls = new List&lt;string&gt;();
int port = 8000;
// Add a non-secure localhost URL with a dynamically selected port
urls.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "public");
// Result might be: ["http://localhost:8000/api/public"] if port 8000 is available
// port will be set to 8000
// Add another URL, will use a different port
urls.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "metrics");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds an HTTP URL to the collection with a dynamically selected available port.
It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "http" as the scheme.
The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddLocalhostUrlWithDynamicPort-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32@,System-String[]-'></a>
### AddLocalhostUrlWithDynamicPort(self,scheme,host,startingPort,segments) `method`

##### Summary

Adds a URL with the specified scheme, host, and a dynamically selected available port to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL scheme (e.g., "http", "https"). Must not be null or empty. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name. If null, "localhost" will be used. |
| startingPort | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | Starting port number to search for available ports. Will be updated to the port that was used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self or scheme is null. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | Thrown when startingPort is outside the valid port range. |

##### Example

```C#
var urls = new List&lt;string&gt;();
int port = 8000;
// Add a URL with a dynamically selected port
urls.AddLocalhostUrlWithDynamicPort("http", "example.local", ref port, "api");
// Result might be: ["http://example.local:8000/api"] if port 8000 is available
// port will be set to 8000
// Add another URL with a different scheme
urls.AddLocalhostUrlWithDynamicPort("https", "secure.local", ref port, "api", "v1");
// port will be updated to the newly selected port
Console.WriteLine($"Selected port: {port}");
```

##### Remarks

This method adds a URL to the collection with a dynamically selected available port.
It finds an available port starting from the startingPort parameter, ensuring the port is not already used
by any URL in the collection. The startingPort parameter is updated to the selected port when the method returns.

<a name='M-Bb-UriExtensions-AddUrl-System-Collections-Generic-List{System-Uri},System-String,System-String,System-Int32,System-String[]-'></a>
### AddUrl(self,scheme,hostName,port,segments) `method`

##### Summary

Adds a URI with the specified scheme, host, port, and path segments to the list.

##### Returns

The [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.List{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List 'System.Collections.Generic.List{System.Uri}') | The list of URIs to add to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| hostName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name or IP address. Must not be null or empty. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self, scheme, or hostName is null. |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URI is not valid. |

##### Example

```C#
var uris = new List&lt;Uri&gt;();
// Add a simple URI
uris.AddUrl("http", "example.com", 8080);
// Result: [http://example.com:8080/]
// Add a URI with path segments
uris.AddUrl("https", "api.example.com", 443, "v1", "users");
// Result: [http://example.com:8080/, https://api.example.com:443/v1/users]
// Method chaining
uris.AddUrl("http", "localhost", 9000)
    .AddUrl("http", "localhost", 9001);
```

##### Remarks

This method creates a new URI with the specified scheme, host name, port, and path segments,
then adds it to the list. The URI is constructed using the ToUri extension method.

<a name='M-Bb-UriExtensions-AddUrl-System-Collections-Generic-ICollection{System-String},System-String,System-String,System-Int32,System-String[]-'></a>
### AddUrl(self,scheme,hostName,port,segments) `method`

##### Summary

Adds a URL with the specified scheme, host, port, and path segments to a string collection.

##### Returns

The [ICollection\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection`1 'System.Collections.Generic.ICollection`1') instance for method chaining.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| self | [System.Collections.Generic.ICollection{System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.ICollection 'System.Collections.Generic.ICollection{System.String}') | The collection of strings to add URLs to. Must not be null. |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URL scheme (e.g., "http", "https"). Must not be null or empty. |
| hostName | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name or IP address. Must not be null or empty. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URL. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when self, scheme, or hostName is null. |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URL is not valid. |

##### Example

```C#
var urls = new List&lt;string&gt;();
// Add a simple URL
urls.AddUrl("http", "example.com", 8080);
// Result: ["http://example.com:8080/"]
// Add a URL with path segments
urls.AddUrl("https", "api.example.com", 443, "v1", "users");
// Result: ["http://example.com:8080/", "https://api.example.com:443/v1/users"]
// Method chaining
urls.AddUrl("http", "localhost", 9000)
    .AddUrl("http", "localhost", 9001);
```

##### Remarks

This method creates a new URL with the specified scheme, host name, port, and path segments,
then adds it as a string to the collection. The URL is constructed using the ToUri extension method.

<a name='M-Bb-UriExtensions-Combine-System-String[]-'></a>
### Combine(parts) `method`

##### Summary

Combines URL parts into a single URL string, ensuring proper separation between components

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') representing the combined URL with properly encoded illegal characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parts | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | The URL parts to combine. May contain path segments, query parameters, and fragments. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when parts is null. |

##### Example

```C#
string url1 = UriExtensions.Combine("https://example.com", "api/users", "?id=123", "&amp;name=test");
// Result: https://example.com/api/users?id=123&amp;name=test
string url2 = UriExtensions.Combine("api", "/users/", "/details", "?id=42", "#section");
// Result: api/users/details?id=42#section
// Empty parts are ignored
string url3 = UriExtensions.Combine("https://example.org", "", "resources");
// Result: https://example.org/resources
```

##### Remarks

This method combines URL parts into a single URL string, ensuring:
- Exactly one '/' separates each path segment
- Exactly one '&' separates each query parameter
- Proper handling of '?' for query string start
- Proper handling of '#' for fragment start
- URL-encoding of illegal characters but not reserved characters

The method is aware of the URL structure and treats parts differently based on whether they're
in the path, query string, or fragment portion of the URL.

<a name='M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri}-'></a>
### ConcatUrl(urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the concatenated URLs separated by semicolons.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| urls | [System.Collections.Generic.IEnumerable{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Uri}') | Collection of [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') objects to concatenate. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when urls is null. |

##### Example

```C#
var list = new List&lt;Uri&gt;();
list.Add(new Uri("http://localhost:8080"));
list.Add(new Uri("http1://localhost:8081"));
StringBuilder paths = list.ConcatUrl();
// result : http://localhost:8080;http1://localhost:8081
```

##### Remarks

This method concatenates all URIs in the collection into a single string, with each URI separated by a semicolon.
All URIs are converted to lowercase.

<a name='M-Bb-UriExtensions-ConcatUrl-System-Collections-Generic-IEnumerable{System-Uri},System-Text-StringBuilder-'></a>
### ConcatUrl(sb,urls) `method`

##### Summary

return a [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') with Concatenated url separated by ';'.

##### Returns

A [StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') containing the concatenated URLs separated by semicolons.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sb | [System.Collections.Generic.IEnumerable{System.Uri}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Uri}') | The StringBuilder to append URLs to. If null, a new StringBuilder with capacity 200 will be created. |
| urls | [System.Text.StringBuilder](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Text.StringBuilder 'System.Text.StringBuilder') | Collection of [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') objects to concatenate. Must not be null. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when urls is null. |

##### Example

```C#
var list = new List&lt;Uri&gt;();
list.Add(new Uri("http://localhost:8080"));
list.Add(new Uri("http1://localhost:8081"));
StringBuilder result = list.ConcatUrl(new StringBuilder(200));
// result : http://localhost:8080;http1://localhost:8081
```

##### Remarks

This method concatenates all URIs in the collection into the provided StringBuilder, with each URI separated by a semicolon.
All URIs are converted to lowercase. If the provided StringBuilder is null, a new one with capacity 200 is created.

<a name='M-Bb-UriExtensions-EncodeIllegalCharacters-System-String,System-Boolean-'></a>
### EncodeIllegalCharacters(s,encodeSpaceAsPlus) `method`

##### Summary

URL-encodes characters in a string that are neither reserved nor unreserved

##### Returns

A [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') with illegal characters URL-encoded.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to encode. Can be null or empty. |
| encodeSpaceAsPlus | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20. |

##### Example

```C#
string encoded1 = UriExtensions.EncodeIllegalCharacters("path/with spaces?param=value&amp;other=value");
// Result: path/with%20spaces?param=value&amp;other=value
string encoded2 = UriExtensions.EncodeIllegalCharacters("query with spaces", true);
// Result: query+with+spaces
// Already encoded sequences remain intact
string encoded3 = UriExtensions.EncodeIllegalCharacters("already%20encoded%20text");
// Result: already%20encoded%20text
```

##### Remarks

This method URL-encodes only characters that are neither reserved nor unreserved according to RFC 3986.
It avoids encoding reserved characters such as '/', '?', '&', etc.
It also avoids double-encoding by not encoding '%' characters that are already part of a valid %-encoded sequence.

If encodeSpaceAsPlus is true, spaces will be encoded as '+' signs (which is common in query strings),
otherwise they'll be encoded as '%20'.

<a name='M-Bb-UriExtensions-OrdinalContains-System-String,System-String,System-Boolean-'></a>
### OrdinalContains(s,value,ignoreCase) `method`

##### Summary

Determines if a string contains the specified value using ordinal comparison

##### Returns

`true` if the string contains the specified value; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check. Can be null. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to search for within the string. |
| ignoreCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, performs a case-insensitive comparison; otherwise, case-sensitive. |

##### Remarks

This method is a wrapper around String.IndexOf that uses ordinal comparison for better performance.
It safely handles null strings by returning false.

<a name='M-Bb-UriExtensions-OrdinalEndsWith-System-String,System-String,System-Boolean-'></a>
### OrdinalEndsWith(s,value,ignoreCase) `method`

##### Summary

Determines if a string ends with the specified value using ordinal comparison

##### Returns

`true` if the string ends with the specified value; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check. Can be null. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to look for at the end of the string. |
| ignoreCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, performs a case-insensitive comparison; otherwise, case-sensitive. |

##### Remarks

This method is a wrapper around String.EndsWith that uses ordinal comparison for better performance.
It safely handles null strings by returning false.

<a name='M-Bb-UriExtensions-OrdinalStartsWith-System-String,System-String,System-Boolean-'></a>
### OrdinalStartsWith(s,value,ignoreCase) `method`

##### Summary

Determines if a string starts with the specified value using ordinal comparison

##### Returns

`true` if the string starts with the specified value; otherwise, `false`.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| s | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The string to check. Can be null. |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value to look for at the start of the string. |
| ignoreCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | If true, performs a case-insensitive comparison; otherwise, case-sensitive. |

##### Remarks

This method is a wrapper around String.StartsWith that uses ordinal comparison for better performance.
It safely handles null strings by returning false.

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String[]-'></a>
### ToUri(url,segments) `method`

##### Summary

Creates a Uri from a URL string and additional path segments

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') object representing the combined URL with all segments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| url | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The base URL to convert to a Uri. Must be a valid absolute URI. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the base URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the URL is not a valid URI format. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when the URL is null. |

##### Example

```C#
Uri uri1 = "http://localhost:80".ToUri("api", "users");
// Result: http://localhost:80/api/users
Uri uri2 = "https://example.com".ToUri("path/with/slash");
// Result: https://example.com/path/with/slash
// Handles null segments by ignoring them
Uri uri3 = "http://localhost".ToUri("segment1", null, "segment2");
// Result: http://localhost/segment1/segment2
```

##### Remarks

This method creates a URI from a base URL string and appends any additional path segments.
Each segment is added to the URI using the Uri constructor that combines a base URI with a relative URI string.
Null segments are ignored.

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32,System-String[]-'></a>
### ToUri(scheme,host,port,segments) `method`

##### Summary

Creates a URI using the specified scheme, host, port, and path segments

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') object representing the constructed URI with all segments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name or IP address. Must not be null or empty. |
| port | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The port number to use. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URI is not valid. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when scheme or host is null. |

##### Example

```C#
Uri uri1 = "http".ToUri("example.com", 8080, "api", "users");
// Result: http://example.com:8080/api/users
Uri uri2 = "https".ToUri("localhost", 443, "secure", "endpoint");
// Result: https://localhost:443/secure/endpoint
// Empty segments will result in consecutive slashes
Uri uri3 = "http".ToUri("example.org", 80, "", "resource");
// Result: http://example.org:80//resource
```

##### Remarks

This method constructs a URI by combining the scheme, host, and port into a base URI,
then appends any additional path segments. Each segment is added using the Uri constructor
that combines a base URI with a relative URI string.

<a name='M-Bb-UriExtensions-ToUri-System-String,System-String,System-Int32@,System-String[]-'></a>
### ToUri(scheme,host,port,segments) `method`

##### Summary

Creates a URI using the specified scheme, host, and an available port starting from the provided port number

##### Returns

A [Uri](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Uri 'System.Uri') object representing the constructed URI with the first available port and all segments.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| scheme | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The URI scheme (e.g., "http", "https"). Must not be null or empty. |
| host | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The host name or IP address. Must not be null or empty. |
| port | [System.Int32@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32@ 'System.Int32@') | The starting port number to find an available port. Will be updated with the actual port used. |
| segments | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') | Additional path segments to append to the URI. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.UriFormatException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.UriFormatException 'System.UriFormatException') | Thrown when the resulting URI is not valid. |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Thrown when scheme or host is null. |

##### Example

```C#
int port = 8000;
Uri uri = "http".ToUri("localhost", ref port, "api", "status");
// If port 8000 is available:
// Result: http://localhost:8000/api/status
// port variable will be 8000
// If port 8000 is in use but 8001 is available:
// Result: http://localhost:8001/api/status
// port variable will be 8001
Console.WriteLine($"Using port: {port}");
```

##### Remarks

This method finds the first available port starting from the provided port number,
then constructs a URI using the scheme, host, and that port. It updates the port parameter
with the actual port used, and appends any additional path segments to the URI.

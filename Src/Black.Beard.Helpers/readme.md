# Black.Beard.Helpers


![NuGet](https://img.shields.io/nuget/v/Black.Beard.Helpers.svg)

## Introduction
Black.Beard.Helpers is a powerful .NET utility library that streamlines file system operations, content manipulation, URI handling, and network tasks. It provides a comprehensive set of extension methods and helper classes designed to reduce boilerplate code and improve developer productivity when working with file systems and content resources.

## Key benefits:
- **Intuitive API** design with fluent interfaces and method chaining for improved code readability
- **Cross-platform compatibility** ensuring consistent behavior across Windows, macOS, and Linux
- **Robust error handling** with clear exception patterns and informative messages
- **Performance optimizations** for common content operations
- **Extensive content encoding support** with automatic detection and conversion

## Installation

### Prerequisites
- .NET Standard 2.0+
- .NET Core 2.0+ / .NET 5.0+
- .NET Framework 4.6.1+

### Package Manager
```ps
Install-Package Black.Beard.Helpers
```
### .NET CLI
```ps
dotnet add package Black.Beard.Helpers
```

### Package Reference
```xml
<PackageReference Include="Black.Beard.Helpers" Version="1.0.0" />
```

## Features

### Generic singleton
use a generic method for store datas in a singleton

```csharp
using Bb;

// global
StaticContainer.Set(new MyClass())
var value = StaticContainer.Get<MyClass>();

// For the current thread
StaticThreadContainer.Set(new MyClass())
var value = StaticThreadContainer.Get<MyClass>();

```


### File and Directory Management
Easily work with files and directories using intuitive extension methods.
```csharp
using Bb;

// Create directory if it doesn't exist
DirectoryInfo dir = @"C:\temp\projects".CreateFolderIfNotExists();

// Write content to files with encoding options
FileInfo log = new FileInfo("application.log");
log.WriteFile("Application started", append: true);

// Copy files between directories
var source = new FileInfo("document.pdf");
bool success = source.CopyToDirectory(@"C:\backup", overwrite: false);
```


### Path Operations
Handle file paths consistently across platforms.
```csharp
using Bb;

// Convert between string paths and FileInfo/DirectoryInfo
FileInfo file = @"C:\config\settings.json".AsFile();
DirectoryInfo dir = @"C:\logs".AsDirectory();

// Platform-aware path comparison
bool areEqual = @"C:\Program Files".IsPathEquals(@"c:\program files");
// true on Windows, false on Linux

// Safely combine path segments
string path = @"C:\projects".Combine("src", "main", "resources");
// "C:\projects\src\main\resources"
```


### using Bb;
```csharp
// Create URIs with path segments
Uri api = "https://api.example.com".ToUri("v2", "users");
// https://api.example.com/v2/users

// Find available ports and create URIs
int port = 8000;
Uri serviceUri = "http".ToUri("localhost", ref port, "api");
// port will be updated to an available port number

// Combine URL parts safely
string url = UriExtensions.Combine(
    "https://example.com", 
    "search", 
    "?q=dotnet", 
    "&page=1"
);
// https://example.com/search?q=dotnet&page=1

```



### HTTP and Network Helpers
Simplify HTTP operations and network resource handling.
```csharp
using Bb;
using System.IO;

// Download content from a URL to a file
Uri source = new Uri("https://example.com/files/document.pdf");
FileInfo target = new FileInfo("document.pdf");
source.Download(target);

// Find available network ports
int port = HttpHelper.GetAvailablePort(8080);
Console.WriteLine($"Port {port} is available for use");
```


## Platform Support
Black.Beard.Helpers is designed to work seamlessly across different operating systems:

- **Automatic platform detection** for path comparison and formatting
- **Path normalization** for consistent handling of forward/backward slashes
- **Case sensitivity awareness** that adapts to the operating system
- **Encoding detection and conversion** that works reliably across platforms


### License
This library is licensed under the MIT License - see the LICENSE file for details.
This library is licensed under the MIT License.


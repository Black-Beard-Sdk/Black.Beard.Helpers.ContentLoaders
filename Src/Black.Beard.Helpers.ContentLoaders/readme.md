# Black.Beard.ContentLoaders

![NuGet](https://img.shields.io/nuget/v/Black.Beard.ContentLoaders.svg)

## Introduction
Black.Beard.Helpers.ContentLoaders is a comprehensive utility library designed to simplify common file system operations, URI manipulations, and HTTP tasks in .NET applications. This package provides a collection of extension methods and helper classes that reduce boilerplate code, improve code readability, and handle platform-specific concerns when working with files, directories, and network resources.

## Key benefits:
- **Fluent API** with method chaining for improved readability
- **Cross-platform compatibility** with Windows and Unix systems
- **Simplified file and directory operations** with intuitive extensions
- **Easy URI construction and manipulation**
- **Dynamic port finding** for HTTP services
- **Consistent exception handling** across all operations

## Installation

### Prerequisites
- .NET Standard 2.0+, .NET Core 2.0+, or .NET Framework 4.6.1+

### Package Manager
```PS
Install-Package Black.Beard.Helpers
```

### .NET CLI
```PS
dotnet add package Black.Beard.Helpers
```
### Package Reference
```PS
<PackageReference Include="Black.Beard.Helpers" Version="1.0.0" />
```

## Features

### File and Directory Management
Simplify common file system operations with intuitive extension methods for FileInfo and DirectoryInfo.
```csharp
using Bb;

// Create directory if it doesn't exist
DirectoryInfo dir = @"C:\temp\projects".CreateFolderIfNotExists();

// Clean up directories safely
DirectoryInfo cleaned = @"C:\temp\cache".DeleteFolderIfExists(recursive: true);

// Chain operations for concise code
DirectoryInfo workspace = new DirectoryInfo(@"C:\workspace")
    .CreateFolderIfNotExists()
    .WriteFile("readme.txt", "Project workspace initialized");
```

### Working with Files
```csharp
using Bb;
using System.Text;

// Write content to files with encoding options
FileInfo log = new FileInfo("application.log");
log.WriteFile("Application started", append: true);
log.WriteFile("Données spéciales", Encoding.UTF8, append: true);

// Easy file copying with overwrite control
FileInfo source = new FileInfo("template.docx");
bool success = source.CopyToDirectory(@"C:\backup", overwrite: false);

// Copy with directory objects
var sourceDir = new DirectoryInfo(@"C:\documents");
var backupDir = new DirectoryInfo(@"C:\backup");
sourceDir.Copy("important.xlsx", backupDir);

Path Operations
Handle file paths consistently across platforms with helper methods for common path manipulations.
```

### Path Conversion and Validation
```csharp
using Bb;

// Convert between string paths and FileInfo/DirectoryInfo
FileInfo file = @"C:\config\settings.json".AsFile();
DirectoryInfo dir = @"C:\logs".AsDirectory();

// Check if paths are absolute
bool isAbsFile = @"C:\data\report.pdf".FilePathIsAbsolute();  // true
bool isAbsDir = "./temp".DirectoryPathIsAbsolute();           // false

// Format and normalize paths
string normalizedPath = "file:///C:/Users/name/My%20Documents/".FormatPath();
// On Windows: "C:\Users\name\My Documents\"
```


### Path Comparison and Combination
```csharp
using Bb;

// Platform-aware path comparison
bool areEqual = @"C:\Program Files".IsPathEquals(@"c:\program files");
// true on Windows, false on Linux

// Safely combine path segments
string path = @"C:\projects".Combine("src", "main", "resources");
// "C:\projects\src\main\resources"

// Type-safe path combination
var baseDir = new DirectoryInfo(@"C:\workspace");
string fullPath = baseDir.Combine("configs", "settings.json");
```

URI and URL Manipulation
Build, transform, and manipulate URIs with ease using extension methods and helpers.

### Creating and Modifying URIs
```csharp
using Bb;

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

### Managing URI Collections
```csharp
using Bb;
using System.Collections.Generic;

// Add multiple URIs with dynamic ports
var endpoints = new List<Uri>();
int startPort = 5000;
endpoints.AddLocalhostUrl("http", ref startPort, 3);
// Adds 3 URIs with available ports starting from 5000

// Concatenate URIs with separators
var services = new List<Uri> {
    new Uri("http://auth.local:9000"),
    new Uri("http://api.local:9001")
};
string serviceList = services.ConcatUrl().ToString();
// "http://auth.local:9000;http://api.local:9001"
```

HTTP and Network Helpers
Simplify HTTP operations and network resource handling with specialized helpers.


### HTTP Operations
```csharp
using Bb;
using System.IO;

// Download content from a URL to a file
Uri source = new Uri("https://example.com/files/document.pdf");
FileInfo target = new FileInfo("downloaded-document.pdf");
source.Download(target);

// With custom HTTP client configuration
source.Download(target, client => {
    client.DefaultRequestHeaders.Add("Authorization", "Bearer token123");
    client.Timeout = TimeSpan.FromMinutes(5);
});
```

### Network Resources
```csharp
using Bb;

// Find available network ports
int port = HttpHelper.GetAvailablePort(8080);
Console.WriteLine($"Port {port} is available for use");

// Create URIs for local or remote hosts
Uri localHttp = HttpHelper.GetLocalUri(false);  // http://localhost/
Uri localHttps = HttpHelper.GetLocalUri(true, 8443);  // https://localhost:8443/
Uri remoteApi = HttpHelper.GetUri(false, "api.example.com", 80);
```

Content and Encoding Management
Work with content in various formats and encodings with smart detection and conversion utilities.

### Encoding Detection and Conversion
```csharp
using Bb;

// Register support for additional encodings
ContentHelper.RegisterEncoding();

// Auto-detect encoding from content
byte[] fileBytes = File.ReadAllBytes("document.txt");
string content = fileBytes.LoadContentFromText();

// Convert between streams and strings
using (var memStream = new MemoryStream(fileBytes))
{
    string text = memStream.ConvertToString();
    Console.WriteLine($"Detected content: {text}");
}
```


### Base64 and JSON Utilities
```csharp
using Bb;
using System.Text.Json;

// Base64 encoding and decoding
string original = "Sensitive data: password123";
string encoded = original.ConvertToBase64();
string decoded = encoded.ConvertFromBase64();

// Simplified JSON serialization
var person = new { Name = "John", Age = 30 };
string json = person.Serialize(indented: true);

// Deserialize JSON to strongly-typed objects
var options = new JsonSerializerOptions { PropertyNameCaseInsensitive = true };
var deserializedPerson = json.Deserialize<Person>(options);
```

## Platform Support
Black.Beard.Helpers.ContentLoaders is designed to work across Windows, macOS, and Linux platforms. It includes special handling for platform-specific behaviors:
- **Path comparisons**: Case-insensitive on Windows, case-sensitive on Unix-based systems
- **Path separators**: Handles both forward and backward slashes regardless of platform
- **Path normalization**: Consistently formats paths according to platform conventions
- **URI handling**: Platform-agnostic implementation for URI manipulations


- **Windows, macOS, and Linux compatibility** with platform-specific behavior handling
- **Path format normalization** that handles both forward and backward slashes
- **Case sensitivity awareness** (case-insensitive on Windows, case-sensitive on Unix systems)
- **Encoding detection and conversion** that works across different platforms

The library automatically adapts to the underlying operating system, ensuring consistent behavior regardless of where your application runs.

### License
This library is licensed under the MIT License - see the LICENSE file for details.

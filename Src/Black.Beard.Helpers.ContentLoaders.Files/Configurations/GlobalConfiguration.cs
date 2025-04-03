using System;
using System.Collections.Generic;
using System.IO;
using Bb;
using System.Text;
using Json.Schema.Generation;
using System.Linq;

namespace Bb.Configurations
{

    /// <summary>
    /// Represents a configuration for starting the application.
    /// </summary>
    public class GlobalConfiguration
    {

        public const string Configuration = "Configurations";
        public const string Nuget = ".nugets";
        public const string Schema = "Schemas";

        /// <summary>
        /// Initializes a new instance of the <see cref="GlobalConfiguration"/> class.
        /// </summary>
        public GlobalConfiguration()
        {
            _folders = new Dictionary<string, ContentFolder>();
        }

        /// <summary>
        /// Sets the root directory for the global configuration.
        /// </summary>
        /// <param name="path">The path to the root directory. Must not be null or empty.</param>
        /// <returns>
        /// The current <see cref="GlobalConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method sets the root directory for the configuration. If the directory does not exist, it will be created.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when the provided path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// config.SetRoot("C:\\MyRootDirectory");
        /// </code>
        /// </example>
        public GlobalConfiguration SetRoot(string path)
        {
            if (string.IsNullOrEmpty(path))
                throw new ArgumentException("Path cannot be null or empty.", nameof(path));
            return SetRoot(new DirectoryInfo(path));
            return this;
        }

        /// <summary>
        /// Sets the root directory for the global configuration using a <see cref="DirectoryInfo"/> object.
        /// </summary>
        /// <param name="directory">The directory to set as the root. Must not be null.</param>
        /// <returns>
        /// The current <see cref="GlobalConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method sets the root directory for the configuration. If the directory does not exist, it will be created.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when the provided directory is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// var directory = new DirectoryInfo("C:\\MyRootDirectory");
        /// config.SetRoot(directory);
        /// </code>
        /// </example>
        public GlobalConfiguration SetRoot(DirectoryInfo directory)
        {
            if (directory == null)
                throw new ArgumentException("Path cannot be null or empty.", nameof(directory));
            if (!directory.Exists)
                directory.Create();
            _root = directory;
            return this;
        }

        /// <summary>
        /// Adds a directory to the specified content folder in the configuration.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <param name="paths">An array of additional paths to include. Can be empty.</param>
        /// <returns>
        /// The current <see cref="GlobalConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds a directory to the specified content folder. The root directory is automatically included.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// config.WithDirectory("MyFolder", "C:\\Path1", "C:\\Path2");
        /// </code>
        /// </example>
        public GlobalConfiguration WithDirectory(string name, params string[] paths)
        {
            var item = this[name];
            var o = new List<string>(paths.Length + 1) { _root.FullName };
            o.AddRange(paths.Where(c => !string.IsNullOrEmpty(c)));
            item.AddDirectory(Path.Combine(o.ToArray()));
            return this;
        }


        /// <summary>
        /// Executes an action for each directory in the specified content folder.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <param name="action">The action to execute for each directory. Must not be null.</param>
        /// <remarks>
        /// This method retrieves the content folder by its name and executes the specified action for each directory in the folder.
        /// </remarks>
        /// <exception cref="KeyNotFoundException">Thrown if the specified content folder does not exist.</exception>
        /// <example>
        /// <code lang="C#">
        /// var config = new StartingConfiguration();
        /// config.Execute("MyFolder", directory =>
        /// {
        ///     Console.WriteLine($"Processing directory: {directory.FullName}");
        /// });
        /// </code>
        /// </example>
        public void Execute(string name, Action<DirectoryInfo> action)
        {
            var item = this[name];
            foreach (var directory in item.GetPaths())
            {
                var di = new DirectoryInfo(directory);
                di.Refresh();
                action(di);
            }
        }

        /// <summary>
        /// Sets the schema owner URI for the global configuration.
        /// </summary>
        /// <param name="uri">The URI to set as the schema owner. Must not be null.</param>
        /// <returns>
        /// The current <see cref="GlobalConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method sets the schema owner URI, which is used for generating schemas.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// config.SetSchemaOwner(new Uri("http://localhost:8080/"));
        /// </code>
        /// </example>
        public GlobalConfiguration SetSchemaOwner(Uri uri)
        {
            _uri = new Uri("http://localhost:8080/");
            return this;
        }

        /// <summary>
        /// Retrieves a document of the specified type from the configuration.
        /// </summary>
        /// <typeparam name="T">The type of the document to retrieve. Must be a reference type.</typeparam>
        /// <param name="name">The name of the content folder containing the document. Must not be null or empty.</param>
        /// <returns>
        /// A <typeparamref name="T"/> instance representing the document, or null if the document does not exist.
        /// </returns>
        /// <remarks>
        /// This method retrieves a document of the specified type from the specified content folder.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// var document = config.GetDocument&lt;MyDocumentType&gt;("MyFolder");
        /// if (document != null)
        /// {
        ///     Console.WriteLine("Document retrieved successfully.");
        /// }
        /// </code>
        /// </example>
        public T GetDocument<T>(string name) where T : class
        {
            var item = this[name];
            if (item.Any)
            {
                var filename = GetFilename(typeof(T));
                var content = item.GetDocument<T>(filename + ".json");
                return content;
            }
            return null;
        }


        /// <summary>
        /// Appends a document of the specified type to the configuration.
        /// </summary>
        /// <typeparam name="T">The type of the document to append. Must be a reference type.</typeparam>
        /// <param name="name">The name of the content folder to append the document to. Must not be null or empty.</param>
        /// <param name="content">The document content to append. Must not be null.</param>
        /// <returns>
        /// A <see cref="bool"/> indicating whether the document was successfully appended.
        /// </returns>
        /// <remarks>
        /// This method appends a document of the specified type to the specified content folder. If the folder contains schemas, a schema file is also generated.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// var document = new MyDocumentType { Property = "Value" };
        /// bool success = config.AppendDocument("MyFolder", document);
        /// Console.WriteLine($"Document appended: {success}");
        /// </code>
        /// </example>
        public bool AppendDocument<T>(string name, T content) where T : class
        {

            var filename = GetFilename(typeof(T));
            var item = this[GlobalConfiguration.Schema];
            if (item.Any)
            {
                var options = new SchemaGeneratorConfiguration();
                var schema = typeof(T).GenerateSchemaForConfiguration(_uri, options);
                item.Append(schema, filename + ".schema.json");
            }

            item = this[name];
            if (item.Any)
            {
                item.Append(content, filename + ".json");
                return true;
            }

            return false;

        }


        /// <summary>
        /// Executes an action for the first directory in the specified content folder.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <param name="action">The action to execute for the first directory. Must not be null.</param>
        /// <remarks>
        /// This method retrieves the content folder by its name and executes the specified action for the first directory in the folder.
        /// </remarks>
        /// <exception cref="KeyNotFoundException">Thrown if the specified content folder does not exist.</exception>
        /// <example>
        /// <code lang="C#">
        /// var config = new StartingConfiguration();
        /// config.ExecuteFirst("MyFolder", directory =>
        /// {
        ///     Console.WriteLine($"Processing first directory: {directory.FullName}");
        /// });
        /// </code>
        /// </example>
        public void ExecuteFirst(string name, Action<DirectoryInfo> action)
        {
            var item = this[name];
            foreach (var directory in item.GetPaths())
            {
                var di = new DirectoryInfo(directory);
                di.Refresh();
                action(di);
                break;
            }
        }


        /// <summary>
        /// Gets the content folder associated with the specified name.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <returns>
        /// A <see cref="ContentFolder"/> instance associated with the specified name. If the folder does not exist, a new one is created.
        /// </returns>
        /// <remarks>
        /// This indexer retrieves the content folder by its name. If the folder does not exist, it creates a new instance and adds it to the collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new StartingConfiguration();
        /// var folder = config["MyFolder"];
        /// Console.WriteLine($"Folder name: {folder.Name}");
        /// </code>
        /// </example>
        public ContentFolder this[string name]
        {
            get
            {
                if (!_folders.TryGetValue(name, out var configurationFolder))
                    lock (_lock)
                        if (!_folders.TryGetValue(name, out configurationFolder))
                            _folders.Add(name, configurationFolder = new ContentFolder(name));
                return configurationFolder;
            }
        }

        /// <summary>
        /// Generates a filename based on the specified type.
        /// </summary>
        /// <param name="type">The type for which the filename will be generated. Must not be null.</param>
        /// <returns>
        /// A <see cref="string"/> representing the generated filename based on the type name.
        /// </returns>
        /// <remarks>
        /// This method generates a filename by processing the name of the specified type. It ensures that the filename is formatted correctly for use in file systems.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the provided type is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// string filename = GlobalConfiguration.GetFilename(typeof(MyClass));
        /// Console.WriteLine($"Generated filename: {filename}");
        /// </code>
        /// </example>
        public static string GetFilename(Type type)
        {
            return GetFilename(type.Name);
        }

        /// <summary>
        /// Generates a filename based on the specified name.
        /// </summary>
        /// <param name="name">The name for which the filename will be generated. Must not be null or empty.</param>
        /// <returns>
        /// A <see cref="string"/> representing the generated filename based on the provided name.
        /// </returns>
        /// <remarks>
        /// This method processes the provided name to generate a valid filename. It ensures that the filename is formatted correctly for use in file systems.
        /// </remarks>
        /// <exception cref="ArgumentException">Thrown when the provided name is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// string filename = GlobalConfiguration.GetFilename("MyClassName");
        /// Console.WriteLine($"Generated filename: {filename}");
        /// </code>
        /// </example>
        public static string GetFilename(string name)
        {

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Name cannot be null or empty.", nameof(name));

            var cleanName = new StringBuilder();
            bool capitalizeNext = false;

            foreach (var c in name)
            {

                if (cleanName.Length == 0 && char.IsLetterOrDigit(c))
                    cleanName.Append(char.ToUpper(c));

                else if (char.IsLetterOrDigit(c) || c == '.')
                {

                    var v = capitalizeNext || char.IsUpper(c)
                        ? char.ToUpper(c)
                        : char.ToLower(c);

                    cleanName.Append(v);
                    capitalizeNext = false;
                }
                else
                {
                    capitalizeNext = true;
                }
            }

            return cleanName.ToString();
        }


        /// <summary>
        /// Adds a custom action to the specified content folder.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <param name="value">The action to execute on the content folder. Must not be null.</param>
        /// <returns>
        /// The current <see cref="GlobalConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method allows you to execute a custom action on a specified content folder.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var config = new GlobalConfiguration();
        /// config.With("MyFolder", folder => folder.AddDirectory("C:\\MyDirectory"));
        /// </code>
        /// </example>
        public GlobalConfiguration With(string name, Action<ContentFolder> value)
        {

            if (value == null)
                throw new ArgumentNullException(nameof(value));

            var item = this[name];
            value(item);

            return this;

        }

        
        private static object _lock = new object();
        private Dictionary<string, ContentFolder> _folders;
        private Uri _uri;
        private DirectoryInfo _root;

    }


}


/*
 
        /// <summary>
        /// Sets a configuration value for the specified key.
        /// </summary>
        /// <param name="key">The key of the configuration setting. Must not be null or empty.</param>
        /// <param name="value">The value to associate with the key. Can be null.</param>
        /// <returns>
        /// The current <see cref="StartingConfiguration"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds or updates a configuration setting in the internal dictionary.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// StartingConfiguration.Instance.Set("AppName", "MyApplication");
        /// </code>
        /// </example>
        public StartingConfiguration Set(string key, object value)
        {
            if (_settings.ContainsKey(key))
                _settings[key] = value;
            else
                _settings.Add(key, value);
            return this;
        }

        /// <summary>
        /// Gets the value associated with the specified key.
        /// </summary>
        /// <typeparam name="T">The type of the value to retrieve.</typeparam>
        /// <param name="key">The key of the configuration setting. Must not be null or empty.</param>
        /// <returns>
        /// The value associated with the specified key, or the default value of <typeparamref name="T"/> if the key does not exist.
        /// </returns>
        /// <remarks>
        /// This method retrieves a configuration value and casts it to the specified type.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string appName = StartingConfiguration.Instance.Get&lt;string&gt;("AppName");
        /// Console.WriteLine(appName);
        /// </code>
        /// </example>
        public T Get<T>(string key)
        {
            if (_settings.TryGetValue(key, out object value))
                return (T)value.ConvertTo<T>();
            return default;
        }

        /// <summary>
        /// Gets a formatted string of all configuration key-value pairs.
        /// </summary>
        /// <returns>
        /// A formatted string containing all configuration key-value pairs.
        /// </returns>
        /// <remarks>
        /// This method formats the configuration settings into a human-readable string.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string configValues = StartingConfiguration.Instance.GetValues();
        /// Console.WriteLine(configValues);
        /// </code>
        /// </example>
        public string GetValues()
        {
            int maxKeyLength = _settings.Keys.Max(key => key.Length) + 1;
            List<string> result = new List<string>();
            foreach (var item in _settings)
            {
                string formattedKey = item.Key.PadRight(maxKeyLength);
                result.Add($"{formattedKey}= {item.Value}");
            }

            return string.Join(Environment.NewLine, result);

        }

        /// <summary>
        /// Loads configuration settings from a file.
        /// </summary>
        /// <param name="filePath">The path to the configuration file. Must not be null or empty.</param>
        /// <remarks>
        /// This method reads key-value pairs from a file and adds them to the configuration.
        /// </remarks>
        /// <exception cref="FileNotFoundException">
        /// Thrown if the specified file does not exist.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// StartingConfiguration.Instance.LoadFromFile("config.txt");
        /// </code>
        /// </example>
        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException($"The configuration file '{filePath}' was not found.");
            SetFromContent(filePath);
        }

        /// <summary>
        /// Parses and sets configuration settings from the content of a file.
        /// </summary>
        /// <param name="filePath">The path to the configuration file. Must not be null or empty.</param>
        /// <remarks>
        /// This method reads the content of a file and parses it into key-value pairs.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// StartingConfiguration.Instance.SetFromContent("config.txt");
        /// </code>
        /// </example>
        public void SetFromContent(string filePath)
        {
            var lines = File.ReadAllLines(filePath);
            foreach (var line in lines)
            {
                var parts = line.Split(new[] { '=' }, 2);
                if (parts.Length == 2)
                {
                    var key = parts[0].Trim();
                    var value = parts[1].Trim();
                    _settings[key] = value;
                }
            }
        }

        private Dictionary<string, object> _settings;
 */
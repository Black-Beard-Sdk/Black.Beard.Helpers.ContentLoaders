﻿using System;
using System.Collections.Generic;
using System.IO;

namespace Bb.Configurations
{

    /// <summary>
    /// Represents a configuration for starting the application.
    /// </summary>
    public class StartingConfiguration
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="StartingConfiguration"/> class.
        /// </summary>
        public StartingConfiguration()
        {
            _folders = new Dictionary<string, ContentFolder>();
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

        private static object _lock = new object();
        private Dictionary<string, ContentFolder> _folders;

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
using Bb;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Bb.Configurations
{


    /// <summary>
    /// Represents a collection of directories used for configuration purposes.
    /// </summary>
    public class ContentFolder
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="ContentFolder"/> class with the specified name.
        /// </summary>
        /// <param name="name">The name of the content folder. Must not be null or empty.</param>
        /// <remarks>
        /// This constructor creates a new instance of the <see cref="ContentFolder"/> class and initializes an empty collection of directories.
        /// </remarks>
        internal ContentFolder(string name)
        {
            Name = name;
            _list = new List<DirectoryInfo>();
        }

        /// <summary>
        /// Adds the directory of the executing assembly to the collection.
        /// </summary>
        /// <param name="insertFirst">If true, inserts the directory at the first position in the collection; otherwise, appends it to the end.</param>
        /// <remarks>
        /// This method retrieves the directory of the currently executing assembly and adds it to the collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// folder.AddExecutingAssemblyDirectory();
        /// </code>
        /// </example>
        public void AddExecutingAssemblyDirectory(bool insertFirst = false)
        {
            AddAssemblyDirectory(Assembly.GetExecutingAssembly(), insertFirst);
        }

        /// <summary>
        /// Adds the directory of the entry assembly to the collection.
        /// </summary>
        /// <param name="insertFirst">If true, inserts the directory at the first position in the collection; otherwise, appends it to the end.</param>
        /// <remarks>
        /// This method retrieves the directory of the entry assembly (the application entry point) and adds it to the collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// folder.AddEntryAssemblyDirectory();
        /// </code>
        /// </example>
        public void AddEntryAssemblyDirectory(bool insertFirst = false)
        {
            AddAssemblyDirectory(Assembly.GetEntryAssembly(), insertFirst);
        }

        /// <summary>
        /// Adds the directory of the specified assembly to the collection.
        /// </summary>
        /// <param name="assembly">The assembly whose directory is to be added. Must not be null.</param>
        /// <param name="insertFirst">If true, inserts the directory at the first position in the collection; otherwise, appends it to the end.</param>
        /// <remarks>
        /// This method retrieves the directory of the specified assembly and adds it to the collection.
        /// </remarks>
        /// <exception cref="InvalidOperationException">
        /// Thrown if the assembly is dynamic or has no location.
        /// </exception>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// Assembly assembly = Assembly.GetExecutingAssembly();
        /// folder.AddAssemblyDirectory(assembly);
        /// </code>
        /// </example>
        public void AddAssemblyDirectory(Assembly assembly, bool insertFirst = false)
        {

            if (assembly.IsDynamic
                || assembly.Location == null
                || assembly.Location == string.Empty)
                throw new InvalidOperationException("The assembly is dynamic or has no location.");

            AddDirectory(new FileInfo(assembly.Location).Directory, insertFirst);

        }

        /// <summary>
        /// Adds the specified directory to the collection if it exists.
        /// </summary>
        /// <param name="path">The path of the directory to add. Must not be null or empty.</param>
        /// <param name="insertFirst">If true, inserts the directory at the first position in the collection; otherwise, appends it to the end.</param>
        /// <remarks>
        /// This method checks if the specified directory exists and adds it to the collection if it does.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// folder.AddDirectoryIfExists("C:\\MyConfigs");
        /// </code>
        /// </example>
        public void AddDirectoryIfExists(string path, bool insertFirst = false)
        {
            AddDirectoryIfExists(new DirectoryInfo(path), insertFirst);
        }

        /// <summary>
        /// Adds the specified directory to the collection if it exists.
        /// </summary>
        /// <param name="folder">The directory to add.</param>
        /// <param name="insertFirst">Insert item in the first position.</param>
        /// <remarks>
        /// This method checks if the specified directory exists and adds it to the collection if it does.
        /// </remarks>
        public void AddDirectoryIfExists(DirectoryInfo folder, bool insertFirst = false)
        {
            folder.Refresh();
            if (folder.Exists)
                Add(folder, insertFirst);
        }

        /// <summary>
        /// Adds the specified directory to the collection.
        /// </summary>
        /// <param name="folder">The path of the directory to add. Must not be null or empty.</param>
        /// <param name="insertFirst">Insert item in the first position.</param>
        /// <remarks>
        /// This method adds a directory to the collection without checking if it exists.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// ConfigurationFolder.AddDirectory("C:\\MyConfigs");
        /// </code>
        /// </example>
        public void AddDirectory(string folder, bool insertFirst = false)
        {
            AddDirectory(new DirectoryInfo(folder), true);
        }

        /// <summary>
        /// Adds the specified directory to the collection.
        /// </summary>
        /// <param name="folder">The directory to add. Must not be null.</param>
        /// <param name="insertFirst">Insert item in the first position.</param>
        /// <remarks>
        /// This method adds a directory to the collection without checking if it exists.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var directory = new DirectoryInfo("C:\\MyConfigs");
        /// ConfigurationFolder.AddDirectory(directory);
        /// </code>
        /// </example>
        public void AddDirectory(DirectoryInfo folder, bool insertFirst = false)
        {
            Add(folder, insertFirst);
        }

        /// <summary>
        /// Gets an array of paths for all the directories in the collection.
        /// </summary>
        /// <returns>
        /// An array of paths for all the directories in the collection.
        /// </returns>
        /// <remarks>
        /// This method retrieves the full paths of all directories currently in the collection.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// string[] paths = folder.GetPaths();
        /// foreach (var path in paths)
        /// {
        ///     Console.WriteLine(path);
        /// }
        /// </code>
        /// </example>
        public string[] GetPaths()
        {
            List<string> result = new List<string>();

            foreach (var item in _list)
                result.Add(item.FullName);

            return result.ToArray();
        }

        /// <summary>
        /// Retrieves all files matching the specified search pattern from the directories in the collection.
        /// </summary>
        /// <param name="searchPattern">The search pattern to match file names (e.g., "*.txt"). Must not be null or empty.</param>
        /// <returns>
        /// A collection of <see cref="FileInfo"/> objects representing the matching files.
        /// </returns>
        /// <remarks>
        /// This method searches all directories in the collection for files matching the specified search pattern.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var folder = new ContentFolder("MyFolder");
        /// IEnumerable&lt;FileInfo&gt; files = folder.GetFiles("*.config");
        /// foreach (var file in files)
        /// {
        ///     Console.WriteLine(file.FullName);
        /// }
        /// </code>
        /// </example>
        public IEnumerable<FileInfo> GetFiles(string searchPattern)
        {
            List<FileInfo> result = new List<FileInfo>();
            foreach (var item in _list)
                result.AddRange(item.GetFiles(searchPattern));
            return result;
        }

        private void Add(DirectoryInfo folder, bool insertFirst)
        {
            var f = folder.FullName;
            if (!_list.Any(c => c.FullName == f))
                lock (_lock)
                    if (!_list.Contains(folder))
                    {
                        if (insertFirst)
                            _list.Insert(0, folder);
                        else
                            _list.Add(folder);
                    }
        }


        internal void Append<T>(T content, string filename)
            where T : class
        {
            var key = GlobalConfiguration.GetFilename(typeof(T));
            filename = Path.Combine(this._list[0].FullName, filename);
            filename.SerializeAndSaveConfiguration<T>(key, content);
        }

        internal T GetDocument<T>(string filename) where T : class
        {
            var files = this.GetFiles(filename).ToList();
            if (files.Count == 0)
                return null;
            
            var key = GlobalConfiguration.GetFilename(typeof(T));
            var content = files[0].LoadFromFileAndDeserializesConfiguration<T>(key);
            
            return content;

        }

        /// <summary>
        /// Gets the name of the content folder.
        /// </summary>
        /// <value>
        /// A <see cref="string"/> representing the name of the content folder.
        /// </value>
        /// <remarks>
        /// This property holds the name assigned to the content folder during initialization.
        /// </remarks>
        public string Name { get; }


        public bool Any => _list.Any();


        private readonly List<DirectoryInfo> _list;
        private static object _lock = new object();


    }

}

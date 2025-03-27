using System.IO;
using System.Text;

namespace Bb
{
    /// <summary>
    /// Provides extension methods for the <see cref="FileInfo"/> class.
    /// </summary>
    public static class FileInfoExtension
    {

        /// <summary>
        /// Write content to a file
        /// </summary>
        /// <param name="self">file to write</param>
        /// <param name="content">content to write</param>
        /// <param name="encoding">The encoding to use when writing the file. If null, defaults to UTF-8.</param>
        /// <returns>The FileInfo instance that was written to, enabling method chaining.</returns>
        /// <remarks>
        /// This method writes the specified content to the file represented by the FileInfo object.
        /// If the file already exists, it will be overwritten.
        /// If the file doesn't exist, it will be created.
        /// </remarks>
        /// <exception cref="IOException">An I/O error occurs while opening or writing to the file.</exception>
        /// <exception cref="UnauthorizedAccessException">The caller doesn't have the required permission.</exception>
        /// <exception cref="DirectoryNotFoundException">The specified path is invalid, such as being on an unmapped drive.</exception>
        /// <exception cref="System.Security.SecurityException">The caller doesn't have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create a new file and write content to it
        /// var file = new FileInfo("example.txt");
        /// file.WriteFile("Hello, World!"); // Uses default UTF-8 encoding
        /// 
        /// // Using specific encoding
        /// file.WriteFile("Hello with encoding!", Encoding.ASCII);
        /// 
        /// // Method chaining example
        /// file.WriteFile("New content").Refresh();
        /// </code>
        /// </example>
        public static FileInfo WriteFile(this FileInfo self, string content, Encoding encoding = null)
        {
            File.WriteAllText(self.FullName, content, encoding ?? Encoding.UTF8);
            return self;
        }
    }
}
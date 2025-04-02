using System;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace Bb
{

    public static class DirectoryInfoExtension
    {

        static DirectoryInfoExtension()
        {
            _pathComparer = new PathComparer();
        }


        /// <summary>
        /// get the directory of the assembly
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static DirectoryInfo GetDirectory(this Assembly self)
        {

            if (!self.IsDynamic && !string.IsNullOrEmpty(self.Location))
                return new FileInfo(self.Location).Directory;

            return null;

        }

        /// <summary>
        /// Determines if a file path is absolute.
        /// </summary>
        /// <param name="path">The file path to check. Can be null or empty.</param>
        /// <returns>
        /// <see langword="true"/> if the path is absolute; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method checks if the given path is an absolute file path by creating a FileInfo object
        /// and comparing the original path with the FullName property.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Check if a path is absolute
        /// string path1 = @"C:\temp\file.txt";
        /// bool isAbsolute1 = path1.FilePathIsAbsolute(); // Returns true
        /// 
        /// string path2 = "file.txt";
        /// bool isAbsolute2 = path2.FilePathIsAbsolute(); // Returns false
        /// </code>
        /// </example>
        public static bool FilePathIsAbsolute(this string path)
        {

            if (!string.IsNullOrEmpty(path))
            {
                var f = path.AsFile();
                if (f.FullName == path)
                    return true;
            }

            return false;

        }


        /// <summary>
        /// Determines if a directory path is absolute.
        /// </summary>
        /// <param name="path">The directory path to check. Can be null or empty.</param>
        /// <returns>
        /// <see langword="true"/> if the path is absolute; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method checks if the given path is an absolute directory path by creating a DirectoryInfo object
        /// and comparing the original path with the FullName property.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Check if a path is absolute
        /// string path1 = @"C:\temp\";
        /// bool isAbsolute1 = path1.DirectoryPathIsAbsolute(); // Returns true
        /// 
        /// string path2 = "temp";
        /// bool isAbsolute2 = path2.DirectoryPathIsAbsolute(); // Returns false
        /// </code>
        /// </example>
        public static bool DirectoryPathIsAbsolute(this string path)
        {

            if (!string.IsNullOrEmpty(path))
            {
                var f = path.AsDirectory();
                if (f.FullName == path)
                    return true;
            }

            return false;

        }


        /// <summary>
        /// Writes content to a file in the specified directory.
        /// </summary>
        /// <param name="self">The directory where the file will be created or updated.</param>
        /// <param name="filename">The name of the file to write to. Must not be null or empty.</param>
        /// <param name="content">The content to write to the file.</param>
        /// <param name="encoding">The encoding to use when writing the file. If null, defaults to UTF-8.</param>
        /// <returns>
        /// The <see cref="DirectoryInfo"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method creates or updates a file with the specified filename within the directory.
        /// The file will be created if it doesn't exist, or overwritten if it already exists.
        /// The content is written to the file using the specified encoding or UTF-8 if no encoding is provided.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory (self) or filename is null.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs while writing to the file.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller doesn't have the required permission.</exception>
        /// <exception cref="DirectoryNotFoundException">Thrown when the specified directory path is invalid.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Write content to a file in a directory
        /// var directory = new DirectoryInfo(@"C:\temp");
        /// directory.WriteFile("example.txt", "Hello World!");
        /// 
        /// // With specific encoding
        /// directory.WriteFile("example2.txt", "Hello World!", Encoding.ASCII);
        /// 
        /// // With method chaining
        /// directory.WriteFile("example3.txt", "Hello World!").CreateFolderIfNotExists();
        /// </code>
        /// </example>
        public static DirectoryInfo WriteFile(this DirectoryInfo self, string filename, string content, Encoding encoding = null)
        {
            var file = self.Combine(filename).AsFile();
            file.WriteFile(content, encoding);
            return self;

        }


        /// <summary>
        /// Combines a DirectoryInfo path with additional path segments.
        /// </summary>
        /// <param name="self">The base directory. Must not be null.</param>
        /// <param name="segments">The additional path segments to combine with the base directory.</param>
        /// <returns>
        /// A <see cref="string"/> representing the combined path.
        /// </returns>
        /// <remarks>
        /// This method creates a combined path by using the FullName of the DirectoryInfo and appending
        /// the provided path segments using Path.Combine.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory (self) is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Combine directory with path segments
        /// var directory = new DirectoryInfo(@"C:\temp");
        /// string path = directory.Combine("subfolder", "file.txt"); // Returns "C:\temp\subfolder\file.txt"
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Combine(this DirectoryInfo self, params string[] segments)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            var lst = new string[segments.Length + 1];
            lst[0] = self.FullName;
            segments.CopyTo(lst, 1);
            return Path.Combine(lst);
        }

        /// <summary>
        /// Combines a string path with additional path segments.
        /// </summary>
        /// <param name="self">The base path. Must not be null or empty.</param>
        /// <param name="segments">The additional path segments to combine with the base path.</param>
        /// <returns>
        /// A <see cref="string"/> representing the combined path.
        /// </returns>
        /// <remarks>
        /// This method creates a combined path by appending the provided path segments to the base path
        /// using Path.Combine.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the base path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Combine path with additional segments
        /// string basePath = @"C:\temp";
        /// string path = basePath.Combine("subfolder", "file.txt"); // Returns "C:\temp\subfolder\file.txt"
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Combine(this string self, params string[] segments)
        {

            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            var lst = new string[segments.Length + 1];
            lst[0] = self;
            segments.CopyTo(lst, 1);
            return Path.Combine(lst);
        }



        /// <summary>
        /// Converts a string path to a FileInfo object.
        /// </summary>
        /// <param name="self">The file path to convert. Must not be null or empty.</param>
        /// <param name="format">If true, formats the path before creating the FileInfo object.</param>
        /// <returns>
        /// A <see cref="FileInfo"/> object representing the file path.
        /// </returns>
        /// <remarks>
        /// This method creates a FileInfo object from a string path. If format is true, 
        /// the path is normalized using FormatPath before creating the FileInfo.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Convert string path to FileInfo
        /// string path = @"C:\temp\file.txt";
        /// FileInfo fileInfo = path.AsFile();
        /// 
        /// // Without formatting
        /// FileInfo fileInfo2 = path.AsFile(format: false);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this string self, bool format = true)
        {
            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            if (format)
                self = self.FormatPath();

            return new FileInfo(self);
        }

        /// <summary>
        /// Creates a FileInfo object for a file in the specified directory.
        /// </summary>
        /// <param name="self">The directory containing the file. Must not be null.</param>
        /// <param name="filename">The name of the file.</param>
        /// <param name="format">If true, formats the combined path before creating the FileInfo object.</param>
        /// <returns>
        /// A <see cref="FileInfo"/> object representing the file in the directory.
        /// </returns>
        /// <remarks>
        /// This method combines the directory path with the filename, then creates a FileInfo object 
        /// from the combined path. If format is true, the path is normalized using FormatPath.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory is null or the filename is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Get FileInfo for a file in a directory
        /// var directory = new DirectoryInfo(@"C:\temp");
        /// FileInfo fileInfo = directory.AsFile("example.txt");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this DirectoryInfo self, string filename, bool format = true)
        {
            return self.Combine(filename).AsFile(format);
        }


        /// <summary>
        /// Creates a FileInfo object for a file in the specified directory path.
        /// </summary>
        /// <param name="self">The directory path containing the file. Must not be null or empty.</param>
        /// <param name="filename">The name of the file.</param>
        /// <param name="format">If true, formats the combined path before creating the FileInfo object.</param>
        /// <returns>
        /// A <see cref="FileInfo"/> object representing the file in the directory.
        /// </returns>
        /// <remarks>
        /// This method combines the directory path with the filename, then creates a FileInfo object 
        /// from the combined path. If format is true, the path is normalized using FormatPath.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory path is null or empty, or when the filename is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Get FileInfo for a file in a directory
        /// string dirPath = @"C:\temp";
        /// FileInfo fileInfo = dirPath.AsFile("example.txt");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this string self, string filename, bool format = true)
        {
            return self.Combine(filename).AsFile(format);
        }



        /// <summary>
        /// Converts a string path to a DirectoryInfo object.
        /// </summary>
        /// <param name="self">The directory path to convert. Must not be null or empty.</param>
        /// <param name="format">If true, formats the path before creating the DirectoryInfo object.</param>
        /// <returns>
        /// A <see cref="DirectoryInfo"/> object representing the directory path.
        /// </returns>
        /// <remarks>
        /// This method creates a DirectoryInfo object from a string path. If format is true, 
        /// the path is normalized using FormatPath before creating the DirectoryInfo.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Convert string path to DirectoryInfo
        /// string path = @"C:\temp";
        /// DirectoryInfo dirInfo = path.AsDirectory();
        /// 
        /// // Without formatting
        /// DirectoryInfo dirInfo2 = path.AsDirectory(format: false);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo AsDirectory(this string self, bool format = true)
        {
            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));
            if (format)
                self = self.FormatPath();
            return new DirectoryInfo(self);
        }


        /// <summary>
        /// Creates a directory from a string path if it doesn't exist.
        /// </summary>
        /// <param name="self">The directory path to check and create. Must not be null or empty.</param>
        /// <param name="format">If true, formats the path before creating the DirectoryInfo object.</param>
        /// <returns>
        /// A <see cref="DirectoryInfo"/> object representing the directory.
        /// </returns>
        /// <remarks>
        /// This method converts the string path to a DirectoryInfo object and then creates
        /// the directory if it doesn't exist. The format parameter determines whether to normalize
        /// the path using FormatPath before creating the DirectoryInfo.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create a directory if it doesn't exist from a string path
        /// string path = @"C:\temp\newFolder";
        /// DirectoryInfo directory = path.CreateFolderIfNotExists();
        /// 
        /// // Without formatting
        /// DirectoryInfo directory2 = path.CreateFolderIfNotExists(format: false);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo CreateFolderIfNotExists(this string self, bool format = true)
        {
            return self.AsDirectory(format).CreateFolderIfNotExists();
        }


        /// <summary>
        /// Deletes a directory if it exists.
        /// </summary>
        /// <param name="self">The directory path to check and delete. Must not be null or empty.</param>
        /// <param name="recursive">If true, removes all files and subdirectories recursively; otherwise, the directory must be empty to be removed.</param>
        /// <returns>
        /// A <see cref="DirectoryInfo"/> object representing the directory.
        /// </returns>
        /// <remarks>
        /// This method converts the string path to a DirectoryInfo object and then deletes
        /// the directory if it exists. The recursive parameter determines whether to delete
        /// all contents recursively or require an empty directory.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the path is null or empty.</exception>
        /// <exception cref="IOException">Thrown when the directory is not empty and recursive is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the user does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Delete a directory if it exists
        /// string path = @"C:\temp\oldFolder";
        /// DirectoryInfo directory = path.DeleteFolderIfExists();
        /// 
        /// // Delete recursively
        /// string path2 = @"C:\temp\oldFolderWithContents";
        /// DirectoryInfo directory2 = path2.DeleteFolderIfExists(recursive: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo DeleteFolderIfExists(this string self, bool recursive = false)
        {

            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            return self.AsDirectory().DeleteFolderIfExists(recursive);
        }


        /// <summary>
        /// Creates the directory if it doesn't exist.
        /// </summary>
        /// <param name="self">The directory to check and create. Must not be null.</param>
        /// <returns>
        /// The <see cref="DirectoryInfo"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method checks if the specified directory exists and creates it if it doesn't.
        /// It calls Refresh() to ensure the DirectoryInfo reflects the current state of the directory
        /// before checking existence and after creating the directory.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory (self) is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create a directory if it doesn't exist
        /// var directory = new DirectoryInfo(@"C:\temp\newFolder");
        /// directory.CreateFolderIfNotExists();
        /// 
        /// // Method chaining example
        /// var dir = new DirectoryInfo(@"C:\temp\project")
        ///     .CreateFolderIfNotExists()
        ///     .WriteFile("example.txt", "Hello World!");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo CreateFolderIfNotExists(this DirectoryInfo self)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.Refresh();
            if (!self.Exists)
                self.Create();
            return self;
        }


        /// <summary>
        /// Deletes a directory if it exists.
        /// </summary>
        /// <param name="self">The directory to check and delete. Must not be null.</param>
        /// <param name="recursive">If true, removes all files and subdirectories recursively; otherwise, the directory must be empty to be removed.</param>
        /// <returns>
        /// The <see cref="DirectoryInfo"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method checks if the specified directory exists and deletes it if it does.
        /// It calls Refresh() to ensure the DirectoryInfo reflects the current state of the directory
        /// before checking existence and after deleting the directory.
        /// The recursive parameter determines whether to delete all contents recursively or require an empty directory.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the directory (self) is null.</exception>
        /// <exception cref="IOException">Thrown when the directory is not empty and recursive is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the user does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Delete a directory if it exists
        /// var directory = new DirectoryInfo(@"C:\temp\oldFolder");
        /// directory.DeleteFolderIfExists();
        /// 
        /// // Delete recursively
        /// var directory2 = new DirectoryInfo(@"C:\temp\oldFolderWithContents");
        /// directory2.DeleteFolderIfExists(recursive: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo DeleteFolderIfExists(this DirectoryInfo self, bool recursive = false)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            self.Refresh();
            if (self.Exists)
            {
                self.Delete(recursive);
                self.Refresh();
            }
            return self;
        }


        /// <summary>
        /// Copies a file to the specified target directory.
        /// </summary>
        /// <param name="self">The file to copy. Must not be null.</param>
        /// <param name="directoryTargetPath">The target directory path where the file will be copied. Must not be null or empty.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file to the specified target directory while preserving the original filename.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the file (self) is null or the target directory path is null or empty.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file to a target directory
        /// var file = new FileInfo(@"C:\source\document.txt");
        /// bool success = file.CopyToDirectory(@"C:\target");
        /// 
        /// // Overwrite existing file
        /// bool success2 = file.CopyToDirectory(@"C:\target", overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CopyToDirectory(this FileInfo self, string directoryTargetPath, bool overwrite = false)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (string.IsNullOrEmpty(directoryTargetPath))
                throw new ArgumentNullException(nameof(directoryTargetPath));

            self.Refresh();

            if (!self.Exists)
                return false;

            var filename = self.Name;
            var fileTarget = directoryTargetPath.Combine(filename);
            var target = self.CopyTo(fileTarget, overwrite);

            target.Refresh();

            return target.Exists;

        }


        /// <summary>
        /// Copies a file to the specified target directory.
        /// </summary>
        /// <param name="self">The file to copy. Must not be null.</param>
        /// <param name="directoryTargetPath">The target directory where the file will be copied. Must not be null.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file to the specified target directory while preserving the original filename.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the file (self) is null or the target directory is null.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file to a target directory
        /// var file = new FileInfo(@"C:\source\document.txt");
        /// var targetDir = new DirectoryInfo(@"C:\target");
        /// bool success = file.CopyToDirectory(targetDir);
        /// 
        /// // Overwrite existing file
        /// bool success2 = file.CopyToDirectory(targetDir, overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CopyToDirectory(this FileInfo self, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (directoryTargetPath == null)
                throw new ArgumentNullException(nameof(directoryTargetPath));

            if (!self.Exists)
                return false;

            var filename = self.Name;
            var fileTarget = directoryTargetPath.Combine(filename);
            var target = self.CopyTo(fileTarget, overwrite);

            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copies a file from the source directory to a target directory.
        /// </summary>
        /// <param name="self">The source directory path. Must not be null or empty.</param>
        /// <param name="filename">The name of the file to copy. Must not be null or empty.</param>
        /// <param name="directoryTargetPath">The target directory where the file will be copied. Must not be null.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file specified by filename from the source directory to the target directory.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the source directory path or filename is null or empty, or the target directory is null.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file from a source directory to a target directory
        /// string sourceDir = @"C:\source";
        /// var targetDir = new DirectoryInfo(@"C:\target");
        /// bool success = sourceDir.Copy("document.txt", targetDir);
        /// 
        /// // Overwrite existing file
        /// bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Copy(this string self, string filename, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {

            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException(nameof(filename));

            if (directoryTargetPath == null)
                throw new ArgumentNullException(nameof(directoryTargetPath));

            var fileSource = self.Combine(filename).AsFile();

            if (!fileSource.Exists)
                return false;

            var fileTarget = directoryTargetPath.Combine(filename);
            var target = fileSource.CopyTo(fileTarget, overwrite);
            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copies a file from the source directory to a target directory.
        /// </summary>
        /// <param name="self">The source directory. Must not be null.</param>
        /// <param name="filename">The name of the file to copy. Must not be null or empty.</param>
        /// <param name="directoryTargetPath">The target directory where the file will be copied. Must not be null.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file specified by filename from the source directory to the target directory.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the source directory, filename, or target directory is null.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file from a source directory to a target directory
        /// var sourceDir = new DirectoryInfo(@"C:\source");
        /// var targetDir = new DirectoryInfo(@"C:\target");
        /// bool success = sourceDir.Copy("document.txt", targetDir);
        /// 
        /// // Overwrite existing file
        /// bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Copy(this DirectoryInfo self, string filename, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException(nameof(filename));

            if (directoryTargetPath == null)
                throw new ArgumentNullException(nameof(directoryTargetPath));

            var fileSource = self.Combine(filename).AsFile();

            if (!fileSource.Exists)
                return false;

            var fileTarget = directoryTargetPath.Combine(filename);
            var target = fileSource.CopyTo(fileTarget, overwrite);
            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copies a file from the source directory to a target directory path.
        /// </summary>
        /// <param name="self">The source directory. Must not be null.</param>
        /// <param name="filename">The name of the file to copy. Must not be null or empty.</param>
        /// <param name="directoryTargetPath">The target directory path where the file will be copied. Must not be null or empty.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file specified by filename from the source directory to the target directory path.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the source directory is null, or filename or target directory path is null or empty.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file from a source directory to a target directory path
        /// var sourceDir = new DirectoryInfo(@"C:\source");
        /// bool success = sourceDir.Copy("document.txt", @"C:\target");
        /// 
        /// // Overwrite existing file
        /// bool success2 = sourceDir.Copy("document.txt", @"C:\target", overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Copy(this DirectoryInfo self, string filename, string directoryTargetPath, bool overwrite = false)
        {

            if (self == null)
                throw new ArgumentNullException(nameof(self));

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException(nameof(filename));

            if (string.IsNullOrEmpty(directoryTargetPath))
                throw new ArgumentNullException(nameof(directoryTargetPath));

            var fileSource = self.Combine(filename).AsFile();

            if (!fileSource.Exists)
                return false;

            var fileTarget = directoryTargetPath.Combine(filename);
            var target = fileSource.CopyTo(fileTarget, overwrite);
            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copies a file from a source directory path to a target directory path.
        /// </summary>
        /// <param name="self">The source directory path. Must not be null or empty.</param>
        /// <param name="filename">The name of the file to copy. Must not be null or empty.</param>
        /// <param name="directoryTargetPath">The target directory path where the file will be copied. Must not be null or empty.</param>
        /// <param name="overwrite">If true, overwrites the destination file if it exists.</param>
        /// <returns>
        /// <see langword="true"/> if the file was successfully copied; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method copies a file specified by filename from the source directory path to the target directory path.
        /// It returns false if the source file doesn't exist. After copying, it refreshes the target file
        /// information to ensure it reflects the current state of the file system.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when any of the parameters (self, filename, directoryTargetPath) is null or empty.</exception>
        /// <exception cref="IOException">Thrown when an I/O error occurs during the copy operation or the destination file exists and overwrite is false.</exception>
        /// <exception cref="UnauthorizedAccessException">Thrown when the caller does not have the required permission.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Copy a file from a source directory path to a target directory path
        /// string sourceDir = @"C:\source";
        /// string targetDir = @"C:\target";
        /// bool success = sourceDir.Copy("document.txt", targetDir);
        /// 
        /// // Overwrite existing file
        /// bool success2 = sourceDir.Copy("document.txt", targetDir, overwrite: true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool Copy(this string self, string filename, string directoryTargetPath, bool overwrite = false)
        {

            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentNullException(nameof(filename));

            if (string.IsNullOrEmpty(directoryTargetPath))
                throw new ArgumentNullException(nameof(directoryTargetPath));

            var fileSource = self.Combine(filename).AsFile();

            if (!fileSource.Exists)
                return false;

            var fileTarget = directoryTargetPath.Combine(filename);
            var target = fileSource.CopyTo(fileTarget, overwrite);
            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Compares two DirectoryInfo objects to check if they represent the same path.
        /// </summary>
        /// <param name="path1">The first DirectoryInfo to compare. Must not be null.</param>
        /// <param name="path2">The second DirectoryInfo to compare. Must not be null.</param>
        /// <returns>
        /// <see langword="true"/> if the paths are equal according to the path comparer; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method compares the full paths of the two DirectoryInfo objects using a path comparer
        /// that is platform-aware and handles case sensitivity according to the current operating system.
        /// On Windows, the comparison is case-insensitive, while on Unix-based systems it is case-sensitive.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when either path1 or path2 is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Compare two directory paths
        /// var dir1 = new DirectoryInfo(@"C:\temp");
        /// var dir2 = new DirectoryInfo(@"C:\Temp");
        /// bool areEqual = dir1.IsPathEquals(dir2); // On Windows, returns true due to case insensitivity
        /// </code>
        /// </example>
        public static bool IsPathEquals(this DirectoryInfo path1, DirectoryInfo path2)
        {
            return _pathComparer.Equals(path1.FullName, path2.FullName);
        }

        /// <summary>
        /// Compares two FileInfo objects to check if they represent the same path.
        /// </summary>
        /// <param name="path1">The first FileInfo to compare. Must not be null.</param>
        /// <param name="path2">The second FileInfo to compare. Must not be null.</param>
        /// <returns>
        /// <see langword="true"/> if the paths are equal according to the path comparer; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method compares the full paths of the two FileInfo objects using a path comparer
        /// that is platform-aware and handles case sensitivity according to the current operating system.
        /// On Windows, the comparison is case-insensitive, while on Unix-based systems it is case-sensitive.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when either path1 or path2 is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Compare two file paths
        /// var file1 = new FileInfo(@"C:\temp\file.txt");
        /// var file2 = new FileInfo(@"C:\Temp\File.txt");
        /// bool areEqual = file1.IsPathEquals(file2); // On Windows, returns true due to case insensitivity
        /// </code>
        /// </example>
        public static bool IsPathEquals(this FileInfo path1, FileInfo path2)
        {
            return _pathComparer.Equals(path1.FullName, path2.FullName);
        }


        /// <summary>
        /// Compares two string paths to check if they represent the same path.
        /// </summary>
        /// <param name="path1">The first path to compare. Must not be null or empty.</param>
        /// <param name="path2">The second path to compare. Must not be null or empty.</param>
        /// <returns>
        /// <see langword="true"/> if the paths are equal after normalization; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method first normalizes both paths using FormatPath, then compares them using a path comparer
        /// that is platform-aware and handles case sensitivity appropriately. The normalization process
        /// resolves relative paths, removes trailing separators, and adjusts case according to the platform.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when either path1 or path2 is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Compare two string paths
        /// string path1 = @"C:\temp\file.txt";
        /// string path2 = @"C:\Temp\File.txt";
        /// bool areEqual = path1.IsPathEquals(path2); // On Windows, returns true due to case insensitivity
        /// 
        /// // Compare with relative path
        /// string path3 = @".\temp\file.txt";
        /// bool areEqual2 = path1.IsPathEquals(path3); // Returns true if paths resolve to same location
        /// </code>
        /// </example>
        public static bool IsPathEquals(this string path1, string path2)
        {
            return _pathComparer.Equals(path1.FormatPath(), path2.FormatPath());
        }


        /// <summary>
        /// Formats a file or directory path to a standard format.
        /// </summary>
        /// <param name="self">The path to format. Must not be null or empty.</param>
        /// <returns>
        /// A <see cref="string"/> containing the formatted path.
        /// </returns>
        /// <remarks>
        /// This method standardizes paths by:
        /// 1. Converting URI file paths to local file system paths
        /// 2. Unescaping URI-encoded characters
        /// 3. Converting to absolute path format
        /// 4. Trimming trailing directory separators
        /// 5. Converting to lowercase on Windows platforms for case-insensitive comparison
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the path is null or empty.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Format various paths
        /// string path1 = "file:///C:/temp/my%20folder/";
        /// string formatted1 = path1.FormatPath(); // Returns "c:\temp\my folder" on Windows
        /// 
        /// string path2 = @".\relative\path";
        /// string formatted2 = path2.FormatPath(); // Returns full path with relative portion resolved
        /// 
        /// string path3 = @"C:\TEMP\";
        /// string formatted3 = path3.FormatPath(); // Returns "c:\temp" on Windows (lowercase, no trailing separator)
        /// </code>
        /// </example>
        public static string FormatPath(this string self)
        {

            if (string.IsNullOrEmpty(self))
                throw new ArgumentNullException(nameof(self));

            if (self.StartsWith("file:///"))
                self = new Uri(self).LocalPath;

            self = Uri.UnescapeDataString(self);

            self = Path.GetFullPath(self).TrimEnd(Path.DirectorySeparatorChar);

            if (RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
                self = self.ToLowerInvariant();

            return self;

        }

        private static readonly PathComparer _pathComparer;


    }

}
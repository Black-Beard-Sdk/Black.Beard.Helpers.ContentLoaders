using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Bb
{

    public static class DirectoryInfoExtension
    {

        static DirectoryInfoExtension()
        {
            _pathComparer = new PathComparer();
        }

        /// <summary>
        /// return true if the file path is absolute
        /// </summary>
        /// <param name="path">path to evaluate</param>
        /// <example>
        /// <code lang="csharp">
        ///     if("file".FilePathIsAbsolute())
        ///     {
        ///     }
        /// </code>
        /// </example>
        /// <returns>true if the path is absolute form</returns>
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
        /// return true if the directory path is absolute
        /// </summary>
        /// <param name="path">path to evaluate</param>
        /// <returns>true if the path is absolute form</returns>
        /// <example>
        /// <code lang="csharp">
        ///     if("directory".DirectoryPathIsAbsolute())
        ///     {
        ///     }
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
        /// Concatenate the directory with the segments
        /// </summary>
        /// <param name="self">root directory path</param>
        /// <param name="segments">segments to add</param>
        /// <returns>the concatenated path</returns>
        /// <example>
        /// <code lang="csharp">
        /// new DirectoryInfo("c:\\temp").Combine("subfolder1", "subfolder2", "subfolder3");
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
        /// Concatenate the directory path with the segments
        /// </summary>
        /// <param name="self">first segment</param>
        /// <param name="segments">segments to add</param>
        /// <returns>the concatenated path</returns>
        /// <example>
        /// <code lang="csharp">
        /// var path = "c:\\temp".Combine("subfolder1", "subfolder2", "subfolder3");
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
        /// Convert text to file info
        /// </summary>
        /// <param name="self">full path filename</param>
        /// <param name="format">format the path</param>
        /// <returns>the <see cref="FileInfo"/> </returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\file.cs".AsFile();
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
        /// Return a file from a directory and specified filename
        /// </summary>
        /// <param name="self">file to copy in the target folder</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="format">format the path</param>
        /// <returns>the <see cref="FileInfo"/> </returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\".AsDirectory().AsFile("filename.cs");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this DirectoryInfo self, string filename, bool format = true)
        {
            return self.Combine(filename).AsFile(format);
        }

        /// <summary>
        /// Return a file from a directory and specified filename
        /// </summary>
        /// <param name="self">file to copy in the target folder</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="format">format the path</param>
        /// <returns>the <see cref="FileInfo"/> </returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\".AsFile("filename.cs");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this string self, string filename, bool format = true)
        {
            return self.Combine(filename).AsFile(format);
        }



        /// <summary>
        /// Convert text to directory
        /// </summary>
        /// <param name="self">full path directory name</param>
        /// <param name="format">format the path</param>
        /// <returns>the <see cref="DirectoryInfo"/> </returns>
        /// <example>
        /// <code lang="csharp">
        /// var directory = "c:\\temp\\".AsDirectory();
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
        /// Create the directory if not exists
        /// </summary>
        /// <param name="self">folder path</param>
        /// <param name="format">format the path</param>
        /// <returns>source folder to create</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".CreateFolderIfNotExists();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo CreateFolderIfNotExists(this string self, bool format = true)
        {
            return self.AsDirectory(format).CreateFolderIfNotExists();
        }

        /// <summary>
        /// Delete the directory if exists
        /// </summary>
        /// <param name="self">folder path</param>
        /// <param name="recursive">delete all children</param>
        /// <returns>source folder to delete</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".DeleteFolderIfExists();
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
        /// Create the directory if not exists
        /// </summary>
        /// <param name="self">folder path</param>
        /// <returns>source folder to create</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".AsDirectory().CreateFolderIfNotExists();
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
        /// Delete the directory if not exists
        /// </summary>
        /// <param name="self">folder path</param>
        /// <param name="recursive">delete all children</param>
        /// <returns>source folder to delete</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".AsDirectory().DeleteFolderIfExists();
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">file to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path", true);
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">file to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path".AsDirectory(), true);
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">source directory where found the file</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp".Copy("target path".AsDirectory(), true);
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">source directory where found the file</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp".AsDirectory().Copy("filename", "target path".AsDirectory(), true);
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">source directory where found the file</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp".AsDirectory().Copy("filename", "target path", true);
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
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="self">source directory where found the file</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp".Copy("filename", "target path", true);
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
        /// Determines whether the specified directory paths are equal.
        /// </summary>
        /// <param name="path1">The first directory path.</param>
        /// <param name="path2">The second directory path.</param>
        /// <returns><see langword="true"/> if the specified paths are equal; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method compares the full names of the directories in a case-insensitive manner.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var dir1 = new DirectoryInfo("C:\\Path1");
        /// var dir2 = new DirectoryInfo("C:\\path1");
        /// bool areEqual = dir1.IsPathEquals(dir2);
        /// </code>
        /// </example>
        public static bool IsPathEquals(this DirectoryInfo path1, DirectoryInfo path2)
        {
            return _pathComparer.Equals(path1.FullName, path2.FullName);
        }

        /// <summary>
        /// Determines whether the specified file paths are equal.
        /// </summary>
        /// <param name="path1">The first file path.</param>
        /// <param name="path2">The second file path.</param>
        /// <returns><see langword="true"/> if the specified paths are equal; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method compares the full names of the files in a case-insensitive manner.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// var file1 = new FileInfo("C:\\Path1\\file.txt");
        /// var file2 = new FileInfo("C:\\path1\\FILE.TXT");
        /// bool areEqual = file1.IsPathEquals(file2);
        /// </code>
        /// </example>
        public static bool IsPathEquals(this FileInfo path1, FileInfo path2)
        {
            return _pathComparer.Equals(path1.FullName, path2.FullName);
        }

        /// <summary>
        /// Determines whether the specified string paths are equal.
        /// </summary>
        /// <param name="path1">The first string path.</param>
        /// <param name="path2">The second string path.</param>
        /// <returns><see langword="true"/> if the specified paths are equal; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method compares the formatted paths in a case-insensitive manner.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string path1 = "C:\\Path1";
        /// string path2 = "C:\\path1";
        /// bool areEqual = path1.IsPathEquals(path2);
        /// </code>
        /// </example>
        public static bool IsPathEquals(this string path1, string path2)
        {
            return _pathComparer.Equals(path1.FormatPath(), path2.FormatPath());
        }

        /// <summary>
        /// Formats the specified path to a standard format.
        /// </summary>
        /// <param name="self">The path to format.</param>
        /// <returns>The formatted path.</returns>
        /// <remarks>
        /// This method converts the path to a lower-case invariant string and removes URI encoding.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string path = "file:///C:/Path1";
        /// string formattedPath = path.FormatPath();
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

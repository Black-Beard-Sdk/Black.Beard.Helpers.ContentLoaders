using System;
using System.IO;
using System.Runtime.CompilerServices;

namespace Bb
{

    public static class DirectoryInfoExtension
    {


        /// <summary>
        /// Concatenate the directory with the segments
        /// </summary>
        /// <param name="self"></param>
        /// <param name="segments"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// new DirectoryInfo("c:\\temp").Combine("subfolder1", "subfolder2", "subfolder3");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Combine(this DirectoryInfo self, params string[] segments)
        {
            var lst = new string[segments.Length + 1];
            lst[0] = self.FullName;
            segments.CopyTo(lst, 1);
            return Path.Combine(lst);
        }

        /// <summary>
        /// Concatenate the directory path with the segments
        /// </summary>
        /// <param name="self">first segment</param>
        /// <param name="segments"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var path = "c:\\temp".Combine("subfolder1", "subfolder2", "subfolder3");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static string Combine(this string self, params string[] segments)
        {
            var lst = new string[segments.Length + 1];
            lst[0] = self;
            segments.CopyTo(lst, 1);
            return Path.Combine(lst);
        }



        /// <summary>
        /// Convert text to file info
        /// </summary>
        /// <param name="self">full path filename</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\file.cs".AsFile();
        /// </code>
        /// </example>  
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this string self)
        {
            return new FileInfo(self);
        }

        /// <summary>
        /// Return a file from a directory and specified filename
        /// </summary>
        /// <param name="sourceFilePath">file to copy in the target folder</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\".AsDirectory().AsFile("filename.cs");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this DirectoryInfo sourceFilePath, string filename)
        {
            return sourceFilePath.Combine(filename).AsFile();
        }

        /// <summary>
        /// Return a file from a directory and specified filename
        /// </summary>
        /// <param name="sourceFilePath">file to copy in the target folder</param>
        /// <param name="filename">filename to copy in the target folder</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var file = "c:\\temp\\".AsFile("filename.cs");
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static FileInfo AsFile(this string sourceFilePath, string filename)
        {
            return sourceFilePath.Combine(filename).AsFile();
        }



        /// <summary>
        /// Convert text to directory
        /// </summary>
        /// <param name="self">full path directory name</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var directory = "c:\\temp\\".AsDirectory();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo AsDirectory(this string self)
        {
            return new DirectoryInfo(self);
        }


        /// <summary>
        /// Create the directory if not exists
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".CreateFolderIfNotExists();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo CreateFolderIfNotExists(this string self)
        {
            return self.AsDirectory().CreateFolderIfNotExists();
        }

        /// <summary>
        /// Delete the directory if exists
        /// </summary>
        /// <param name="self"></param>
        /// <param name="recursive"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".DeleteFolderIfExists();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo DeleteFolderIfExists(this string self, bool recursive = false)
        {
            return self.AsDirectory().DeleteFolderIfExists(recursive);
        }

        /// <summary>
        /// Create the directory if not exists
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".AsDirectory().CreateFolderIfNotExists();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo CreateFolderIfNotExists(this DirectoryInfo self)
        {
            if (!self.Exists)
                self.Create();
            return self;
        }

        /// <summary>
        /// Delete the directory if not exists
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\".AsDirectory().DeleteFolderIfExists();
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static DirectoryInfo DeleteFolderIfExists(this DirectoryInfo self, bool recursive = false)
        {
            if (self.Exists)
                self.Delete(recursive);
            return self;
        }

        /// <summary>
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="sourceFilePath">file to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path", true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CopyToDirectory(this FileInfo sourceFilePath, string directoryTargetPath, bool overwrite = false)
        {

            if (!sourceFilePath.Exists)
                return false;

            var filename = sourceFilePath.Name;
            var fileTarget = directoryTargetPath.Combine(filename);
            var target = sourceFilePath.CopyTo(fileTarget, overwrite);

            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="sourceFilePath">file to copy in the target folder</param>
        /// <param name="directoryTargetPath">target directory to copy source file</param>
        /// <param name="overwrite">override file if already exists</param>
        /// <returns>return true if the copy is successfully</returns>
        /// <example>
        /// <code lang="csharp">
        /// "c:\\temp\\filename.cs".AsFile().CopyToDirectory("target path".AsDirectory(), true);
        /// </code>
        /// </example>
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        public static bool CopyToDirectory(this FileInfo sourceFilePath, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {

            if (!sourceFilePath.Exists)
                return false;

            var filename = sourceFilePath.Name;
            var fileTarget = directoryTargetPath.Combine(filename);
            var target = sourceFilePath.CopyTo(fileTarget, overwrite);

            target.Refresh();

            return target.Exists;

        }

        /// <summary>
        /// Copy the specified file to a directory
        /// </summary>
        /// <param name="sourceDirectoryPath">source directory where found the file</param>
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
        public static bool Copy(this string sourceDirectoryPath, string filename, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {

            var fileSource = sourceDirectoryPath.Combine(filename).AsFile();

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
        /// <param name="sourceDirectoryPath">source directory where found the file</param>
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
        public static bool Copy(this DirectoryInfo sourceDirectoryPath, string filename, DirectoryInfo directoryTargetPath, bool overwrite = false)
        {
            var fileSource = sourceDirectoryPath.Combine(filename).AsFile();

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
        /// <param name="sourceDirectoryPath">source directory where found the file</param>
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
        public static bool Copy(this DirectoryInfo sourceDirectoryPath, string filename, string directoryTargetPath, bool overwrite = false)
        {
            var fileSource = sourceDirectoryPath.Combine(filename).AsFile();

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
        /// <param name="sourceDirectoryPath">source directory where found the file</param>
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
        public static bool Copy(this string sourceDirectoryPath, string filename, string directoryTargetPath, bool overwrite = false)
        {

            var fileSource = sourceDirectoryPath.Combine(filename).AsFile();

            if (!fileSource.Exists)
                return false;

            var fileTarget = directoryTargetPath.Combine(filename);
            var target = fileSource.CopyTo(fileTarget, overwrite);
            target.Refresh();

            return target.Exists;

        }


    }


}

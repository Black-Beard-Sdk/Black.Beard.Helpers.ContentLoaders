using System;
using System.IO;

namespace Black.Beard.Helpers
{

    public static class DirectoryInfoExtension
    {

        /// <summary>
        /// Concatenate the directory with the segments
        /// </summary>
        /// <param name="self"></param>
        /// <param name="segments"></param>
        /// <returns></returns>
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
        public static FileInfo AsFile(this string self)
        {
            return new FileInfo(self);
        }

        /// <summary>
        /// Convert text to directory
        /// </summary>
        /// <param name="self">full path directory name</param>
        /// <returns></returns>
        public static DirectoryInfo AsDirectory(this string self)
        {
            return new DirectoryInfo(self);
        }

    }


}

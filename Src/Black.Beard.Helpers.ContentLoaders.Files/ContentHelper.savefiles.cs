using System;
using System.IO;
using System.Text;

namespace Bb
{

    public static partial class ContentHelper
    {

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">the content payload to write</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        public static void Save(this string path, string content, Encoding encoding = null)
        {
            path.Save(() => content, encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">function that return the content payload</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        public static void Save(this FileInfo path, string content, Encoding encoding = null)
        {
            path.FullName.Save(() => content.ToString(), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">the content payload to write</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        public static void Save(this string path, StringBuilder content, Encoding encoding = null)
        {
            path.Save(() => content.ToString(), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">function that return the content payload</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        public static void Save(this FileInfo path, StringBuilder content, Encoding encoding = null)
        {
            path.FullName.Save(() => content.ToString(), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">function that return the content payload</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        /// <param name="encoding">encoding for write. if null the datas are written in UTF8</param>
        public static void Save(this string filename, Func<string> payload, Encoding encoding = null)
        {
            
            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException($"« {nameof(filename)} » can't be empty or null.", nameof(filename));

            var file = new FileInfo(filename);
            if (!file.Directory.Exists)
                file.Directory.Create();

            FileInfo backup = new FileInfo(Path.Combine(file.Directory.FullName, Path.GetFileNameWithoutExtension(file.Name) + ".bck"));

            if (file.Exists)
            {

                if (backup.Exists)
                    backup.Delete();

                file.MoveTo(backup.FullName);

                backup.Refresh();

                file = new FileInfo(filename);
                file.Refresh();

            }

            try
            {
                File.WriteAllText(file.FullName, payload(), encoding ?? Encoding.UTF8);
            }
            catch (Exception ex)
            {
                if (backup.Exists)
                    backup.MoveTo(file.FullName);
            }
            finally
            {
                backup.Refresh();
                if (backup.Exists)
                    backup.Delete();
            }

        }

    }


}

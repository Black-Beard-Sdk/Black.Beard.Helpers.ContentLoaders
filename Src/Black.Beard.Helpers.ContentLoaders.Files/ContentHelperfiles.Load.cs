using System;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;

namespace Bb
{

    /// <summary>
    /// Content helper for managing files
    /// </summary>
    public static partial class ContentHelperFiles
    {

        /// <summary>
        /// Loads the content of the file.
        /// </summary>
        /// <param name="sourcePath">The source path segment. the path is concatenated with Path.Combine</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="InvalidDataException">if the sourcePath do not contains path</exception>
        public static string LoadFromFile(params string[] sourcePath)
        {

            if (sourcePath.Length == 0)
                throw new InvalidDataException($"{sourcePath} have no item. Please specify the path arguments");

            if (sourcePath.Any(c => string.IsNullOrEmpty(c)))
                throw new InvalidDataException($"Null reference in the arguments of path");

            string path = Path.Combine(sourcePath);

            return path.LoadFromFile(Encoding.UTF8);

        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static string LoadFromFile(this string path, Encoding defaultEncoding = null)
        {

            if (!string.IsNullOrEmpty(path))
            {
                FileInfo file = new FileInfo(path);
                return LoadFromFile(file, defaultEncoding);
            }

            return default;

        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static string LoadFromFile(this FileInfo self, Encoding defaultEncoding = null)
        {

            if (self == null)
                throw new NullReferenceException(nameof(self));

            self.Refresh();

            if (!self.Exists)
                throw new FileNotFoundException(self.FullName);


            string fileContents = string.Empty;
            Encoding encoding = defaultEncoding ?? Encoding.UTF8;

            using (FileStream fs = self.OpenRead())
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[self.Length];
                fs.Read(ar, 0, ar.Length);
                fileContents = encoding.GetString(ar);

            }

            if (fileContents.StartsWith("ï»¿"))
                fileContents = fileContents.Substring(3);

            if (encoding != Encoding.UTF8)
            {
                var datas = Encoding.UTF8.GetBytes(fileContents);
                fileContents = Encoding.UTF8.GetString(datas);
            }

            StringBuilder sb = new StringBuilder(fileContents.Length);
            for (int i = 0; i < fileContents.Length; i++)
            {
                var c = fileContents[i];
                if ((int)c != 65279)
                    sb.Append(c);
            }

            return sb.ToString();

        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserialize<TargetType>(this FileInfo self, Encoding defaultEncoding = null)
            where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            var instance = JsonSerializer.Deserialize<TargetType>(payload);
            return instance;
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserialize<TargetType>(this string self, Encoding defaultEncoding = null)
            where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            var instance = JsonSerializer.Deserialize<TargetType>(payload);
            return instance;
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self">file path</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializeConfiguration<TargetType>(this string self, Encoding defaultEncoding = null)
            where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {
                var element = doc.RootElement.GetProperty(nameof(TargetType));
                var instance = JsonSerializer.Deserialize<TargetType>(element);
                return instance;
            }
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding">if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializeConfiguration<TargetType>(this FileInfo self, Encoding defaultEncoding = null)
        where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {
                var element = doc.RootElement.GetProperty(nameof(TargetType));
                var instance = JsonSerializer.Deserialize<TargetType>(element);
                return instance;
            }
        }
    }


}

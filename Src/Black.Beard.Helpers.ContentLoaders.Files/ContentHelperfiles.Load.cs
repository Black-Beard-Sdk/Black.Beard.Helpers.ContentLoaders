using System;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Xml.Linq;

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
        /// Loads the content of the file and return XmlDocument.
        /// </summary>
        /// <param name="sourcePath">The source path segment. the path is concatenated with Path.Combine</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding" />if null Utf8 is used by default </param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="InvalidDataException">if the sourcePath do not contains path</exception>
        public static XDocument LoadXmlFromFile(this string sourcePath, Encoding defaultEncoding = null)
        {
            var payload = sourcePath.LoadFromFile(defaultEncoding);
            var doc = XDocument.Parse(payload);
            return doc;
        }


        /// <summary>
        /// Loads the content of the file and return XmlDocument.
        /// </summary>
        /// <param name="sourcePath">The source path segment. the path is concatenated with Path.Combine</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding" />if null Utf8 is used by default </param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="InvalidDataException">if the sourcePath do not contains path</exception>
        public static XDocument LoadXmlFromFile(this FileInfo sourcePath, Encoding defaultEncoding = null)
        {
            var payload = sourcePath.LoadFromFile(defaultEncoding);
            var doc = XDocument.Parse(payload);
            return doc;
        }


        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding" />if null Utf8 is used by default </param>
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
        /// <param name="defaultEncoding"><see cref="T:Encoding" />if null Utf8 is used by default</param>
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

                fs.Position = 0;

                byte[] ar = new byte[self.Length];
                fs.Read(ar, 0, ar.Length);
                fileContents = encoding.GetString(ar);

            }

            if (fileContents.StartsWith(Utf8Bom))
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
        /// Load the content from file and return a stream file. the default encoding is Utf8
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static FileStream StreamFromFile(this FileInfo self)
        {
            Encoding encoding = Encoding.UTF8;
            return StreamFromFile(self, ref encoding);
        }


        /// <summary>
        /// On a reader on the file stream and return a stream file. the default encoding is Utf8
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static StreamReader Read(this FileStream self)
        {
            return new StreamReader(self);
        }

        /// <summary>
        /// Load the content from file and return a stream file. If the encoding is not specified, the default encoding is Utf8
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="encoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static FileStream StreamFromFile(this FileInfo self, ref Encoding encoding)
        {

            if (self == null)
                throw new NullReferenceException(nameof(self));

            self.Refresh();

            if (!self.Exists)
                throw new FileNotFoundException(self.FullName);


            string fileContents = string.Empty;
            Encoding _encoding = encoding ?? Encoding.UTF8;

            FileStream fs = self.OpenRead();
            Ude.CharsetDetector cdet = new Ude.CharsetDetector();
            cdet.Feed(fs);
            cdet.DataEnd();
            if (cdet.Charset != null)
                _encoding = Encoding.GetEncoding(cdet.Charset);

            fs.Position = 0;

            if (self.Length > Utf8Bom.Length) // escape bom if stat with
            {
                byte[] ar = new byte[Utf8Bom.Length];
                fs.Read(ar, 0, ar.Length);
                var bom = _encoding.GetString(ar);
                if (bom == Utf8Bom)
                    _encoding = Encoding.UTF8;
                else
                    fs.Position = 0;
            }

            encoding = _encoding;
            return fs;

        }

        /// <summary>
        /// evaluate encoding of the file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static Encoding? EvaluateEncoding(this string self)
        {
            return EvaluateEncoding(new FileInfo(self));
        }

        /// <summary>
        /// evaluate encoding of the file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static Encoding? EvaluateEncoding(this FileInfo self)
        {

            if (self == null)
                throw new NullReferenceException(nameof(self));

            self.Refresh();

            if (!self.Exists)
                throw new FileNotFoundException(self.FullName);

            Encoding encoding = default;

            using (FileStream fs = self.OpenRead())
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = Encoding.GetEncoding(cdet.Charset);
            }

            return encoding;

        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializes<TargetType>(this FileInfo self, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
            where TargetType : class
        {
            options ??= new JsonSerializerOptions { WriteIndented = true };
            var payload = self.LoadFromFile(defaultEncoding);
            var instance = JsonSerializer.Deserialize<TargetType>(payload, options);
            return instance;
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializes<TargetType>(this string self, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
            where TargetType : class
        {
            options ??= new JsonSerializerOptions { WriteIndented = true };
            var payload = self.LoadFromFile(defaultEncoding);
            var instance = JsonSerializer.Deserialize<TargetType>(payload, options);
            return instance;
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="self">file path</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializesConfiguration<TargetType>(this string self, string key, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
            where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                if (string.IsNullOrEmpty(key))
                    key = typeof(TargetType).Name;

                options ??= new JsonSerializerOptions { WriteIndented = true };
                var element = doc.RootElement.GetProperty(key);
                var instance = JsonSerializer.Deserialize<TargetType>(element, options);
                return instance;
            }
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static TargetType LoadFromFileAndDeserializesConfiguration<TargetType>(this FileInfo self, string key, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
        where TargetType : class
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                if (string.IsNullOrEmpty(key))
                    key = typeof(TargetType).Name;

                options ??= new JsonSerializerOptions { WriteIndented = true };
                var element = doc.RootElement.GetProperty(key);
                var instance = JsonSerializer.Deserialize<TargetType>(element, options);
                return instance;
            }
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self">file path</param>
        /// <param name="targetType">target type</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static object LoadFromFileAndDeserializesConfiguration(this string self, string key, Type targetType, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                if (string.IsNullOrEmpty(key))
                    key = targetType.Name;

                options ??= new JsonSerializerOptions { WriteIndented = true };
                var element = doc.RootElement.GetProperty(targetType.Name);
                var instance = JsonSerializer.Deserialize(element, targetType, options);
                return instance;
            }
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self"><see cref="T:FileInfo"/></param>
        /// <param name="targetType">target type</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns>the content of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static object LoadFromFileAndDeserializesConfiguration(this FileInfo self, string key, Type targetType, Encoding defaultEncoding = null, JsonSerializerOptions? options = null)
        {
            var payload = self.LoadFromFile(defaultEncoding);
            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                if (string.IsNullOrEmpty(key))
                    key = targetType.Name;

                options ??= new JsonSerializerOptions { WriteIndented = true };
                var element = doc.RootElement.GetProperty(key);
                var instance = JsonSerializer.Deserialize(element, targetType, options);
                return instance;
            }
        }

        /// <summary>
        /// Load the content json from file
        /// </summary>
        /// <param name="self">file path</param>
        /// <param name="defaultEncoding"><see cref="T:Encoding"/>if null Utf8 is used by default</param>
        /// <returns>the json document <see cref="JsonDocument"/> of the text document</returns>
        /// <exception cref="NullReferenceException">If self is null</exception>
        /// <exception cref="FileNotFoundException">If the file is not found</exception>
        public static System.Text.Json.JsonDocument LoadJsonFromFile(this string self, Encoding defaultEncoding = null)
        {
            var payload = self.LoadFromFile(defaultEncoding);
            var doc = JsonDocument.Parse(payload);
            return doc;
        }

        public const string Utf8Bom = "ï»¿";
        public const int Echoing = 65279;

    }


}

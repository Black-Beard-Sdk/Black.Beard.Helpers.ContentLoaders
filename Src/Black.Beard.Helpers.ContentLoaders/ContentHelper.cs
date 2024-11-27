using System.Text;
using System.Text.Json;

namespace Bb
{

    public static partial class ContentHelper
    {

        /// <summary>
        /// Execute : Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        /// Register exotic encoding provider.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// ContentHelper.RegisterEncoding();
        /// </code>
        /// </example>
        public static void RegisterEncoding()
        {
            if (_registered)
                lock (_lock)
                    if (_registered)
                    {
                        _registered = true;
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    }
        }


        /// <summary>
        /// Loads the content from text.
        /// </summary>
        /// <param name="text">The text.</param>
        /// <returns></returns>        
        public static string LoadContentFromText(this byte[] text)
        {

            if (text == null)
                return default;

            string textContents = string.Empty;
            Encoding encoding = Encoding.UTF8;

            using (MemoryStream fs = new MemoryStream(text))
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[text.Length];
                fs.Read(ar, 0, ar.Length);
                textContents = encoding.GetString(ar);
            }

            if (textContents.StartsWith("ï»¿"))
                textContents = textContents.Substring(3);

            if (encoding != Encoding.UTF8)
            {
                var datas = Encoding.UTF8.GetBytes(textContents);
                textContents = Encoding.UTF8.GetString(datas);
            }

            StringBuilder sb = new StringBuilder(textContents.Length);
            for (int i = 0; i < textContents.Length; i++)
            {
                var c = textContents[i];
                if ((int)c != 65279)
                    sb.Append(c);
            }

            return sb.ToString();

        }

        /// <summary>
        /// Read the <see cref="MemoryStream" /> and return the result in <see cref="string"/>
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string? ConvertToString(this MemoryStream self)
        {

            if (self != null)
                return self.ToArray().LoadContentFromText();

            return default;

        }

        /// <summary>
        /// encode the specified <see cref="string"/> in base 64 encoded value
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ConvertToBase64(this string self)
        {

            if (self != null)
            {

                if (string.IsNullOrEmpty(self))
                    return string.Empty;

                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(self);
                var result = Convert.ToBase64String(bytes);
                return result;

            }

            return default;

        }

        /// <summary>
        /// decode the specified base 64 <see cref="string"/> encoded value.
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string? ConvertFromBase64(this string self)
        {

            if (self != null)
            {
                if (string.IsNullOrEmpty(self))
                    return string.Empty;

                byte[] bytes = Convert.FromBase64String(self); ;
                string result = System.Text.Encoding.UTF8.GetString(bytes);

                return result;
            }

            return default;

        }

        /// <summary>
        /// Serializes with indentation the specified object.
        /// </summary>
        /// <param name="self">The self object to serialize.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/></param>
        /// <returns></returns>
        public static string? Serialize(this object self, JsonSerializerOptions options)
        {
            if (self != null)
                return JsonSerializer.Serialize(self, options);
            return default;
        }


        /// <summary>
        /// Serializes the specified self instance in a memory.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static MemoryStream SerializeToMemory(this object self, JsonSerializerOptions options = null)
        {
            var stream = new MemoryStream();
            self.SerializeToStream(stream, options);
            if (stream.Position > 0)
                stream.Position = 0;

            return stream;
        }

        /// <summary>
        /// Serializes the specified self instance in the stream.
        /// </summary>
        /// <param name="self"></param>
        /// <param name="stream"></param>
        /// <param name="options"></param>
        public static void SerializeToStream(this object self, Stream stream, JsonSerializerOptions options = null)
        {

            if (options == null)
                options = new JsonSerializerOptions() { WriteIndented = true };

            if (self != null)
            {

                var o = new JsonWriterOptions()
                {
                    Indented = options.WriteIndented
                };

                using (var wrt = new Utf8JsonWriter(stream, o))
                {

                    JsonSerializer.Serialize(wrt, self, options);
                    wrt.Flush();
                }

            }

        }


        /// <summary>
        /// Serializes with indentation the specified object.
        /// </summary>
        /// <param name="self">The self object to serialize.</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <returns></returns>
        public static string? Serialize(this object self, bool indented)
        {
            return self.Serialize(new JsonSerializerOptions() { WriteIndented = indented });
        }

        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <param name="stream">source stream</param>
        /// <param name="targetType">type to generate</param>
        /// <param name="options">As <see cref="JsonSerializerOptions"/> provides options to be used with <see cref="System.Text.Json.JsonSerializer"/>.</param>
        /// <returns></returns>
        public static object Deserialize(this Stream stream, Type targetType, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize(stream, targetType, options ?? new JsonSerializerOptions());
        }

        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <typeparam name="T">type to cast to return</typeparam>
        /// <param name="stream">source stream</param>
        /// <param name="targetType">type to generate</param>
        /// <param name="options">As <see cref="JsonSerializerOptions"/> provides options to be used with <see cref="System.Text.Json.JsonSerializer"/>.</param>
        /// <returns></returns>
        public static T Deserialize<T>(this Stream stream, Type targetType, JsonSerializerOptions options = null)
        {
            return (T)JsonSerializer.Deserialize(stream, targetType, options ?? new JsonSerializerOptions());
        }

        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <typeparam name="T">type to generate</typeparam>
        /// <param name="stream">source stream</param>
        /// <param name="options">As <see cref="JsonSerializerOptions"/> provides options to be used with <see cref="System.Text.Json.JsonSerializer"/>.</param>
        /// <returns></returns>
        public static T Deserialize<T>(this Stream stream, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize<T>(stream, options ?? new JsonSerializerOptions());
        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <typeparam name="SourceType">The type of the target type.</typeparam>
        /// <param name="self">The payload.</param>
        /// <param name="options">As <see cref="JsonSerializerOptions"/> provides options to be used with <see cref="System.Text.Json.JsonSerializer"/>.</param>
        /// <returns></returns>
        public static SourceType? Deserialize<SourceType>(this string self, JsonSerializerOptions? options = null)
        {

            if (self != null)
            {
                options ??= new JsonSerializerOptions { WriteIndented = true };
                var instance = JsonSerializer.Deserialize<SourceType>(self, options);
                return instance;
            }

            return default;

        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <param name="self">The payload.</param>
        /// <param name="sourceType">Target type.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns></returns>
        public static object? Deserialize(this string self, Type sourceType, JsonSerializerOptions? options = null)
        {

            if (self != null)
            {
                options ??= new JsonSerializerOptions { WriteIndented = true };
                var instance = JsonSerializer.Deserialize(self, sourceType, options);
                return instance;
            }

            return default;

        }

        private static bool _registered = false;
        private static object _lock = new object();

    }


}

using System.Text;
using System.Text.Json;

namespace Bb
{

    public static partial class ContentHelper
    {

        /// <summary>
        /// Execute : Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        /// </summary>
        public static void RegisterEncoding()
        {
            if (_registerd)
                lock (_lock)
                    if (_registerd)
                    {
                        _registerd = true;
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        public static string LoadContentFromText(this byte[] text)
        {

            string textContents = string.Empty;
            System.Text.Encoding encoding = System.Text.Encoding.UTF8;

            using (MemoryStream fs = new MemoryStream(text))
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = System.Text.Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = System.Text.Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[text.Length];
                fs.Read(ar, 0, ar.Length);
                textContents = encoding.GetString(ar);
            }

            if (textContents.StartsWith("ï»¿"))
                textContents = textContents.Substring(3);

            if (encoding != System.Text.Encoding.UTF8)
            {
                var datas = System.Text.Encoding.UTF8.GetBytes(textContents);
                textContents = System.Text.Encoding.UTF8.GetString(datas);
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
        public static string ConvertToString(this MemoryStream self)
        {
            return self.ToArray().LoadContentFromText();
        }

        /// <summary>
        /// encode the specified <see cref="string"/> in base 64 encoded value
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ConvertToBase64(this string self)
        {

            if (string.IsNullOrEmpty(self))
                return string.Empty;

            byte[] bytes = System.Text.Encoding.UTF8.GetBytes(self);
            var result = Convert.ToBase64String(bytes);
            return result;
        }

        /// <summary>
        /// decode the specified base 64 <see cref="string"/> encoded value.
        /// </summary>
        /// <param name="self"></param>
        /// <returns></returns>
        public static string ConvertFromBase64(this string self)
        {

            if (string.IsNullOrEmpty(self))
                return string.Empty;

            byte[] bytes = Convert.FromBase64String(self); ;
            string result = System.Text.Encoding.UTF8.GetString(bytes);

            return result;

        }


        /// <summary>
        /// Serializes with indentation the specified object.
        /// </summary>
        /// <param name="self">The self object to serialize.</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <returns></returns>
        public static string Serialize(this object self, bool indented = true)
        {
            string jsonString = JsonSerializer.Serialize(self, new JsonSerializerOptions() { WriteIndented = indented });
            return jsonString;
        }


        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="self">The payload.</param>
        /// <returns></returns>
        public static TargetType? Deserialize<TargetType>(this string self)
        {
            var instance = JsonSerializer.Deserialize<TargetType>(self);
            return instance;
        }

        private static bool _registerd = false;
        private static object _lock = new object();

    }


}

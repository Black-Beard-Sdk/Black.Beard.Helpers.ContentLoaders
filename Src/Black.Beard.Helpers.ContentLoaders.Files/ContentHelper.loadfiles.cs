using System.IO;
using System.Text;

namespace Bb
{

    public static partial class ContentHelper
    {       

        /// <summary>
        /// Loads the content of the file.
        /// </summary>
        /// <param name="sourcePath">The source path.</param>
        /// <returns></returns>
        public static string LoadFromFile(params string[] sourcePath)
        {
            string path = Path.Combine(sourcePath);
            return LoadFromFile(path);
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="self">load file</param>
        /// <returns></returns>
        public static string LoadFromFile(this FileInfo self, System.Text.Encoding defaultEncoding = null)
        {
            return LoadFromFile(self.FullName, defaultEncoding);
        }

        /// <summary>
        /// Load the content from file
        /// </summary>
        /// <param name="path"> file path</param>
        /// <param name="defaultEncoding"></param>
        /// <returns></returns>
        /// <exception cref="FileLoadException"></exception>
        public static string LoadFromFile(this string path, System.Text.Encoding defaultEncoding = null)
        {

            if (File.Exists(path))
            {

                string fileContents = string.Empty;
                Encoding encoding = defaultEncoding ?? System.Text.Encoding.UTF8;
                FileInfo _file = new FileInfo(path);

                using (FileStream fs = _file.OpenRead())
                {

                    Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                    cdet.Feed(fs);
                    cdet.DataEnd();
                    if (cdet.Charset != null)
                        encoding = Encoding.GetEncoding(cdet.Charset);
                    else
                        encoding = Encoding.UTF8;

                    fs.Position = 0;

                    byte[] ar = new byte[_file.Length];
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

            throw new FileLoadException(path);

        }

    }


}

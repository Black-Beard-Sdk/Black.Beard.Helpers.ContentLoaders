using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;
using System.Xml;

namespace Bb
{


    /// <summary>
    /// Detect the type of document by its content
    /// </summary>
    public class FileContentTypeDetector
    {

        /// <summary>
        /// Detect the type of a file based on its content
        /// </summary>
        /// <param name="filePath">file path </param>
        /// <returns>a key for identify the content of file ("Unknown", "JSON", "XML", "INI", "PerKey", 
        /// and more if you add new detector with the method AddDetector)</returns>
        /// <exception cref="ArgumentNullException">return an exception if the file is null</exception>
        /// <exception cref="FileNotFoundException">return an exception if the file is missing</exception>
        public static string DetectFileType(string filePath)
        {
            return DetectFileType(new FileInfo(filePath));
        }

        /// <summary>
        /// Detect the type of a file based on its content
        /// </summary>
        /// <param name="filePath">file path of type <see cref="FileInfo"/> </param>
        /// <returns>a key for identify the content of file ("Unknown", "JSON", "XML", "INI", "PerKey", 
        /// and more if you add new detector with the method AddDetector)</returns>
        /// <exception cref="ArgumentNullException">return an exception if the file is null</exception>
        /// <exception cref="FileNotFoundException">return an exception if the file is missing</exception>
        public static string DetectFileType(FileInfo filePath)
        {

            if (filePath == null)
                throw new ArgumentNullException(nameof(filePath));

            if (File.Exists(filePath.FullName) == false)
                throw new FileNotFoundException(filePath.FullName);

            string fileContent = filePath.LoadFromFile();

            foreach (var item in _dic)
            {
                try
                {
                    if (item.Value(fileContent))
                        return item.Key;
                }
                catch (Exception)
                {

                }
            }

            return "Unknown";

        }

        /// <summary>
        /// Add a new detector to the list of detectors
        /// </summary>
        /// <param name="name">key to return if match</param>
        /// <param name="detector"></param>
        public static void AddDetector(string name, Func<string, bool> detector)
        {
            _dic.Add(name, detector);
        }

        private static bool IsJson(string content)
        {
            JsonDocument.Parse(content);
            return true;
        }

        private static bool IsXml(string content)
        {
            var xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(content);
            return true;
        }

        private static bool IsIni(string content)
        {
            // Vérifier si le contenu ressemble à un fichier INI
            // Les fichiers INI ont généralement des sections entre crochets et des paires clé-valeur
            return content.Contains("[") && content.Contains("]") && content.Contains("=");
        }

        private static bool IsPerKey(string content)
        {
            // Implémentez votre propre logique pour détecter le format PerKey
            // Par exemple, si le format PerKey a des paires clé-valeur séparées par des deux-points
            return content.Contains(":");
        }

        private static Dictionary<string, Func<string, bool>> _dic = new Dictionary<string, Func<string, bool>>()
        {
            { "JSON", IsJson },
            { "XML", IsXml },
            { "INI", IsIni },
            { "PerKey", IsPerKey },
        };

    }



}

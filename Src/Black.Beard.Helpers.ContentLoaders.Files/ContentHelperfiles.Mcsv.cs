using Bb.MultiCsv;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Nodes;

namespace Bb
{

    public static partial class ContentHelperFiles
    {

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rules">The rules.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this string file, IndentationRules rules = null)
        {
            return LoadMultiCsv(new FileInfo(file), rules);
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rules">The rules.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this FileInfo file, IndentationRules rules = null)
        {

            file.Refresh();
            List<JsonNode> datas = new List<JsonNode>((int)(file.Length / 100));

            if (file.Exists)
            {

                var visitor = new JsonVisitor()
                {
                    //IgnoreEmptyProperties = true,
                };

                FileReader reader = FileReader.Readfile(file.FullName, rules);

                Read(datas, visitor, reader);

            }

            if (datas.Count == 0)
                return null;

            if (datas.Count == 1)
                return datas[0];

            var array = new JsonArray(datas.ToArray());

            return array;

        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rulePayload">The rule payload.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this string file, string rulePayload = null)
        {
            return LoadMultiCsv(new FileInfo(file), rulePayload);
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rulePayload">The rule payload.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this FileInfo file, string rulePayload = null)
        {

            file.Refresh();
            List<JsonNode> datas = new List<JsonNode>((int)(file.Length / 100));

            if (file.Exists)
            {

                var visitor = new JsonVisitor()
                {
                    //IgnoreEmptyProperties = true,
                };

                FileReader reader = FileReader.Readfile(file.FullName, rulePayload ?? string.Empty);

                Read(datas, visitor, reader);

            }

            if (datas.Count == 0)
                return null;

            if (datas.Count == 1)
                return datas[0];

            var array = new JsonArray(datas.ToArray());

            return array;

        }


        private static void Read(List<JsonNode> datas, JsonVisitor visitor, FileReader reader)
        {
            foreach (var item in reader.Items)
            {
                var resultVisitor = visitor.Visit(item);

                // var info = reader.FileInformations;

                //var metadatas = new JsonObject
                //    {
                //        new KeyValuePair<string, JsonNode>("$Filename", info.FileInfo.FullName),
                //        new KeyValuePair<string, JsonNode>("$EncodingFile", info.EncodingByUde.HeaderName),
                //        new KeyValuePair<string, JsonNode>("$EncodingFileBody", info.EncodingByUde.BodyName)
                //    };

                //foreach (var meta in info.Metadatas)
                //    metadatas.Add(new KeyValuePair<string, JsonNode>(meta.Key, meta.Value));

                //if (resultVisitor is JsonObject obj)
                //    obj.Add(new KeyValuePair<string, JsonNode>("_metadatas", metadatas));

                //else if (resultVisitor is JsonArray arr)
                //    arr.Insert(0, metadatas);

                //else
                //{

                //    if (System.Diagnostics.Debugger.IsAttached)
                //        System.Diagnostics.Debugger.Break();

                //}

                datas.Add(resultVisitor);
            }
        }

    }
}

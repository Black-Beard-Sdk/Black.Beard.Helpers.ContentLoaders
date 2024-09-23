using Bb.MultiCsv;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Nodes;

namespace Bb
{

    public static partial class ContentHelperFiles
    {

        // string? see = null, Func<Block, bool>? func = null

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this string file)
        {
            return LoadMultiCsv(new FileInfo(file), (IndentationRules)null, null);
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rulePayload">The rule payload.</param>
        /// <param name="initializer">customize the reader.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this string file, string rulePayload, Action<FileReader>? initializer)
        {
            return LoadMultiCsv(new FileInfo(file)
                , string.IsNullOrEmpty(rulePayload)
                    ? null
                    : new IndentationRules(rulePayload)
                , initializer
            );
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rules">The rules.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this string file, IndentationRules rules)
        {
            return LoadMultiCsv(new FileInfo(file), rules, null);
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rulePayload">The rule payload.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this FileInfo file, string rulePayload)
        {

            return LoadMultiCsv(file
                , string.IsNullOrEmpty(rulePayload)
                  ? null
                  : new IndentationRules(rulePayload)
                , null
            );

        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="rulePayload">The rule payload.</param>
        /// <param name="initializer">customize the reader.</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="Csharp">
        ///    var file = @"C:\Users\...\file.ext".AsFile();
        ///    var f = file.LoadMultiCsv("BlockName1:SubBlock1|SubBlock2; SubBlock2|SubBlock3",
        ///        c =>
        ///        {
        ///            c.See("BlockName1", (c) =>
        ///            {
        ///                return true;
        ///            });
        ///        }
        ///        );
        /// </code> 
        /// </example>
        public static JsonNode LoadMultiCsv(this FileInfo file, string rulePayload, Action<FileReader>? initializer)
        {

            return LoadMultiCsv(file
                , string.IsNullOrEmpty(rulePayload)
                  ? null
                  : new IndentationRules(rulePayload)
                , initializer
            );

        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this FileInfo file)
        {
            return LoadMultiCsv(file, (IndentationRules)null, null);
        }

        /// <summary>
        /// Loads the multi CSV.
        /// </summary>
        /// <param name="file">The file to read.</param>
        /// <param name="rules">The rules.</param>
        /// <param name="initializer">customize the reader.</param>
        /// <returns></returns>
        public static JsonNode LoadMultiCsv(this FileInfo file, IndentationRules rules, Action<FileReader> initializer)
        {

            file.Refresh();
            List<JsonNode> datas = new List<JsonNode>((int)(file.Length / 100));

            if (file.Exists)
            {          
                FileReader reader = FileReader.FileReadFile(file.FullName, rules, initializer);
                if (reader._visitor != null)
                    Read(datas, reader._visitor, reader);
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

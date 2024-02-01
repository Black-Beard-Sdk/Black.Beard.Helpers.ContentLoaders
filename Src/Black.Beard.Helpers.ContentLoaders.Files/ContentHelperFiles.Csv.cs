using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Text;
using System.Text.Json.Nodes;
using Bb.Csv;
using Black.Beard.Helpers.ContentLoaders.Files.Csv;

namespace Bb
{


    public static partial class ContentHelperFiles
    {


        /// <summary>
        /// Opens to write CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="quote">The quote.</param>
        /// <param name="escape">The escape.</param>
        /// <returns></returns>
        public static CsvWriter OpenToWriteCsv(this FileInfo file, string delimiter = ";", string quote = null, string escape = "\\")
        {
            return new CsvWriter(delimiter, quote, escape).Open(file);
        }

        /// <summary>
        /// Opens to write CSV.
        /// </summary>
        /// <param name="file">The file.</param>
        /// <param name="delimiter">The delimiter.</param>
        /// <param name="quote">The quote.</param>
        /// <param name="escape">The escape.</param>
        /// <returns></returns>
        public static CsvWriter OpenToWriteCsv(this string filename, string delimiter = ";", string quote = null, string escape = null)
        {
            return new CsvWriter(delimiter, quote, escape).Open(filename);
        }


        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="filename">The filename of the csv.</param>
        /// <param name="action">The action to execute for each lines of csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns></returns>
        public static void ReadCsv(this string filename, Action<IDataReader, int, int> action, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {
            ReadCsv(new FileInfo(filename), action, hasHeader, charsetSeparator, quoteCharset, escapeCharset);
        }


        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="filename">The filename of the csv.</param>
        /// <param name="action">The action to execute for each lines of csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns></returns>
        public static void ReadCsv(this FileInfo file, Action<IDataReader, int, int> action, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {

            var separator = charsetSeparator;
            if (separator.Length == 3)
                separator = separator.Trim(separator[0]);

            char? quote = null;
            if (quoteCharset?.Length > 0)
            {
                quote = quoteCharset[0];
            }

            var escape = escapeCharset;
            if (escape.Length == 3)
                escape = escape.Trim(escape[0]);

            var text = file.LoadFromFile();

            int cnt = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == '\n')
                    cnt++;

            using (var _txt = new StringReader(text))
            using (CsvReader csv = new CsvReader(_txt, hasHeader, separator[0], quote, escape[0], '#', ValueTrimmingOptions.All, (int)file.Length))
            {

                System.Data.IDataReader reader = csv;
                int line = 0;

                if (hasHeader)
                    line++;

                while (reader.Read())
                {
                    line++;
                    var lastPosition = csv.CurrentPosition;
                    action(csv, line, lastPosition);
                }

            }

        }

        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="filename">The filename of the csv.</param>
        /// <param name="action">The action to execute for each lines of csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns></returns>
        public static IEnumerable<(IDataReader, int, int)> ReadCsv(this string filename, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {
            return ReadCsv(new FileInfo(filename), hasHeader, charsetSeparator, quoteCharset, escapeCharset);
        }

        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="filename">The file of the csv.</param>
        /// <param name="action">The action to execute for each lines of csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns></returns>
        public static IEnumerable<(IDataReader, int, int)> ReadCsv(this FileInfo file, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {

            var separator = charsetSeparator;
            if (separator.Length == 3)
                separator = separator.Trim(separator[0]);

            char? quote = null;
            if (quoteCharset?.Length > 0)
            {
                quote = quoteCharset[0];
            }

            var escape = escapeCharset;
            if (escape.Length == 3)
                escape = escape.Trim(escape[0]);



            var text = file.LoadFromFile();

            int cnt = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == '\n')
                    cnt++;

            using (var _txt = new StringReader(text))
            using (CsvReader csv = new CsvReader(_txt, hasHeader, separator[0], quote, escape[0], '#', ValueTrimmingOptions.All, (int)file.Length))
            {

                System.Data.IDataReader reader = csv;
                int line = 0;

                if (hasHeader)
                    line++;

                while (reader.Read())
                {
                    line++;
                    var lastPosition = csv.CurrentPosition;
                    yield return (csv, line, lastPosition);
                }

            }

        }

        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="filename">The filename of the csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns>IEnumerable of Json object</returns>
        public static IEnumerable<JsonObject> ReadCsvToJson(this string filename, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {
            return ReadCsvToJson(new FileInfo(filename), hasHeader, charsetSeparator, quoteCharset, escapeCharset);
        }

        /// <summary>
        /// Reads the CSV.
        /// </summary>
        /// <param name="file">The file of the csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns>IEnumerable of Json object</returns>
        public static IEnumerable<JsonObject> ReadCsvToJson(this FileInfo file, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {

            var separator = charsetSeparator;
            if (separator.Length == 3)
                separator = separator.Trim(separator[0]);

            char? quote = null;
            if (quoteCharset?.Length > 0)
                quote = quoteCharset[0];

            var escape = escapeCharset;
            if (escape.Length == 3)
                escape = escape.Trim(escape[0]);


            var text = file.LoadFromFile();

            int cnt = 0;
            for (int i = 0; i < text.Length; i++)
                if (text[i] == '\n')
                    cnt++;

            using (var _txt = new StringReader(text))
            using (CsvReader csv = new CsvReader(_txt, hasHeader, separator[0], quote, escape[0], '#', ValueTrimmingOptions.All, (int)file.Length))
                foreach (var item in ReadLines(csv, hasHeader))
                    yield return item;

        }

        /// <summary>
        /// Reads the CSV on stream mode.
        /// </summary>
        /// <param name="filename">The filename of the csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns>IEnumerable of Json object</returns>
        public static IEnumerable<JsonObject> ReadBigCsvToJson(this string filename, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {
            return ReadBigCsvToJson(new FileInfo(filename), hasHeader, charsetSeparator, quoteCharset, escapeCharset);
        }

        /// <summary>
        /// Reads the CSV on stream mode.
        /// </summary>
        /// <param name="file">The file of the csv.</param>
        /// <param name="hasHeader">if set to <c>true</c> [has header]. By default the value is true</param>
        /// <param name="charsetSeparator">The charset separator. By default the value is ';'</param>
        /// <param name="quoteCharset">The quote charset. By default the value is '"'</param>
        /// <param name="escapeCharset">The escape charset.  By default the value is '/'</param>
        /// <returns>IEnumerable of Json object</returns>
        public static IEnumerable<JsonObject> ReadBigCsvToJson(this FileInfo file, bool hasHeader = true, string charsetSeparator = ";", string quoteCharset = @"""", string escapeCharset = @"/")
        {

            var separator = charsetSeparator;
            if (separator.Length == 3)
                separator = separator.Trim(separator[0]);

            char? quote = null;
            if (quoteCharset?.Length > 0)
                quote = quoteCharset[0];

            var escape = escapeCharset;
            if (escape.Length == 3)
                escape = escape.Trim(escape[0]);

            Encoding encoding = Encoding.UTF8;

            using (var text = file.StreamFromFile(ref encoding))
            using (var _txt = new StreamReader(text))
            using (CsvReader csv = new CsvReader(_txt, hasHeader, separator[0], quote, escape[0], '#', ValueTrimmingOptions.All, (int)file.Length))
                foreach (var item in ReadLines(csv, hasHeader))
                    yield return item;

        }

        private static IEnumerable<JsonObject> ReadLines(CsvReader csv, bool hasHeader)
        {

            System.Data.IDataReader reader = csv;
            int line = 0;

            if (hasHeader)
                line++;

            List<KeyValuePair<string, JsonNode>> properties = new List<KeyValuePair<string, JsonNode>>(100);
            while (reader.Read())
            {

                line++;
                var lastPosition = csv.CurrentPosition;

                properties.Add(new KeyValuePair<string, JsonNode>("$line", line));
                properties.Add(new KeyValuePair<string, JsonNode>("$lastposition", lastPosition));

                for (int i = 0; i < reader.FieldCount; i++)
                {

                    var n = reader.GetName(i);

                    string name = hasHeader
                        ? GetLabel(n)
                        : "Column" + i.ToString();

                    var raw = reader.GetValue(i);
                    var value = GetValue(raw);

                    if (value != null)
                    {
                        var p = new KeyValuePair<string, JsonNode>(name, value);
                        properties.Add(p);
                    }

                }

                if (properties.Count > 0)
                {
                    var o = new JsonObject(properties);
                    yield return o;
                    properties.Clear();
                }

            }

            properties.Clear();

        }

        private static JsonNode GetValue(object value)
        {

            if (value == null || value == DBNull.Value)
                return null;

            if (value is string v)
            {

                v = v.Trim().ToLower();

                if (string.IsNullOrWhiteSpace(v))
                    return null;

                if (v == "true")
                    return JsonValue.Create(true);

                if (v == "false")
                    return JsonValue.Create(false);

                var x = v[0];

                if (x == '-' || char.IsDigit(x))
                {
                    bool isint = false;
                    bool isNegative = false;
                    bool isdecimal = false;

                    for (int i = 0; i < v.Length; i++)
                    {
                        x = v[i];
                        if (i == 0 && x == '-')
                            isNegative = true;

                        if (char.IsDigit(x))
                            isint = true;

                        else if (isint && x == '.')
                            isdecimal = true;

                        else
                            break;
                    }

                    if (isdecimal && decimal.TryParse(v, out decimal d))
                        return JsonValue.Create(d);

                    if (isint && long.TryParse(v, out long l))
                    {
                        if (l.ToString() == v)
                        {
                            if (l < int.MaxValue)
                                return JsonValue.Create((int)l);

                            return JsonValue.Create(l);
                        }
                    }
                }

            }

            return JsonValue.Create(value);

        }

        private static string GetLabel(string n)
        {

            var sb = new StringBuilder(n.Length);

            foreach (var c in n)
            {
                var p = (int)c;

                //if (p == 65279) // Bom // { } 
                if (_accepted.TryGetValue(c, out char v))
                    sb.Append(v);

            }

            return sb.ToString()
                 .Replace("___", "_")
                 .Replace("__", "_");

        }

        private static Dictionary<char, char> _accepted = build();

        private static Dictionary<char, char> build()
        {

            var dic = new Dictionary<char, char>();

            Add(dic, 'a', 'z');
            Add(dic, 'A', 'Z');
            Add(dic, '0', '9');

            dic.Add(' ', '_');
            dic.Add('\'', '_');
            dic.Add('"', '_');
            dic.Add('é', 'e');
            dic.Add('è', 'e');
            dic.Add('ë', 'e');
            dic.Add('î', 'i');
            dic.Add('ï', 'i');
            dic.Add('Ï', 'I');
            dic.Add('Ö', 'O');
            dic.Add('Ü', 'U');
            dic.Add('ô', 'o');
            dic.Add('à', 'a');
            dic.Add('ê', 'e');
            dic.Add('ñ', 'n');
            dic.Add('Ñ', 'N');
            dic.Add('¡', 'i');
            dic.Add('á', 'a');
            dic.Add('í', 'i');
            dic.Add('ó', 'o');
            dic.Add('ú', 'u');
            dic.Add('Á', 'A');
            dic.Add('É', 'E');
            dic.Add('Í', 'I');
            dic.Add('Ó', 'O');
            dic.Add('Ú', 'U');
            dic.Add('ä', 'a');
            dic.Add('ö', 'o');
            dic.Add('Ä', 'A');
            dic.Add('Ë', 'E');

            return dic;

        }

        private static void Add(Dictionary<char, char> dic, int s, int e)
        {
            for (int i = s; i <= e; i++)
                dic.Add((char)i, (char)i);
        }

    }

}

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Bb
{


    public static partial class ContentHelperFiles
    {

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">the content payload to write</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this string path, string content, Encoding encoding = null)
        {
            path.Save(() => content, encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">the content payload to write</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
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
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this string path, StringBuilder content, Encoding encoding = null)
        {
            path.Save(() => content.ToString(), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="path">file path</param>
        /// <param name="content">content payload to write</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this FileInfo path, StringBuilder content, Encoding encoding = null)
        {
            path.FullName.Save(() => content.ToString(), encoding);
        }            

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="filename">file path</param>
        /// <param name="payload">function that return the content payload</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this string filename, Func<string> payload, Encoding encoding = null)
        {

            if (string.IsNullOrEmpty(filename))
                throw new ArgumentException($"« {nameof(filename)} » can't be null or empty.", nameof(filename));

            var file = new FileInfo(filename);

            file.Save(payload, encoding);

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="file">file target</param>
        /// <param name="payload">function that return the content payload</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this FileInfo file, Func<string> payload, Encoding encoding = null)
        {

            file.Refresh();

            string filename = file.FullName;

            if (!file.Directory.Exists)
                file.Directory.Create();

            FileInfo backup = new FileInfo(Path.Combine(file.Directory.FullName, Path.GetFileNameWithoutExtension(file.Name) + ".bck"));

            bool saved = false;

            if (file.Exists)
            {

                if (backup.Exists)
                    backup.Delete();

                file.MoveTo(backup.FullName);
                backup.Refresh();

                saved = true;

                file = new FileInfo(filename);
                file.Refresh();

            }

            try
            {
                File.WriteAllText(file.FullName, payload(), encoding ?? Encoding.UTF8);
            }
            catch (Exception ex)
            {
                Trace.TraceWarning(ex.Message);
                if (saved && backup.Exists)
                    backup.MoveTo(file.FullName);
            }
            finally
            {
                backup.Refresh();
                if (backup.Exists)
                    backup.Delete();
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="filename">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void SerializesAndSave(this string filename, object instance, bool indented = true, Encoding encoding = null)
        {
            filename.Save(() => JsonSerializer.Serialize(instance, new JsonSerializerOptions() { WriteIndented = indented }), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="filename">file path</param>
        /// <param name="document">object to serialize</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void Save(this string filename, JsonDocument document, bool indented = true, Encoding encoding = null)
        {
            filename.Save(() => JsonSerializer.Serialize(document, new JsonSerializerOptions() { WriteIndented = indented }), encoding);
        }
              

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="file">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="indented">if set to <c>true</c> [indented].</param>
        /// <param name="encoding">encoding for write. if null the data are written in UTF8</param>
        public static void SerializesAndSave(this FileInfo file, object instance, bool indented = true, Encoding encoding = null)
        {
            file.Save(() => JsonSerializer.Serialize(instance, new JsonSerializerOptions() { WriteIndented = indented }), encoding);
        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <typeparam name="SourceType">The type of the source type.</typeparam>
        /// <param name="filename">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="options">options of serialization.<see cref="JsonSerializerOptions"/></param>
        public static void SerializeAndSaveConfiguration<SourceType>(this string filename, SourceType instance, JsonSerializerOptions options = null)
            where SourceType : class
        {

            if (instance != null)
            {

                if (options != null)
                    options = new JsonSerializerOptions { WriteIndented = true };

                var t2 = new JsonObject() { [nameof(SourceType)] = JsonSerializer.SerializeToNode(instance) };
                string config = t2.ToJsonString(options);
                filename.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <typeparam name="SourceType">The type of the source type.</typeparam>
        /// <param name="file">file path</param>
        /// <param name="instance">object to serialize</param>
        public static void SerializeAndSaveConfiguration<SourceType>(this FileInfo file, SourceType instance)
            where SourceType : class
        {

            if (instance != null)
            {
                var t2 = new JsonObject() { [nameof(SourceType)] = JsonSerializer.SerializeToNode(instance) };
                var options = new JsonSerializerOptions { WriteIndented = true };
                string config = t2.ToJsonString(options);
                file.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <typeparam name="SourceType">The type of the source type.</typeparam>
        /// <param name="file">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="options">options of serialization.<see cref="JsonSerializerOptions"/></param>
        public static void SerializeAndSaveConfiguration<SourceType>(this FileInfo file, SourceType instance, JsonSerializerOptions options = null)
            where SourceType : class
        {

            if (instance != null)
            {

                if (options != null)
                    options = new JsonSerializerOptions { WriteIndented = true };

                var t2 = new JsonObject() { [nameof(SourceType)] = JsonSerializer.SerializeToNode(instance) };
                string config = t2.ToJsonString(options);
                file.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="filename">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="sourceType">source type</param>
        public static void SerializeAndSaveConfiguration(this string filename, object instance, Type sourceType = null)
        {

            if (instance != null)
            {

                if (sourceType == null)
                    sourceType = instance.GetType();

                var t2 = new JsonObject() { [sourceType.Name] = JsonSerializer.SerializeToNode(instance, sourceType) };
                var options = new JsonSerializerOptions { WriteIndented = true };
                string config = t2.ToJsonString(options);
                filename.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="filename">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="sourceType">source type</param>
        /// <param name="options">options of serialization.<see cref="JsonSerializerOptions"/></param>
        public static void SerializeAndSaveConfiguration(this string filename, object instance, Type sourceType = null, JsonSerializerOptions options = null)
        {

            if (instance != null)
            {

                if (sourceType == null)
                    sourceType = instance.GetType();

                if (options != null)
                    options = new JsonSerializerOptions { WriteIndented = true };

                var t2 = new JsonObject() { [sourceType.Name] = JsonSerializer.SerializeToNode(instance, sourceType) };
                string config = t2.ToJsonString(options);
                filename.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="file">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="targetType">target type</param>
        public static void SerializeAndSaveConfiguration(this FileInfo file, object instance, Type targetType = null)
        {

            if (instance != null)
            {

                if (targetType == null)
                    targetType = instance.GetType();

                var t2 = new JsonObject() { [targetType.Name] = JsonSerializer.SerializeToNode(instance, targetType) };
                var options = new JsonSerializerOptions { WriteIndented = true };
                string config = t2.ToJsonString(options);
                file.Save(() => config, Encoding.UTF8);
            }

        }

        /// <summary>
        /// Save the content in the specified file.
        /// If the directory don't exist. it is created.
        /// </summary>
        /// <param name="file">file path</param>
        /// <param name="instance">object to serialize</param>
        /// <param name="targetType">target type</param>
        /// <param name="options">options of serialization.<see cref="JsonSerializerOptions"/></param>
        public static void SerializeAndSaveConfiguration(this FileInfo file, object instance, Type targetType = null, JsonSerializerOptions options = null)
        {

            if (instance != null)
            {

                if (targetType == null)
                    targetType = instance.GetType();

                if (options != null)
                    options = new JsonSerializerOptions { WriteIndented = true };

                var t2 = new JsonObject() { [targetType.Name] = JsonSerializer.SerializeToNode(instance, targetType) };
                string config = t2.ToJsonString(options);
                file.Save(() => config, Encoding.UTF8);
            }

        }

    }


}

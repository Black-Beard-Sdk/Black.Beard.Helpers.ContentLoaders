using System;
using System.Data;
using System.Text.Json;
using System.Text.Json.Nodes;
using Json.Schema;
using Json.Schema.Generation;


namespace Bb.Configuration
{

    public static partial class ConfigurationHelper
    {







        /// <summary>
        /// Génère un schéma JSON à partir d'un Type.
        /// </summary>
        /// <param name="type">Le Type à partir duquel générer le schéma.</param>
        /// <returns>Le schéma JSON généré.</returns>
        public static string GenerateSchemaFrom(Type type)
        {

            var generator = new SchemaGeneratorConfiguration()
            {
                //ExternalReferences =
                //{
                //    [typeof(DateTime)] = "https://docs.json-everything.net/date-time"
                //}
            };

            var schema = new JsonSchemaBuilder().FromType(type, generator);



            var options = new JsonSerializerOptions
            {
                WriteIndented = true,
            };

            string schemaJson = JsonSerializer.Serialize(schema, options);
            return schemaJson;

        }



        /// <summary>
        /// Serializes the specified self instance.
        /// </summary>
        /// <typeparam name="SourceType">The type of the target type.</typeparam>
        /// <param name="self">the instance to serialize.</param>
        /// <param name="options"><see cref="JsonSerializerOptions" />options of serialization</param>
        /// <returns></returns>
        public static string? SerializeConfiguration<SourceType>(this SourceType self, JsonSerializerOptions? options = null)
            where SourceType : class
        {

            if (self != null)
            {
                options ??= new JsonSerializerOptions { WriteIndented = true };
                var t2 = new JsonObject() { [nameof(SourceType)] = JsonSerializer.SerializeToNode(self, options) };
                string config = t2.ToJsonString(options);
                return config;
            }

            return default;

        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <typeparam name="TargetType">The type of the target type.</typeparam>
        /// <param name="payload">the instance to serialize.</param>
        /// <param name="options"><see cref="JsonSerializerOptions" />options of serialization</param>
        /// <returns></returns>
        public static TargetType? DeserializeConfiguration<TargetType>(this string payload, JsonSerializerOptions? options = null)
            where TargetType : class
        {
            return payload.DeserializeConfiguration(typeof(TargetType), options) as TargetType;
        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <param name="payload">the instance to serialize.</param>
        /// <param name="targetType">target Type</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns></returns>
        public static object? DeserializeConfiguration(this string payload, Type targetType, JsonSerializerOptions? options = null)
        {

            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                options ??= new JsonSerializerOptions { WriteIndented = true };

                var element = doc.RootElement.GetProperty(targetType.Name);
                var instance = JsonSerializer.Deserialize(element, targetType, options);
                return instance;
            }

        }

    }


}

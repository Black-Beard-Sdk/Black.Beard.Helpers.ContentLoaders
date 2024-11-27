using Json.Schema;
using Json.Schema.Generation;
using System.Text.Json;
using System.Text.Json.Nodes;
using Ude.Core;

namespace Bb
{

    public static partial class ConfigurationHelper
    {

        /// <summary>
        /// Generates a JSON schema from a Type.
        /// </summary>
        /// <param name="type">type to generate.</param>
        /// <returns><see cref="JsonSchemaBuilder"/></returns>
        /// <remarks>see the documentation : https://docs.json-everything.net/schema/schemagen/data-annotations/</remarks>
        public static string GenerateSchemaForConfiguration(this Type type, Uri? id = null, SchemaGeneratorConfiguration? configuration = null)
        {

            string name = type.Name.Replace("`", "");
            string _id = id?.ToString() ?? $"http://Black.Beard.com/schemas/{name}";

            if (configuration == null)
                configuration = new SchemaGeneratorConfiguration()
                {
                    Nullability = Nullability.AllowForNullableValueTypes,
                    Optimize = true,
                    PropertyOrder = PropertyOrder.ByName,
                };

            var builder = new JsonSchemaBuilder()
                .Schema("https://json-schema.org/draft/2020-12/schema")
                .Id(_id)
                ;

            builder = builder
                .FromType(typeof(ConfigurationSerializer<>)
                    .MakeGenericType(type), configuration);

            var result = builder.Serialize(null);

            var n = JsonObject.Parse(result).AsObject();
            var n1 = n["properties"];
            var n2 = n1["Configuration"];
            (n1 as JsonObject).Remove("Configuration");
            n1[name] = n2;

            return n.ToString();

        }

        /// <summary>
        /// Serialize to string the specified schema.
        /// </summary>
        /// <param name="schemaBuilder">schema builder</param>
        /// <param name="options">options for serialization</param>
        /// <returns></returns>
        public static string Serialize(this JsonSchemaBuilder schemaBuilder, JsonSerializerOptions? options = null)
        {

            if (options == null)
                options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

            var schema = schemaBuilder.Build();

            return JsonSerializer.Serialize(schema, options);

        }

        /// <summary>
        /// Serialize to string the specified schema.
        /// </summary>
        /// <param name="schemaBuilder">schema builder</param>
        /// <param name="options">options for serialization</param>
        /// <returns></returns>
        public static string Serialize(this JsonSchema schema, JsonSerializerOptions? options = null)
        {

            if (options == null)
                options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

            return JsonSerializer.Serialize(schema, options);

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


    public struct ConfigurationSerializer<T>
    {

        public T Configuration { get; set; }

    }


}

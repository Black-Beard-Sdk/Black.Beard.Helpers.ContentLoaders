using Json.Schema;
using Json.Schema.Generation;
using System;
using System.Text.Json;
using System.Text.Json.Nodes;

namespace Bb.Configurations
{

    /// <summary>
    /// Helper class for working with JSON schemas and configuration serialization.
    /// </summary>
    public static partial class ConfigurationHelper
    {


        /// <summary>
        /// Generates a JSON schema from a Type.
        /// </summary>
        /// <param name="type">Type to generate schema for. Must not be null.</param>
        /// <param name="id">Optional URI identifier for the schema. If null, a default URI will be constructed using the type name.</param>
        /// <param name="configuration">Optional configuration for schema generation. If null, default settings will be used.</param>
        /// <returns>
        /// A <see cref="string"/> containing the JSON schema representation of the type.
        /// </returns>
        /// <remarks>
        /// This method creates a JSON schema that describes the structure of the specified type.
        /// It uses Json.Schema.Generation to generate the schema, then performs post-processing to
        /// rename the root property from "Configuration" to the actual type name.
        /// 
        /// For more details on schema generation options, see the documentation:
        /// https://docs.json-everything.net/schema/schemagen/data-annotations/
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when type is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Generate schema for a configuration class
        /// public class MyAppConfig
        /// {
        ///     public string ServerUrl { get; set; }
        ///     public int Port { get; set; }
        ///     public bool EnableLogging { get; set; }
        /// }
        /// 
        /// // Generate schema with default settings
        /// string schema = typeof(MyAppConfig).GenerateSchemaForConfiguration();
        /// 
        /// // Generate schema with custom URI
        /// Uri schemaId = new Uri("https://mycompany.com/schemas/appconfig");
        /// string customSchema = typeof(MyAppConfig).GenerateSchemaForConfiguration(schemaId);
        /// </code>
        /// </example>
        public static string GenerateSchemaForConfiguration(this Type type, Uri id = null, SchemaGeneratorConfiguration configuration = null)
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

            var n = JsonNode.Parse(result).AsObject();
            var n1 = n["properties"];
            var n2 = n1["Configuration"];
            (n1 as JsonObject).Remove("Configuration");
            n1[name] = n2;

            return n.ToString();

        }

        /// <summary>
        /// Serialize to string the specified schema.
        /// </summary>
        /// <param name="schemaBuilder">Schema builder to serialize. Must not be null.</param>
        /// <param name="options">Options for serialization. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <see cref="string"/> containing the JSON serialized schema.
        /// </returns>
        /// <remarks>
        /// This method builds the schema from the JsonSchemaBuilder and serializes it to a formatted JSON string.
        /// It's useful for saving schema definitions to files or sending them over network.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when schemaBuilder is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create a schema builder
        /// var builder = new JsonSchemaBuilder()
        ///     .Schema("https://json-schema.org/draft/2020-12/schema")
        ///     .Id("https://example.com/schemas/person")
        ///     .Title("Person")
        ///     .Type(SchemaValueType.Object)
        ///     .Properties(
        ///         ("name", new JsonSchemaBuilder().Type(SchemaValueType.String)),
        ///         ("age", new JsonSchemaBuilder().Type(SchemaValueType.Integer).Minimum(0))
        ///     );
        /// 
        /// // Serialize the schema
        /// string schemaJson = builder.Serialize();
        /// 
        /// // With custom options
        /// var options = new JsonSerializerOptions { WriteIndented = false };
        /// string compactSchemaJson = builder.Serialize(options);
        /// </code>
        /// </example>
        public static string Serialize(this JsonSchemaBuilder schemaBuilder, JsonSerializerOptions options = null)
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
        /// <param name="schema">Schema to serialize. Must not be null.</param>
        /// <param name="options">Options for serialization. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <see cref="string"/> containing the JSON serialized schema.
        /// </returns>
        /// <remarks>
        /// This method serializes a JsonSchema object to a formatted JSON string.
        /// It's useful for saving schema definitions to files or sending them over network.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when schema is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// // With an existing JsonSchema object
        /// JsonSchema schema = JsonSchema.FromText("{\"type\":\"object\",\"properties\":{\"name\":{\"type\":\"string\"}}}");
        /// 
        /// // Serialize the schema
        /// string schemaJson = schema.Serialize();
        /// 
        /// // With custom options
        /// var options = new JsonSerializerOptions { WriteIndented = false };
        /// string compactSchemaJson = schema.Serialize(options);
        /// </code>
        /// </example>
        public static string Serialize(this JsonSchema schema, JsonSerializerOptions options = null)
        {

            if (options == null)
                options = new JsonSerializerOptions
                {
                    WriteIndented = true,
                };

            return JsonSerializer.Serialize(schema, options);

        }

        /// <summary>
        /// Serializes the specified self instance to a configuration JSON string.
        /// </summary>
        /// <typeparam name="SourceType">The type of the object to serialize.</typeparam>
        /// <param name="self">The instance to serialize. May be null.</param>
        /// <param name="options">Options for serialization. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <see cref="string"/> containing the serialized configuration, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method serializes an object into a JSON string with a specific structure where
        /// the object is nested under a property named after its type. This format is designed
        /// to be compatible with the DeserializesConfiguration method.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// public class ServerConfig
        /// {
        ///     public string Host { get; set; } = "localhost";
        ///     public int Port { get; set; } = 8080;
        /// }
        /// 
        /// // Serialize a configuration
        /// var config = new ServerConfig { Host = "example.com", Port = 443 };
        /// string json = config.SerializeConfiguration();
        /// // Result: {"ServerConfig":{"Host":"example.com","Port":443}}
        /// 
        /// // With custom serialization options
        /// var options = new JsonSerializerOptions { WriteIndented = false };
        /// string compactJson = config.SerializeConfiguration(options);
        /// </code>
        /// </example>
        public static string SerializeConfiguration<SourceType>(this SourceType self, JsonSerializerOptions options = null)
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
        /// Deserializes the specified payload into a strongly typed configuration object.
        /// </summary>
        /// <typeparam name="TargetType">The type of the target object to deserialize to.</typeparam>
        /// <param name="payload">The JSON string payload to deserialize. Must not be null or empty.</param>
        /// <param name="options">Options for deserialization. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <see cref="TargetType"/> instance deserialized from the JSON payload, or null if deserialization fails.
        /// </returns>
        /// <remarks>
        /// This method deserializes a JSON string with a specific structure where
        /// the object is expected to be nested under a property named after its type.
        /// It's designed to work with JSON produced by the SerializeConfiguration method.
        /// </remarks>
        /// <exception cref="JsonException">Thrown when the JSON is invalid or doesn't match the expected structure.</exception>
        /// <exception cref="ArgumentNullException">Thrown when payload is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// public class ServerConfig
        /// {
        ///     public string Host { get; set; } = "localhost";
        ///     public int Port { get; set; } = 8080;
        /// }
        /// 
        /// // JSON string with the configuration in the expected format
        /// string json = "{\"ServerConfig\":{\"Host\":\"example.com\",\"Port\":443}}";
        /// 
        /// // Deserialize the configuration
        /// ServerConfig config = json.DeserializesConfiguration&lt;ServerConfig&gt;();
        /// 
        /// Console.WriteLine($"Host: {config.Host}, Port: {config.Port}");
        /// // Output: Host: example.com, Port: 443
        /// </code>
        /// </example>
        public static TargetType DeserializesConfiguration<TargetType>(this string payload, JsonSerializerOptions options = null)
            where TargetType : class
        {
            return payload.DeserializesConfiguration(typeof(TargetType), options) as TargetType;
        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <param name="payload">the instance to serialize.</param>
        /// <param name="targetType">target Type</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/>options of serialization</param>
        /// <returns></returns>
        public static object DeserializesConfiguration(this string payload, Type targetType, JsonSerializerOptions options = null)
        {

            using (JsonDocument doc = JsonDocument.Parse(payload))
            {

                options ??= new JsonSerializerOptions { WriteIndented = true };

                var element = doc.RootElement.GetProperty(targetType.Name);
                var instance = element.Deserialize(targetType, options);
                return instance;
            }

        }

    }

    /// <summary>
    /// Helper struct for serializing a configuration object with a standardized wrapper.
    /// </summary>
    /// <typeparam name="T">The type of configuration object to wrap.</typeparam>
    /// <remarks>
    /// This struct is used internally by the GenerateSchemaForConfiguration method
    /// to provide a consistent structure for configuration objects in JSON schemas.
    /// </remarks>
    public struct ConfigurationSerializer<T>
    {
        /// <summary>
        /// Gets or sets the configuration object.
        /// </summary>
        public T Configuration { get; set; }
    }


}

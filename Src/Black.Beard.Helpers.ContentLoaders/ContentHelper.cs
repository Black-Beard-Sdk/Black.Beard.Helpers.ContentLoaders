using System.Text;
using System.Text.Json;

namespace Bb
{

    public static partial class ContentHelper
    {

        /// <summary>
        /// Execute : Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
        /// Register exotic encoding provider.
        /// </summary>
        /// <example>
        /// <code lang="csharp">
        /// ContentHelper.RegisterEncoding();
        /// </code>
        /// </example>
        public static void RegisterEncoding()
        {
            if (_registered)
                lock (_lock)
                    if (_registered)
                    {
                        _registered = true;
                        Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);
                    }
        }



        /// <summary>
        /// Loads the content from a byte array and converts it to a string, detecting the encoding automatically.
        /// </summary>
        /// <param name="text">The byte array containing the text to load. May be null.</param>
        /// <returns>
        /// A <see cref="string"/> containing the decoded text with BOM and other special characters removed, or null if input is null.
        /// </returns>
        /// <remarks>
        /// This method performs the following operations:
        /// 1. Detects the character encoding of the text using the Ude.CharsetDetector
        /// 2. Converts the byte array to a string using the detected encoding
        /// 3. Removes the BOM (Byte Order Mark) if present
        /// 4. Converts the text to UTF-8 if it was in a different encoding
        /// 5. Removes any special characters like zero-width non-breaking spaces (U+FEFF)
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Load and detect encoding from a byte array
        /// byte[] fileBytes = File.ReadAllBytes("example.txt");
        /// string content = fileBytes.LoadContentFromText();
        /// 
        /// // Process text from different encodings
        /// byte[] iso8859Bytes = Encoding.GetEncoding("ISO-8859-1").GetBytes("Café au lait");
        /// string decoded = iso8859Bytes.LoadContentFromText();
        /// Console.WriteLine(decoded); // Correctly displays: "Café au lait"
        /// </code>
        /// </example>
        public static string LoadContentFromText(this byte[] text)
        {

            if (text == null)
                return default;

            string textContents = string.Empty;
            Encoding encoding = Encoding.UTF8;

            using (MemoryStream fs = new MemoryStream(text))
            {

                Ude.CharsetDetector cdet = new Ude.CharsetDetector();
                cdet.Feed(fs);
                cdet.DataEnd();
                if (cdet.Charset != null)
                    encoding = Encoding.GetEncoding(cdet.Charset);
                else
                    encoding = Encoding.UTF8;

                fs.Position = 0;

                byte[] ar = new byte[text.Length];
                fs.Read(ar, 0, ar.Length);
                textContents = encoding.GetString(ar);
            }

            if (textContents.StartsWith("ï»¿"))
                textContents = textContents.Substring(3);

            if (encoding != Encoding.UTF8)
            {
                var datas = Encoding.UTF8.GetBytes(textContents);
                textContents = Encoding.UTF8.GetString(datas);
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
        /// Converts a memory stream to a string, detecting the encoding automatically.
        /// </summary>
        /// <param name="self">The memory stream to convert. May be null.</param>
        /// <returns>
        /// A <see cref="string"/> containing the decoded content of the memory stream, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method converts the memory stream to a byte array and then uses the LoadContentFromText method
        /// to detect the encoding and convert it to a string. It handles null input by returning null.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Create a memory stream with some content
        /// string original = "Hello, world!";
        /// byte[] bytes = Encoding.UTF8.GetBytes(original);
        /// using (var memoryStream = new MemoryStream(bytes))
        /// {
        ///     // Convert the memory stream to a string
        ///     string result = memoryStream.ConvertToString();
        ///     Console.WriteLine(result); // Outputs: "Hello, world!"
        /// }
        /// </code>
        /// </example>
        public static string? ConvertToString(this MemoryStream self)
        {

            if (self != null)
                return self.ToArray().LoadContentFromText();

            return default;

        }



        /// <summary>
        /// Encodes the specified string as a Base64 string.
        /// </summary>
        /// <param name="self">The string to encode. May be null or empty.</param>
        /// <returns>
        /// A <see cref="string"/> containing the Base64 encoded value, or null if the input is null.
        /// An empty string is returned if the input is empty.
        /// </returns>
        /// <remarks>
        /// This method encodes a string to Base64 using UTF-8 encoding.
        /// Base64 encoding is commonly used when binary data needs to be transmitted in text-based formats
        /// or stored in text-based systems.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Encode a regular string to Base64
        /// string original = "Hello, world!";
        /// string encoded = original.ConvertToBase64();
        /// Console.WriteLine(encoded); // Outputs: "SGVsbG8sIHdvcmxkIQ=="
        /// 
        /// // Encode an empty string
        /// string emptyResult = "".ConvertToBase64();
        /// Console.WriteLine(emptyResult); // Outputs: ""
        /// </code>
        /// </example>
        public static string ConvertToBase64(this string self)
        {

            if (self != null)
            {

                if (string.IsNullOrEmpty(self))
                    return string.Empty;

                byte[] bytes = System.Text.Encoding.UTF8.GetBytes(self);
                var result = Convert.ToBase64String(bytes);
                return result;

            }

            return default;

        }


        /// <summary>
        /// Decode the specified base 64 <see cref="string"/> encoded value.
        /// </summary>
        /// <param name="self">The Base64 encoded string to decode. May be null or empty.</param>
        /// <returns>
        /// A <see cref="string"/> containing the decoded value, or null if the input is null.
        /// An empty string is returned if the input is empty.
        /// </returns>
        /// <remarks>
        /// This method decodes a Base64 string back to its original value using UTF-8 encoding.
        /// It's the inverse operation of ConvertToBase64.
        /// </remarks>
        /// <exception cref="System.FormatException">Thrown when the input is not a valid Base64 string.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Decode a Base64 string
        /// string encoded = "SGVsbG8sIHdvcmxkIQ==";
        /// string decoded = encoded.ConvertFromBase64();
        /// Console.WriteLine(decoded); // Outputs: "Hello, world!"
        /// 
        /// // Decode an empty string
        /// string emptyResult = "".ConvertFromBase64();
        /// Console.WriteLine(emptyResult); // Outputs: ""
        /// 
        /// try {
        ///     // This will throw a FormatException
        ///     string invalid = "Not a valid Base64 string!";
        ///     string result = invalid.ConvertFromBase64();
        /// } catch (FormatException ex) {
        ///     Console.WriteLine("Invalid Base64 input");
        /// }
        /// </code>
        /// </example>
        public static string? ConvertFromBase64(this string self)
        {

            if (self != null)
            {
                if (string.IsNullOrEmpty(self))
                    return string.Empty;

                byte[] bytes = Convert.FromBase64String(self); ;
                string result = System.Text.Encoding.UTF8.GetString(bytes);

                return result;
            }

            return default;

        }


        /// <summary>
        /// Serializes with indentation the specified object.
        /// </summary>
        /// <param name="self">The object to serialize. May be null.</param>
        /// <param name="options"><see cref="JsonSerializerOptions"/> to control JSON serialization behavior.</param>
        /// <returns>
        /// A <see cref="string"/> containing the JSON representation of the object, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method serializes an object to a JSON string using System.Text.Json.
        /// It uses the provided JsonSerializerOptions to control serialization behavior.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when options is null.</exception>
        /// <exception cref="JsonException">Thrown when the object cannot be serialized to JSON.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create an object to serialize
        /// var person = new { Name = "John", Age = 30 };
        /// 
        /// // Serialize with default options
        /// var options = new JsonSerializerOptions { WriteIndented = true };
        /// string json = person.Serialize(options);
        /// Console.WriteLine(json);
        /// /* Output:
        /// {
        ///   "Name": "John",
        ///   "Age": 30
        /// }
        /// */
        /// </code>
        /// </example>
        public static string? Serialize(this object self, JsonSerializerOptions options)
        {
            if (self != null)
                return JsonSerializer.Serialize(self, options);
            return default;
        }


        /// <summary>
        /// Serializes the specified self instance in a memory.
        /// </summary>
        /// <param name="self">The object to serialize. May be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control serialization behavior. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <see cref="MemoryStream"/> containing the serialized JSON data, positioned at the beginning of the stream.
        /// </returns>
        /// <remarks>
        /// This method serializes an object to a memory stream in JSON format.
        /// It uses the SerializeToStream method internally and ensures that the stream position is reset to the beginning
        /// after serialization so that the stream is ready to be read.
        /// </remarks>
        /// <exception cref="JsonException">Thrown when the object cannot be serialized to JSON.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create an object to serialize
        /// var person = new { Name = "Jane", Age = 25 };
        /// 
        /// // Serialize to a memory stream
        /// using (var stream = person.SerializeToMemory())
        /// {
        ///     // Use the stream, e.g., copy to another stream
        ///     using (var fileStream = File.Create("person.json"))
        ///     {
        ///         stream.CopyTo(fileStream);
        ///     }
        ///     
        ///     // Or read it back as a string
        ///     stream.Position = 0;
        ///     using (var reader = new StreamReader(stream))
        ///     {
        ///         string json = reader.ReadToEnd();
        ///         Console.WriteLine(json);
        ///     }
        /// }
        /// </code>
        /// </example>
        public static MemoryStream SerializeToMemory(this object self, JsonSerializerOptions options = null)
        {
            var stream = new MemoryStream();
            self.SerializeToStream(stream, options);
            if (stream.Position > 0)
                stream.Position = 0;

            return stream;
        }

        /// <summary>
        /// Serializes the specified self instance in the stream.
        /// </summary>
        /// <param name="self">The object to serialize. May be null.</param>
        /// <param name="stream">The stream to write the serialized object to. Must not be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control serialization behavior. If null, default options with indented formatting will be used.</param>
        /// <remarks>
        /// This method serializes an object to a stream in JSON format using System.Text.Json.
        /// It uses a Utf8JsonWriter to write directly to the stream, which is more efficient than
        /// serializing to a string first and then writing the string to a stream.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when stream is null.</exception>
        /// <exception cref="JsonException">Thrown when the object cannot be serialized to JSON.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create an object to serialize
        /// var product = new { Id = 123, Name = "Widget", Price = 19.99 };
        /// 
        /// // Serialize to a file stream
        /// using (var fileStream = File.Create("product.json"))
        /// {
        ///     product.SerializeToStream(fileStream);
        /// }
        /// 
        /// // Serialize with custom options
        /// var options = new JsonSerializerOptions { WriteIndented = false };
        /// using (var memoryStream = new MemoryStream())
        /// {
        ///     product.SerializeToStream(memoryStream, options);
        ///     
        ///     // Convert to string if needed
        ///     memoryStream.Position = 0;
        ///     using (var reader = new StreamReader(memoryStream))
        ///     {
        ///         string json = reader.ReadToEnd();
        ///         Console.WriteLine(json); // Compact JSON without indentation
        ///     }
        /// }
        /// </code>
        /// </example>
        public static void SerializeToStream(this object self, Stream stream, JsonSerializerOptions options = null)
        {

            if (options == null)
                options = new JsonSerializerOptions() { WriteIndented = true };

            if (self != null)
            {

                var o = new JsonWriterOptions()
                {
                    Indented = options.WriteIndented
                };

                using (var wrt = new Utf8JsonWriter(stream, o))
                {

                    JsonSerializer.Serialize(wrt, self, options);
                    wrt.Flush();
                }

            }

        }



        /// <summary>
        /// Serializes with indentation the specified object.
        /// </summary>
        /// <param name="self">The object to serialize. May be null.</param>
        /// <param name="indented">If true, the JSON output will be indented for better readability; otherwise, it will be compact.</param>
        /// <returns>
        /// A <see cref="string"/> containing the JSON representation of the object, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method is a convenience wrapper around the Serialize method that takes a JsonSerializerOptions parameter.
        /// It creates a new JsonSerializerOptions with the WriteIndented property set to the specified value.
        /// </remarks>
        /// <exception cref="JsonException">Thrown when the object cannot be serialized to JSON.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Create an object to serialize
        /// var person = new { Name = "John", Age = 30 };
        /// 
        /// // Serialize with indentation
        /// string prettyJson = person.Serialize(true);
        /// Console.WriteLine(prettyJson);
        /// /* Output:
        /// {
        ///   "Name": "John",
        ///   "Age": 30
        /// }
        /// */
        /// 
        /// // Serialize without indentation
        /// string compactJson = person.Serialize(false);
        /// Console.WriteLine(compactJson);
        /// // Output: {"Name":"John","Age":30}
        /// </code>
        /// </example>
        public static string? Serialize(this object self, bool indented)
        {
            return self.Serialize(new JsonSerializerOptions() { WriteIndented = indented });
        }

        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <param name="stream">Source stream containing the JSON data. Must not be null.</param>
        /// <param name="targetType">Type to generate from the JSON data. Must not be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control deserialization behavior. If null, default options will be used.</param>
        /// <returns>
        /// An <see cref="object"/> of the specified type containing the deserialized data.
        /// </returns>
        /// <remarks>
        /// This method deserializes JSON data from a stream into an object of the specified type.
        /// It uses System.Text.Json.JsonSerializer to perform the deserialization.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when stream or targetType is null.</exception>
        /// <exception cref="JsonException">Thrown when the JSON data is invalid or doesn't match the target type's structure.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Define a class to deserialize into
        /// public class Product
        /// {
        ///     public int Id { get; set; }
        ///     public string Name { get; set; }
        ///     public decimal Price { get; set; }
        /// }
        /// 
        /// // JSON data in a file
        /// using (var fileStream = File.OpenRead("product.json"))
        /// {
        ///     // Deserialize to the Product type
        ///     var product = fileStream.Deserialize(typeof(Product)) as Product;
        ///     
        ///     if (product != null)
        ///     {
        ///         Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
        ///     }
        /// }
        /// </code>
        /// </example>
        public static object Deserialize(this Stream stream, Type targetType, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize(stream, targetType, options ?? new JsonSerializerOptions());
        }


        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <typeparam name="T">Type to cast the result to.</typeparam>
        /// <param name="stream">Source stream containing the JSON data. Must not be null.</param>
        /// <param name="targetType">Type to generate from the JSON data. Must not be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control deserialization behavior. If null, default options will be used.</param>
        /// <returns>
        /// A <typeparamref name="T"/> object containing the deserialized data.
        /// </returns>
        /// <remarks>
        /// This method deserializes JSON data from a stream into an object of the specified target type,
        /// and then casts the result to type T. This is useful when you need to deserialize to one type but
        /// access the result through a base class or interface.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when stream or targetType is null.</exception>
        /// <exception cref="JsonException">Thrown when the JSON data is invalid or doesn't match the target type's structure.</exception>
        /// <exception cref="InvalidCastException">Thrown when the deserialized object cannot be cast to type T.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Base interface
        /// public interface IProduct 
        /// {
        ///     int Id { get; }
        ///     string Name { get; }
        /// }
        /// 
        /// // Implementation class
        /// public class Product : IProduct
        /// {
        ///     public int Id { get; set; }
        ///     public string Name { get; set; }
        ///     public decimal Price { get; set; }
        /// }
        /// 
        /// // JSON data in a memory stream
        /// string json = "{\"Id\":101,\"Name\":\"Widget Pro\",\"Price\":29.99}";
        /// using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        /// {
        ///     // Deserialize to Product but cast to IProduct interface
        ///     IProduct product = stream.Deserialize&lt;IProduct&gt;(typeof(Product));
        ///     
        ///     Console.WriteLine($"Product ID: {product.Id}, Name: {product.Name}");
        /// }
        /// </code>
        /// </example>
        public static T Deserialize<T>(this Stream stream, Type targetType, JsonSerializerOptions options = null)
        {
            return (T)JsonSerializer.Deserialize(stream, targetType, options ?? new JsonSerializerOptions());
        }

        /// <summary>
        /// Deserializes from the specified stream.
        /// </summary>
        /// <typeparam name="T">Type to generate from the JSON data.</typeparam>
        /// <param name="stream">Source stream containing the JSON data. Must not be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control deserialization behavior. If null, default options will be used.</param>
        /// <returns>
        /// A <typeparamref name="T"/> object containing the deserialized data.
        /// </returns>
        /// <remarks>
        /// This method deserializes JSON data from a stream directly into an object of type T.
        /// It uses System.Text.Json.JsonSerializer to perform the deserialization.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when stream is null.</exception>
        /// <exception cref="JsonException">Thrown when the JSON data is invalid or doesn't match the target type's structure.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Define a class to deserialize into
        /// public class User
        /// {
        ///     public string Username { get; set; }
        ///     public string Email { get; set; }
        ///     public int Age { get; set; }
        /// }
        /// 
        /// // JSON data in a memory stream
        /// string json = "{\"Username\":\"jdoe\",\"Email\":\"jdoe@example.com\",\"Age\":25}";
        /// using (var stream = new MemoryStream(Encoding.UTF8.GetBytes(json)))
        /// {
        ///     // Deserialize directly to the User type
        ///     User user = stream.Deserialize&lt;User&gt;();
        ///     
        ///     Console.WriteLine($"Username: {user.Username}, Email: {user.Email}, Age: {user.Age}");
        /// }
        /// </code>
        /// </example>
        public static T Deserialize<T>(this Stream stream, JsonSerializerOptions options = null)
        {
            return JsonSerializer.Deserialize<T>(stream, options ?? new JsonSerializerOptions());
        }



        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <typeparam name="SourceType">The type of object to deserialize the JSON data into.</typeparam>
        /// <param name="self">The JSON string to deserialize. May be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control deserialization behavior. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// A <typeparamref name="SourceType"/> object containing the deserialized data, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method deserializes a JSON string into an object of the specified type.
        /// It uses System.Text.Json.JsonSerializer to perform the deserialization.
        /// </remarks>
        /// <exception cref="JsonException">Thrown when the JSON string is invalid or doesn't match the target type's structure.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Define a class to deserialize into
        /// public class Person
        /// {
        ///     public string Name { get; set; }
        ///     public int Age { get; set; }
        ///     public string[] Hobbies { get; set; }
        /// }
        /// 
        /// // JSON string data
        /// string json = @"{
        ///   ""Name"": ""Alice"",
        ///   ""Age"": 28,
        ///   ""Hobbies"": [""Reading"", ""Hiking"", ""Photography""]
        /// }";
        /// 
        /// // Deserialize to the Person type
        /// Person person = json.Deserialize&lt;Person&gt;();
        /// 
        /// if (person != null)
        /// {
        ///     Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");
        ///     Console.WriteLine("Hobbies: " + string.Join(", ", person.Hobbies));
        /// }
        /// </code>
        /// </example>
        public static SourceType? Deserialize<SourceType>(this string self, JsonSerializerOptions? options = null)
        {

            if (self != null)
            {
                options ??= new JsonSerializerOptions { WriteIndented = true };
                var instance = JsonSerializer.Deserialize<SourceType>(self, options);
                return instance;
            }

            return default;

        }

        /// <summary>
        /// Deserializes the specified self payload.
        /// </summary>
        /// <param name="self">The JSON string to deserialize. May be null.</param>
        /// <param name="sourceType">Target type to deserialize the JSON data into. Must not be null.</param>
        /// <param name="options">Optional <see cref="JsonSerializerOptions"/> to control deserialization behavior. If null, default options with indented formatting will be used.</param>
        /// <returns>
        /// An <see cref="object"/> of the specified type containing the deserialized data, or null if the input is null.
        /// </returns>
        /// <remarks>
        /// This method deserializes a JSON string into an object of the specified type.
        /// It uses System.Text.Json.JsonSerializer to perform the deserialization.
        /// This non-generic version is useful when the target type is determined at runtime.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when sourceType is null.</exception>
        /// <exception cref="JsonException">Thrown when the JSON string is invalid or doesn't match the target type's structure.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Define a class to deserialize into
        /// public class Product
        /// {
        ///     public int Id { get; set; }
        ///     public string Name { get; set; }
        ///     public decimal Price { get; set; }
        /// }
        /// 
        /// // JSON string data
        /// string json = "{\"Id\":123,\"Name\":\"Widget\",\"Price\":19.99}";
        /// 
        /// // Get the type at runtime
        /// Type productType = typeof(Product);
        /// 
        /// // Deserialize to the Product type
        /// var product = json.Deserialize(productType) as Product;
        /// 
        /// if (product != null)
        /// {
        ///     Console.WriteLine($"Product: {product.Name}, Price: ${product.Price}");
        /// }
        /// </code>
        /// </example>
        public static object? Deserialize(this string self, Type sourceType, JsonSerializerOptions? options = null)
        {

            if (self != null)
            {
                options ??= new JsonSerializerOptions { WriteIndented = true };
                var instance = JsonSerializer.Deserialize(self, sourceType, options);
                return instance;
            }

            return default;

        }

        /// <summary>
        /// Extracts a byte array from a Stream.
        /// </summary>
        /// <param name="stream">The Stream to extract bytes from. May be null.</param>
        /// <returns>
        /// A byte array containing all the data from the stream, or null if the input stream is null.
        /// </returns>
        /// <remarks>
        /// This method copies all the data from the input stream to a memory stream, then
        /// converts that memory stream to a byte array. It does not modify the position
        /// or state of the original stream.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Convert a file stream to a byte array
        /// using (var fileStream = File.OpenRead("example.txt"))
        /// {
        ///     byte[] bytes = fileStream.ToBytes();
        ///     Console.WriteLine($"File size: {bytes.Length} bytes");
        ///     
        ///     // Use the bytes (e.g., compute a hash)
        ///     using (var sha = System.Security.Cryptography.SHA256.Create())
        ///     {
        ///         byte[] hash = sha.ComputeHash(bytes);
        ///         Console.WriteLine($"SHA256: {BitConverter.ToString(hash).Replace("-", "")}");
        ///     }
        /// }
        /// 
        /// // Convert a memory stream to a byte array
        /// using (var memoryStream = new MemoryStream())
        /// {
        ///     using (var writer = new StreamWriter(memoryStream, leaveOpen: true))
        ///     {
        ///         writer.Write("Hello, world!");
        ///         writer.Flush();
        ///     }
        ///     
        ///     memoryStream.Position = 0;
        ///     byte[] data = memoryStream.To/// <summary>
        /// Extracts a byte array from a Stream.
        /// </code>
        /// </example>
        public static byte[] ToBytes(this Stream stream)
        {

            if (stream == null)
                return null;

            using (MemoryStream memoryStream = new MemoryStream())
            {
                stream.CopyTo(memoryStream);
                return memoryStream.ToArray();
            }

        }

        private static bool _registered = false;
        private static object _lock = new object();

    }


}

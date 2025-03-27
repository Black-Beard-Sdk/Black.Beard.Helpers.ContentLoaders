using System;
using System.Text.RegularExpressions;

namespace Bb
{

    public static partial class UriExtensions
    {

        /// <summary>
        /// Creates a Uri from a URL string and additional path segments
        /// </summary>
        /// <param name="url">The base URL to convert to a Uri. Must be a valid absolute URI.</param>
        /// <param name="segments">Additional path segments to append to the base URI.</param>
        /// <returns>
        /// A <see cref="Uri"/> object representing the combined URL with all segments.
        /// </returns>
        /// <remarks>
        /// This method creates a URI from a base URL string and appends any additional path segments.
        /// Each segment is added to the URI using the Uri constructor that combines a base URI with a relative URI string.
        /// Null segments are ignored.
        /// </remarks>
        /// <exception cref="UriFormatException">Thrown when the URL is not a valid URI format.</exception>
        /// <exception cref="ArgumentNullException">Thrown when the URL is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// Uri uri1 = "http://localhost:80".ToUri("api", "users");
        /// // Result: http://localhost:80/api/users
        /// 
        /// Uri uri2 = "https://example.com".ToUri("path/with/slash");
        /// // Result: https://example.com/path/with/slash
        /// 
        /// // Handles null segments by ignoring them
        /// Uri uri3 = "http://localhost".ToUri("segment1", null, "segment2");
        /// // Result: http://localhost/segment1/segment2
        /// </code>
        /// </example>
        public static Uri ToUri(this string url, params string[] segments)
        {

            var uri = new Uri(url);

            foreach (var item in segments)
                if (item != null)
                    uri = new Uri(uri, item);

            return uri;

        }

        /// <summary>
        /// Creates a URI using the specified scheme, host, port, and path segments
        /// </summary>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="host">The host name or IP address. Must not be null or empty.</param>
        /// <param name="port">The port number to use.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// A <see cref="Uri"/> object representing the constructed URI with all segments.
        /// </returns>
        /// <remarks>
        /// This method constructs a URI by combining the scheme, host, and port into a base URI,
        /// then appends any additional path segments. Each segment is added using the Uri constructor
        /// that combines a base URI with a relative URI string.
        /// </remarks>
        /// <exception cref="UriFormatException">Thrown when the resulting URI is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when scheme or host is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// Uri uri1 = "http".ToUri("example.com", 8080, "api", "users");
        /// // Result: http://example.com:8080/api/users
        /// 
        /// Uri uri2 = "https".ToUri("localhost", 443, "secure", "endpoint");
        /// // Result: https://localhost:443/secure/endpoint
        /// 
        /// // Empty segments will result in consecutive slashes
        /// Uri uri3 = "http".ToUri("example.org", 80, "", "resource");
        /// // Result: http://example.org:80//resource
        /// </code>
        /// </example>
        public static Uri ToUri(this string scheme, string host, int port, params string[] segments)
        {


            var uri = new Uri($"{scheme}://{host}:{port}");

            foreach (var item in segments)
                uri = new Uri(uri, item);

            return uri;

        }

        /// <summary>
        /// Creates a URI using the specified scheme, host, and an available port starting from the provided port number
        /// </summary>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="host">The host name or IP address. Must not be null or empty.</param>
        /// <param name="port">The starting port number to find an available port. Will be updated with the actual port used.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// A <see cref="Uri"/> object representing the constructed URI with the first available port and all segments.
        /// </returns>
        /// <remarks>
        /// This method finds the first available port starting from the provided port number,
        /// then constructs a URI using the scheme, host, and that port. It updates the port parameter
        /// with the actual port used, and appends any additional path segments to the URI.
        /// </remarks>
        /// <exception cref="UriFormatException">Thrown when the resulting URI is not valid.</exception>
        /// <exception cref="ArgumentNullException">Thrown when scheme or host is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// int port = 8000;
        /// Uri uri = "http".ToUri("localhost", ref port, "api", "status");
        /// // If port 8000 is available:
        /// // Result: http://localhost:8000/api/status
        /// // port variable will be 8000
        /// 
        /// // If port 8000 is in use but 8001 is available:
        /// // Result: http://localhost:8001/api/status
        /// // port variable will be 8001
        /// 
        /// Console.WriteLine($"Using port: {port}");
        /// </code>
        /// </example>
        public static Uri ToUri(this string scheme, string host, ref int port, params string[] segments)
        {

            var first = HttpHelper.GetAvailablePort(port);
            var uri = new Uri($"{scheme}://{host}:{first}");

            foreach (var item in segments)
                uri = new Uri(uri, item);

            return uri;

        }


        /// <summary>
        /// Combines URL parts into a single URL string, ensuring proper separation between components
        /// </summary>
        /// <param name="parts">The URL parts to combine. May contain path segments, query parameters, and fragments.</param>
        /// <returns>
        /// A <see cref="string"/> representing the combined URL with properly encoded illegal characters.
        /// </returns>
        /// <remarks>
        /// This method combines URL parts into a single URL string, ensuring:
        /// - Exactly one '/' separates each path segment
        /// - Exactly one '&amp;' separates each query parameter
        /// - Proper handling of '?' for query string start
        /// - Proper handling of '#' for fragment start
        /// - URL-encoding of illegal characters but not reserved characters
        /// 
        /// The method is aware of the URL structure and treats parts differently based on whether they're
        /// in the path, query string, or fragment portion of the URL.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when parts is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// string url1 = UriExtensions.Combine("https://example.com", "api/users", "?id=123", "&amp;name=test");
        /// // Result: https://example.com/api/users?id=123&amp;name=test
        /// 
        /// string url2 = UriExtensions.Combine("api", "/users/", "/details", "?id=42", "#section");
        /// // Result: api/users/details?id=42#section
        /// 
        /// // Empty parts are ignored
        /// string url3 = UriExtensions.Combine("https://example.org", "", "resources");
        /// // Result: https://example.org/resources
        /// </code>
        /// </example>
        public static string Combine(params string[] parts)
        {
            if (parts == null)
                throw new ArgumentNullException(nameof(parts));

            string result = "";
            bool inQuery = false, inFragment = false;

            string CombineEnsureSingleSeparator(string a, string b, char separator)
            {
                if (string.IsNullOrEmpty(a)) return b;
                if (string.IsNullOrEmpty(b)) return a;
                return a.TrimEnd(separator) + separator + b.TrimStart(separator);
            }

            foreach (var part in parts)
            {
                if (string.IsNullOrEmpty(part))
                    continue;

                if (result.OrdinalEndsWith("?") || part.OrdinalStartsWith("?"))
                    result = CombineEnsureSingleSeparator(result, part, '?');
                else if (result.OrdinalEndsWith("#") || part.OrdinalStartsWith("#"))
                    result = CombineEnsureSingleSeparator(result, part, '#');
                else if (inFragment)
                    result += part;
                else if (inQuery)
                    result = CombineEnsureSingleSeparator(result, part, '&');
                else
                    result = CombineEnsureSingleSeparator(result, part, '/');

                if (part.OrdinalContains("#"))
                {
                    inQuery = false;
                    inFragment = true;
                }
                else if (!inFragment && part.OrdinalContains("?"))
                {
                    inQuery = true;
                }
            }
            return EncodeIllegalCharacters(result);
        }


        /// <summary>
        /// URL-encodes characters in a string that are neither reserved nor unreserved
        /// </summary>
        /// <param name="s">The string to encode. Can be null or empty.</param>
        /// <param name="encodeSpaceAsPlus">If true, spaces will be encoded as + signs. Otherwise, they'll be encoded as %20.</param>
        /// <returns>
        /// A <see cref="string"/> with illegal characters URL-encoded.
        /// </returns>
        /// <remarks>
        /// This method URL-encodes only characters that are neither reserved nor unreserved according to RFC 3986.
        /// It avoids encoding reserved characters such as '/', '?', '&amp;', etc.
        /// It also avoids double-encoding by not encoding '%' characters that are already part of a valid %-encoded sequence.
        /// 
        /// If encodeSpaceAsPlus is true, spaces will be encoded as '+' signs (which is common in query strings),
        /// otherwise they'll be encoded as '%20'.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// string encoded1 = UriExtensions.EncodeIllegalCharacters("path/with spaces?param=value&amp;other=value");
        /// // Result: path/with%20spaces?param=value&amp;other=value
        /// 
        /// string encoded2 = UriExtensions.EncodeIllegalCharacters("query with spaces", true);
        /// // Result: query+with+spaces
        /// 
        /// // Already encoded sequences remain intact
        /// string encoded3 = UriExtensions.EncodeIllegalCharacters("already%20encoded%20text");
        /// // Result: already%20encoded%20text
        /// </code>
        /// </example>
        public static string EncodeIllegalCharacters(string s, bool encodeSpaceAsPlus = false)
        {
            if (string.IsNullOrEmpty(s))
                return s;

            if (encodeSpaceAsPlus)
                s = s.Replace(" ", "+");

            // Uri.EscapeUriString mostly does what we want - encodes illegal characters only - but it has a quirk
            // in that % isn't illegal if it's the start of a %-encoded sequence https://stackoverflow.com/a/47636037/62600

            // no % characters, so avoid the regex overhead
            if (!s.OrdinalContains("%"))
                return Uri.EscapeUriString(s);

            // pick out all %-hex-hex matches and avoid double-encoding
            return Regex.Replace(s, "(.*?)((%[0-9A-Fa-f]{2})|$)", c =>
            {
                var a = c.Groups[1].Value; // group 1 is a sequence with no %-encoding - encode illegal characters
                var b = c.Groups[2].Value; // group 2 is a valid 3-character %-encoded sequence - leave it alone!
                return Uri.EscapeUriString(a) + b;
            });
        }

        /// <summary>
        /// Determines if a string ends with the specified value using ordinal comparison
        /// </summary>
        /// <param name="s">The string to check. Can be null.</param>
        /// <param name="value">The value to look for at the end of the string.</param>
        /// <param name="ignoreCase">If true, performs a case-insensitive comparison; otherwise, case-sensitive.</param>
        /// <returns>
        /// <see langword="true"/> if the string ends with the specified value; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method is a wrapper around String.EndsWith that uses ordinal comparison for better performance.
        /// It safely handles null strings by returning false.
        /// </remarks>
        internal static bool OrdinalEndsWith(this string s, string value, bool ignoreCase = false) =>
            s != null && s.EndsWith(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        /// <summary>
        /// Determines if a string starts with the specified value using ordinal comparison
        /// </summary>
        /// <param name="s">The string to check. Can be null.</param>
        /// <param name="value">The value to look for at the start of the string.</param>
        /// <param name="ignoreCase">If true, performs a case-insensitive comparison; otherwise, case-sensitive.</param>
        /// <returns>
        /// <see langword="true"/> if the string starts with the specified value; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method is a wrapper around String.StartsWith that uses ordinal comparison for better performance.
        /// It safely handles null strings by returning false.
        /// </remarks>
        internal static bool OrdinalStartsWith(this string s, string value, bool ignoreCase = false) =>
            s != null && s.StartsWith(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);

        /// <summary>
        /// Determines if a string contains the specified value using ordinal comparison
        /// </summary>
        /// <param name="s">The string to check. Can be null.</param>
        /// <param name="value">The value to search for within the string.</param>
        /// <param name="ignoreCase">If true, performs a case-insensitive comparison; otherwise, case-sensitive.</param>
        /// <returns>
        /// <see langword="true"/> if the string contains the specified value; otherwise, <see langword="false"/>.
        /// </returns>
        /// <remarks>
        /// This method is a wrapper around String.IndexOf that uses ordinal comparison for better performance.
        /// It safely handles null strings by returning false.
        /// </remarks>
        internal static bool OrdinalContains(this string s, string value, bool ignoreCase = false) =>
            s != null && s.IndexOf(value, ignoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal) >= 0;


    }

}

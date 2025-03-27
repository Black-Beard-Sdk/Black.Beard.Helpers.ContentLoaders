
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Bb
{

    public static partial class UriExtensions
    {



        /// <summary>
        /// return a <see cref="StringBuilder"/> with Concatenated url separated by ';'.
        /// </summary>
        /// <param name="urls">Collection of <see cref="Uri"/> objects to concatenate. Must not be null.</param>
        /// <returns>
        /// A <see cref="StringBuilder"/> containing the concatenated URLs separated by semicolons.
        /// </returns>
        /// <remarks>
        /// This method concatenates all URIs in the collection into a single string, with each URI separated by a semicolon.
        /// All URIs are converted to lowercase.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when urls is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// var list = new List&lt;Uri&gt;();
        /// list.Add(new Uri("http://localhost:8080"));
        /// list.Add(new Uri("http1://localhost:8081"));
        /// StringBuilder paths = list.ConcatUrl();
        /// // result : http://localhost:8080;http1://localhost:8081
        /// </code>
        /// </example>
        public static StringBuilder ConcatUrl(this IEnumerable<Uri> urls)
        {
            return urls.ConcatUrl(new StringBuilder());
        }


        /// <summary>
        /// return a <see cref="StringBuilder"/> with Concatenated url separated by ';'.
        /// </summary>
        /// <param name="sb">The StringBuilder to append URLs to. If null, a new StringBuilder with capacity 200 will be created.</param>
        /// <param name="urls">Collection of <see cref="Uri"/> objects to concatenate. Must not be null.</param>
        /// <returns>
        /// A <see cref="StringBuilder"/> containing the concatenated URLs separated by semicolons.
        /// </returns>
        /// <remarks>
        /// This method concatenates all URIs in the collection into the provided StringBuilder, with each URI separated by a semicolon.
        /// All URIs are converted to lowercase. If the provided StringBuilder is null, a new one with capacity 200 is created.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when urls is null.</exception>
        /// <example>
        /// <code lang="C#">
        /// var list = new List&lt;Uri&gt;();
        /// list.Add(new Uri("http://localhost:8080"));
        /// list.Add(new Uri("http1://localhost:8081"));
        /// StringBuilder result = list.ConcatUrl(new StringBuilder(200));
        /// // result : http://localhost:8080;http1://localhost:8081
        /// </code>
        /// </example>
        public static StringBuilder ConcatUrl(this IEnumerable<Uri> urls, StringBuilder sb)
        {
            if (sb == null)
                sb = new StringBuilder(200);

            string comma = string.Empty;
            foreach (var url in urls)
            {
                sb.Append(comma);
                sb.Append(url.ToString().ToLower());
                comma = ";";
            }

            return sb;

        }



        #region Manage starting urls and ports


        /// <summary>
        /// Adds multiple localhost URLs with dynamically selected available ports to a URI list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="startPorts">Starting port number to search for available ports. Will be updated to the last used port + 1.</param>
        /// <param name="count">Number of URIs to add. Must be greater than 0.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds multiple localhost URIs to the list, each with a dynamically selected available port.
        /// It finds sequential available ports starting from the startPorts parameter.
        /// The startPorts parameter is updated to the last used port + 1 when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when count is less than 1 or startPorts is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// int startPort = 8000;
        /// 
        /// // Add 3 localhost URIs with HTTP scheme and available ports
        /// uris.AddLocalhostUrl("http", ref startPort, 3);
        /// // Result might be: http://localhost:8000, http://localhost:8001, http://localhost:8002
        /// // startPort will be set to the last used port + 1 (e.g., 8003)
        /// 
        /// // Add 2 more URIs with HTTPS scheme
        /// uris.AddLocalhostUrl("https", ref startPort, 2);
        /// // Result might add: https://localhost:8003, https://localhost:8004
        /// // startPort will be updated again
        /// </code>
        /// </example>
        public static List<Uri> AddLocalhostUrl(this List<Uri> self, string scheme, ref int startPorts, int count = 1)
        {

            int _first = startPorts;

            List<string> ports = new List<string>();
            for (int i = 0; i < count; i++)
                self.AddLocalhostUrl(scheme, _first = HttpHelper.GetAvailablePort(_first) + 1);

            startPorts = _first;

            return self;

        }


        /// <summary>
        /// Adds a URI with the specified scheme, host, port, and path segments to the list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="hostName">The host name or IP address. Must not be null or empty.</param>
        /// <param name="port">The port number to use.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method creates a new URI with the specified scheme, host name, port, and path segments,
        /// then adds it to the list. The URI is constructed using the ToUri extension method.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self, scheme, or hostName is null.</exception>
        /// <exception cref="UriFormatException">Thrown when the resulting URI is not valid.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// 
        /// // Add a simple URI
        /// uris.AddUrl("http", "example.com", 8080);
        /// // Result: [http://example.com:8080/]
        /// 
        /// // Add a URI with path segments
        /// uris.AddUrl("https", "api.example.com", 443, "v1", "users");
        /// // Result: [http://example.com:8080/, https://api.example.com:443/v1/users]
        /// 
        /// // Method chaining
        /// uris.AddUrl("http", "localhost", 9000)
        ///     .AddUrl("http", "localhost", 9001);
        /// </code>
        /// </example>
        public static List<Uri> AddUrl(this List<Uri> self, string scheme, string hostName, int port, params string[] segments)
        {

            self.Add(scheme.ToUri(hostName, port, segments));

            return self;
        }


        /// <summary>
        /// Adds a localhost URI with the specified scheme, port, and path segments to the list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="port">The port number to use.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method is a convenience wrapper around the AddUrl method that uses "localhost" as the host name.
        /// It creates a new URI with the specified scheme, "localhost" as the host, the provided port, and path segments,
        /// then adds it to the list.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="UriFormatException">Thrown when the resulting URI is not valid.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// 
        /// // Add a simple localhost URI
        /// uris.AddLocalhostUrl("http", 8080);
        /// // Result: [http://localhost:8080/]
        /// 
        /// // Add a localhost URI with path segments
        /// uris.AddLocalhostUrl("https", 443, "api", "status");
        /// // Result: [http://localhost:8080/, https://localhost:443/api/status]
        /// 
        /// // Method chaining
        /// uris.AddLocalhostUrl("http", 9000)
        ///     .AddLocalhostUrl("http", 9001);
        /// </code>
        /// </example>
        public static List<Uri> AddLocalhostUrl(this List<Uri> self, string scheme, int port, params string[] segments)
        {
            self.AddUrl(scheme, "localhost", port, segments);
            return self;
        }


        /// <summary>
        /// Adds a secure (HTTPS) localhost URI with a dynamically selected available port to the list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds an HTTPS URI to the list with a dynamically selected available port.
        /// It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "https" as the scheme.
        /// The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// int port = 8000;
        /// 
        /// // Add a secure localhost URI with a dynamically selected port
        /// uris.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "secure");
        /// // Result might be: https://localhost:8000/api/secure if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URI, will use a different port
        /// uris.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "users");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static List<Uri> AddLocalhostSecureUrlWithDynamicPort(this List<Uri> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("https", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds a non-secure (HTTP) localhost URI with a dynamically selected available port to the list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds an HTTP URI to the list with a dynamically selected available port.
        /// It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "http" as the scheme.
        /// The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// int port = 8000;
        /// 
        /// // Add a non-secure localhost URI with a dynamically selected port
        /// uris.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "public");
        /// // Result might be: http://localhost:8000/api/public if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URI, will use a different port
        /// uris.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "metrics");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static List<Uri> AddLocalhostUrlWithDynamicPort(this List<Uri> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("http", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds a URI with the specified scheme, host, and a dynamically selected available port to the list.
        /// </summary>
        /// <param name="self">The list of URIs to add to. Must not be null.</param>
        /// <param name="scheme">The URI scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URI.</param>
        /// <returns>
        /// The <see cref="List{Uri}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds a URI to the list with a dynamically selected available port.
        /// It finds an available port starting from the startingPort parameter, ensuring the port is not already used
        /// by any URI in the list. The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var uris = new List&lt;Uri&gt;();
        /// int port = 8000;
        /// 
        /// // Add a URI with a dynamically selected port
        /// uris.AddLocalhostUrlWithDynamicPort("http", "example.local", ref port, "api");
        /// // Result might be: http://example.local:8000/api if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URI with a different scheme
        /// uris.AddLocalhostUrlWithDynamicPort("https", "secure.local", ref port, "api", "v1");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static List<Uri> AddLocalhostUrlWithDynamicPort(this List<Uri> self, string scheme, string host, ref int startingPort, params string[] segments)
        {

            var ports = self.Select(c => c.Port).OrderBy(c => c).ToList();

            startingPort = HttpHelper.GetAvailablePort(startingPort);

            while (ports.Contains(startingPort))
            {
                startingPort++;
                startingPort = HttpHelper.GetAvailablePort(startingPort);
            }

            self.AddUrl(scheme, host ?? "localhost", startingPort, segments);

            return self;
        }


        #endregion Manage starting urls and ports

    }


}

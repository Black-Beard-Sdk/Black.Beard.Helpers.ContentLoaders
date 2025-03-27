
using System.Text;
using System.Linq;
using System.Collections.Generic;
using System;

namespace Bb
{

    public static partial class UriExtensions
    {


        #region Manage starting urls and ports


        /// <summary>
        /// Adds multiple localhost URLs with dynamically selected available ports to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="scheme">The URL scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="startPorts">Starting port number to search for available ports. Will be updated to the last used port.</param>
        /// <param name="count">Number of URLs to add. Must be greater than 0.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds multiple localhost URLs to the string collection, each with a dynamically selected available port.
        /// It finds sequential available ports starting from the startPorts parameter.
        /// The startPorts parameter is updated to the last used port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when count is less than 1 or startPorts is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// int startPort = 8000;
        /// 
        /// // Add 3 localhost URLs with HTTP scheme and available ports
        /// urls.AddLocalhostUrl("http", ref startPort, 3);
        /// // Result might be: ["http://localhost:8001/", "http://localhost:8002/", "http://localhost:8003/"]
        /// // startPort will be set to the last used port (e.g., 8003)
        /// 
        /// // Add 2 more URLs with HTTPS scheme
        /// urls.AddLocalhostUrl("https", ref startPort, 2);
        /// // Result might add: ["https://localhost:8004/", "https://localhost:8005/"]
        /// // startPort will be updated again
        /// </code>
        /// </example>
        public static ICollection<string> AddLocalhostUrl(this ICollection<string> self, string scheme, ref int startPorts, int count = 1)
        {

            int _first = startPorts;

            List<string> ports = new List<string>();
            for (int i = 0; i < count; i++)
                self.AddLocalhostUrl(scheme, _first = HttpHelper.GetAvailablePort(_first) + 1);

            startPorts = _first;

            return self;

        }


        /// <summary>
        /// Adds a URL with the specified scheme, host, port, and path segments to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="scheme">The URL scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="hostName">The host name or IP address. Must not be null or empty.</param>
        /// <param name="port">The port number to use.</param>
        /// <param name="segments">Additional path segments to append to the URL.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method creates a new URL with the specified scheme, host name, port, and path segments,
        /// then adds it as a string to the collection. The URL is constructed using the ToUri extension method.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self, scheme, or hostName is null.</exception>
        /// <exception cref="UriFormatException">Thrown when the resulting URL is not valid.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// 
        /// // Add a simple URL
        /// urls.AddUrl("http", "example.com", 8080);
        /// // Result: ["http://example.com:8080/"]
        /// 
        /// // Add a URL with path segments
        /// urls.AddUrl("https", "api.example.com", 443, "v1", "users");
        /// // Result: ["http://example.com:8080/", "https://api.example.com:443/v1/users"]
        /// 
        /// // Method chaining
        /// urls.AddUrl("http", "localhost", 9000)
        ///     .AddUrl("http", "localhost", 9001);
        /// </code>
        /// </example>
        public static ICollection<string> AddUrl(this ICollection<string> self, string scheme, string hostName, int port, params string[] segments)
        {

            self.Add(scheme.ToUri(hostName, port, segments).ToString());

            return self;
        }


        /// <summary>
        /// Adds a localhost URL with the specified scheme, port, and path segments to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="scheme">The URL scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="port">The port number to use.</param>
        /// <param name="segments">Additional path segments to append to the URL.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method is a convenience wrapper around the AddUrl method that uses "localhost" as the host name.
        /// It creates a new URL with the specified scheme, "localhost" as the host, the provided port, and path segments,
        /// then adds it as a string to the collection.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="UriFormatException">Thrown when the resulting URL is not valid.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// 
        /// // Add a simple localhost URL
        /// urls.AddLocalhostUrl("http", 8080);
        /// // Result: ["http://localhost:8080/"]
        /// 
        /// // Add a localhost URL with path segments
        /// urls.AddLocalhostUrl("https", 443, "api", "status");
        /// // Result: ["http://localhost:8080/", "https://localhost:443/api/status"]
        /// 
        /// // Method chaining
        /// urls.AddLocalhostUrl("http", 9000)
        ///     .AddLocalhostUrl("http", 9001);
        /// </code>
        /// </example>
        public static ICollection<string> AddLocalhostUrl(this ICollection<string> self, string scheme, int port, params string[] segments)
        {
            self.AddUrl(scheme, "localhost", port, segments);
            return self;
        }


        /// <summary>
        /// Adds a secure (HTTPS) localhost URL with a dynamically selected available port to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URL.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds an HTTPS URL to the collection with a dynamically selected available port.
        /// It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "https" as the scheme.
        /// The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// int port = 8000;
        /// 
        /// // Add a secure localhost URL with a dynamically selected port
        /// urls.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "secure");
        /// // Result might be: ["https://localhost:8000/api/secure"] if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URL, will use a different port
        /// urls.AddLocalhostSecureUrlWithDynamicPort("localhost", ref port, "api", "users");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static ICollection<string> AddLocalhostSecureUrlWithDynamicPort(this ICollection<string> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("https", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds a non-secure (HTTP) localhost URL with a dynamically selected available port to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URL.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds an HTTP URL to the collection with a dynamically selected available port.
        /// It's a convenience wrapper around AddLocalhostUrlWithDynamicPort that uses "http" as the scheme.
        /// The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// int port = 8000;
        /// 
        /// // Add a non-secure localhost URL with a dynamically selected port
        /// urls.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "public");
        /// // Result might be: ["http://localhost:8000/api/public"] if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URL, will use a different port
        /// urls.AddLocalhostUrlWithDynamicPort("localhost", ref port, "api", "metrics");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static ICollection<string> AddLocalhostUrlWithDynamicPort(this ICollection<string> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("http", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds a URL with the specified scheme, host, and a dynamically selected available port to a string collection.
        /// </summary>
        /// <param name="self">The collection of strings to add URLs to. Must not be null.</param>
        /// <param name="scheme">The URL scheme (e.g., "http", "https"). Must not be null or empty.</param>
        /// <param name="host">The host name. If null, "localhost" will be used.</param>
        /// <param name="startingPort">Starting port number to search for available ports. Will be updated to the port that was used.</param>
        /// <param name="segments">Additional path segments to append to the URL.</param>
        /// <returns>
        /// The <see cref="ICollection{String}"/> instance for method chaining.
        /// </returns>
        /// <remarks>
        /// This method adds a URL to the collection with a dynamically selected available port.
        /// It finds an available port starting from the startingPort parameter, ensuring the port is not already used
        /// by any URL in the collection. The startingPort parameter is updated to the selected port when the method returns.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when self or scheme is null.</exception>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is outside the valid port range.</exception>
        /// <example>
        /// <code lang="C#">
        /// var urls = new List&lt;string&gt;();
        /// int port = 8000;
        /// 
        /// // Add a URL with a dynamically selected port
        /// urls.AddLocalhostUrlWithDynamicPort("http", "example.local", ref port, "api");
        /// // Result might be: ["http://example.local:8000/api"] if port 8000 is available
        /// // port will be set to 8000
        /// 
        /// // Add another URL with a different scheme
        /// urls.AddLocalhostUrlWithDynamicPort("https", "secure.local", ref port, "api", "v1");
        /// // port will be updated to the newly selected port
        /// Console.WriteLine($"Selected port: {port}");
        /// </code>
        /// </example>
        public static ICollection<string> AddLocalhostUrlWithDynamicPort(this ICollection<string> self, string scheme, string host, ref int startingPort, params string[] segments)
        {

            var ports = self.Select(c => new Uri(c).Port).OrderBy(c => c).ToList();

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

using System;
using System.Linq;
using System.Collections.Generic;

namespace Bb
{

    /// <summary>
    /// Helper class for HTTP related operations
    /// </summary>
    /// <remarks>
    /// This class provides utilities for working with HTTP, including generating URIs
    /// and finding available network ports.
    /// </remarks>
    public static class HttpHelper
    {

        /// <summary>
        /// Creates a URI for the local machine (localhost)
        /// </summary>
        /// <param name="securised">If true, uses HTTPS protocol; otherwise, uses HTTP</param>
        /// <param name="port">The port number to use. If 0, the default port for the protocol will be used</param>
        /// <returns>
        /// A <see cref="Uri"/> for accessing the local machine with the specified protocol and port
        /// </returns>
        /// <remarks>
        /// This method creates a URI for the local machine using either HTTP or HTTPS protocol.
        /// It's a convenience wrapper around GetUri that uses "localhost" as the host name.
        /// </remarks>
        /// <example>
        /// <code lang="C#">
        /// // Get a URI for HTTP localhost
        /// Uri httpUri = HttpHelper.GetLocalUri(false);  // http://localhost/
        /// 
        /// // Get a URI for HTTPS localhost with specific port
        /// Uri httpsUri = HttpHelper.GetLocalUri(true, 8443);  // https://localhost:8443/
        /// </code>
        /// </example>
        public static Uri GetLocalUri(bool securised, int port = 0)
        {
            return GetUri(securised, "localhost", port);
        }

        /// <summary>
        /// Creates a URI for the specified host
        /// </summary>
        /// <param name="securised">If true, uses HTTPS protocol; otherwise, uses HTTP</param>
        /// <param name="host">The host name or IP address. Must not be null or empty</param>
        /// <param name="port">The port number to use. If 0, the default port for the protocol will be used</param>
        /// <returns>
        /// A <see cref="Uri"/> for accessing the specified host with the specified protocol and port
        /// </returns>
        /// <remarks>
        /// This method creates a URI using the specified host, protocol, and port.
        /// If port is 0, the default port for the protocol will be used (80 for HTTP, 443 for HTTPS).
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when host is null</exception>
        /// <example>
        /// <code lang="C#">
        /// // Get a URI for HTTP
        /// Uri httpUri = HttpHelper.GetUri(false, "example.com");  // http://example.com/
        /// 
        /// // Get a URI for HTTPS with specific port
        /// Uri httpsUri = HttpHelper.GetUri(true, "example.com", 8443);  // https://example.com:8443/
        /// 
        /// // Get a URI with an IP address
        /// Uri ipUri = HttpHelper.GetUri(false, "192.168.1.100", 8080);  // http://192.168.1.100:8080/
        /// </code>
        /// </example>
        public static Uri GetUri(bool securised, string host, int port = 0)
        {
            var uri = new UriBuilder();
            uri.Scheme = securised ? "https" : "http";
            uri.Host = host;
            uri.Port = port;
            return uri.Uri;
        }

        /// <summary>
        /// Finds an available TCP port starting from the specified port number
        /// </summary>
        /// <param name="startingPort">The minimum port number to consider. Must be between 1 and 65535</param>
        /// <returns>
        /// An available port number, or -1 if no ports are available
        /// </returns>
        /// <remarks>
        /// This method searches for an available port by:
        /// 1. Getting all currently used ports from active TCP connections
        /// 2. Getting all ports from active TCP listeners
        /// 3. Getting all ports from active UDP listeners
        /// 4. Finding the first available port number starting from the specified port
        /// 
        /// It's important to note that there is a small race condition where the port might become
        /// unavailable between the check and when you actually use it.
        /// </remarks>
        /// <exception cref="ArgumentOutOfRangeException">Thrown when startingPort is less than 1 or greater than 65535</exception>
        /// <example>
        /// <code lang="C#">
        /// // Find an available port starting from 8000
        /// int port = HttpHelper.GetAvailablePort(8000);
        /// Console.WriteLine($"Found available port: {port}");
        /// 
        /// // Use the port in a URI
        /// Uri uri = HttpHelper.GetLocalUri(false, port);
        /// </code>
        /// </example>
        public static int GetAvailablePort(int startingPort)
        {

            var portArrayList = new List<int>();

            var properties = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties();

            // Ignore active connections
            var connections = properties.GetActiveTcpConnections();
            portArrayList.AddRange(from n in connections
                                   where n.LocalEndPoint.Port >= startingPort
                                   select n.LocalEndPoint.Port);

            // Ignore active tcp listeners
            var endPoints = properties.GetActiveTcpListeners();
            portArrayList.AddRange(from n in endPoints
                                   where n.Port >= startingPort
                                   select n.Port);

            // Ignore active UDP listeners
            endPoints = properties.GetActiveUdpListeners();
            portArrayList.AddRange(from n in endPoints
                                   where n.Port >= startingPort
                                   select n.Port);

            portArrayList.Sort();

            for (var i = startingPort; i < ushort.MaxValue; i++)
                if (!portArrayList.Contains(i))
                    return i;

            return -1;

        }

    }


}
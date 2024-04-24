
using System;
using System.Linq;
using System.Collections.Generic;

namespace Bb
{

    /// <summary>
    /// get available port
    /// </summary>
    public static class HttpHelper
    {

        /// <summary>
        /// Return a local uri with first available port from specified port.
        /// </summary>
        /// <param name="securised"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// Uri uri = HttpHelper.GetLocalUri(true, 8080);
        /// </code>
        /// </example>
        public static Uri GetLocalUri(bool securised, int port = 0)
        {
            return GetUri(securised, "localhost", port);
        }

        /// <summary>
        /// Return a uri with first available port from specified port.
        /// </summary>
        /// <param name="securised"></param>
        /// <param name="host"></param>
        /// <param name="port"></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// Uri uri = HttpHelper.GetLocalUri(true, "localhost", 8080);
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
        /// Gets the first available port.
        /// </summary>
        /// <param name="startingPort">The starting port.</param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// int port = HttpHelper.GetAvailable(8080);
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
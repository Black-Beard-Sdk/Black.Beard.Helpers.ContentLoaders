
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
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="startPorts">The starting range port</param>
        /// <param name="count">The count range port</param>
        /// <returns></returns>
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
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="hostName">The host name to listen</param>
        /// <param name="port">The port to listen.</param>
        /// <param name="segments">The segments to add to the url</param>
        /// <returns></returns>
        public static ICollection<string> AddUrl(this ICollection<string> self, string scheme, string hostName, int port, params string[] segments)
        {

            self.Add(scheme.ToUri(hostName, port, segments).ToString());

            return self;
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="port">The port to listen</param>
        /// <param name="segments">The segments to add to the url</param>
        /// <returns></returns>
        public static ICollection<string> AddLocalhostUrl(this ICollection<string> self, string scheme, int port, params string[] segments)
        {
            self.AddUrl(scheme, "localhost", port, segments);
            return self;
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <param name="segments">The segments to add to the url</param>
        /// <returns></returns>
        public static ICollection<string> AddLocalhostSecureUrlWithDynamicPort(this ICollection<string> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("https", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <param name="segments">The segments to add to the url</param>
        /// <returns></returns>
        public static ICollection<string> AddLocalhostUrlWithDynamicPort(this ICollection<string> self, string host, ref int startingPort, params string[] segments)
        {
            return self.AddLocalhostUrlWithDynamicPort("http", host, ref startingPort, segments);
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <param name="segments">The segments to add to the url</param>
        /// <returns></returns>
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

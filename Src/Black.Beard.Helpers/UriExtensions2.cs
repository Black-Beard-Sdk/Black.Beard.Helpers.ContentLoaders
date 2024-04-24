
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
        /// <param name="urls"><see cref="Url"/></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var list = new List&lt;Uri&gt;();
        /// list.Add(new Uri("http://localhost:8080"));
        /// list.Add(new Uri("http1://localhost:8081"));
        /// StringBuilder paths = list.ConcatUrl();
        /// </code>
        /// </example>
        public static StringBuilder ConcatUrl(this IEnumerable<Uri> urls)
        {
            return urls.ConcatUrl(new StringBuilder());
        }


        /// <summary>
        /// return a <see cref="StringBuilder"/> with Concatenated url separated by ';'.
        /// </summary>
        /// <param name="sb"><see cref="StringBuilder"/></param>
        /// <param name="urls"><see cref="Url"/></param>
        /// <returns></returns>
        /// <example>
        /// <code lang="csharp">
        /// var list = new List&lt;Uri&gt;();
        /// list.Add(new Uri("http://localhost:8080"));
        /// list.Add(new Uri("http1://localhost:8081"));
        /// list.ConcatUrl(new StringBuilder(200));
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
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="startPorts">The starting range port</param>
        /// <param name="count">The count range port</param>
        /// <returns></returns>
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
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="hostName">The host name to listen</param>
        /// <param name="port">The port to listen.</param>
        /// <returns></returns>
        public static List<Uri> AddUrl(this List<Uri> self, string scheme, string hostName, int port)
        {

            self.Add(scheme.ToUri(hostName, port));

            return self;
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="port">The port to listen</param>
        /// <returns></returns>
        public static List<Uri> AddLocalhostUrl(this List<Uri> self, string scheme, int port)
        {
            self.AddUrl(scheme, "localhost", port);
            return self;
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <returns></returns>
        public static List<Uri> AddLocalhostSecureUrlWithDynamicPort(this List<Uri> self, string host, ref int startingPort)
        {
            return self.AddLocalhostUrlWithDynamicPort("https", host, ref startingPort);
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <returns></returns>
        public static List<Uri> AddLocalhostUrlWithDynamicPort(this List<Uri> self, string host, ref int startingPort)
        {
            return self.AddLocalhostUrlWithDynamicPort("http", host, ref startingPort);
        }


        /// <summary>
        /// Adds an <see cref="Url"/> on the list of listeners.
        /// </summary>
        /// <param name="scheme">The scheme protocol.</param>
        /// <param name="host">The host name. if null localhost is used by default</param>
        /// <param name="startingPort">starting port to search.</param>
        /// <returns></returns>
        public static List<Uri> AddLocalhostUrlWithDynamicPort(this List<Uri> self, string scheme, string host, ref int startingPort)
        {

            var ports = self.Select(c => c.Port).OrderBy(c => c).ToList();

            startingPort = HttpHelper.GetAvailablePort(startingPort);

            while (ports.Contains(startingPort))
            {
                startingPort++;
                startingPort = HttpHelper.GetAvailablePort(startingPort);
            }

            self.AddUrl(scheme, host ?? "localhost", startingPort);

            return self;
        }


        #endregion Manage starting urls and ports

    }


}

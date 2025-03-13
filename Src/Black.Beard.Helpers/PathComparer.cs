using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;

namespace Bb
{

    /// <summary>
    /// Compares file and directory paths for equality.
    /// </summary>
    public class PathComparer : IEqualityComparer<string>
    {

        /// <summary>
        /// Determines whether the specified paths are equal.
        /// </summary>
        /// <param name="x">The first path.</param>
        /// <param name="y">The second path.</param>
        /// <returns><see langword="true"/> if the specified paths are equal; otherwise, <see langword="false"/>.</returns>
        /// <remarks>
        /// This method compares the full paths in a case-insensitive manner.
        /// </remarks>
        public bool Equals(string x, string y)
        {
            if (x == null || y == null)
                return false;

            var x1 = Path.GetFullPath(x).TrimEnd(Path.DirectorySeparatorChar);
            var y1 = Path.GetFullPath(y).TrimEnd(Path.DirectorySeparatorChar);

            StringComparison comparison =
                RuntimeInformation.IsOSPlatform(OSPlatform.Windows)
                ? StringComparison.OrdinalIgnoreCase
                : StringComparison.Ordinal
                ;

            var result = string.Equals(x1, y1, comparison);

            return result;
        }

        /// <summary>
        /// Returns a hash code for the specified path.
        /// </summary>
        /// <param name="obj">The path.</param>
        /// <returns>A hash code for the specified path.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the path is null.</exception>
        /// <remarks>
        /// This method returns a hash code for the full path in a case-insensitive manner.
        /// </remarks>
        public int GetHashCode(string obj)
        {
            if (obj == null)
                throw new ArgumentNullException(nameof(obj));

            return Path.GetFullPath(obj)
                .TrimEnd(Path.DirectorySeparatorChar)
                .ToLowerInvariant()
                .GetHashCode();
        }

    }



}

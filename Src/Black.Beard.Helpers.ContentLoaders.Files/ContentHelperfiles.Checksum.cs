using System;
using System.IO;
using System.Security.Cryptography;
using System.Text;

namespace Bb
{




    public static partial class ContentHelperFiles
    {


        /// <summary>
        /// Generate the md5 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Md5(this string filePath)
        {

            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            using (var checksum = MD5.Create())
            using (var stream = File.OpenRead(filePath))
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }

        /// <summary>
        /// Generate the md5 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Md5(this FileInfo file)
        {

            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);

            using (var checksum = MD5.Create())
            using (var stream = file.OpenRead())
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }

        /// <summary>
        /// Generate the sha256 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Sha256(this string filePath)
        {

            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            using (var checksum = SHA256.Create())
            using (var stream = File.OpenRead(filePath))
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }

        /// <summary>
        /// Generate the sha256 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Sha256(this FileInfo file)
        {

            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);

            using (var checksum = SHA256.Create())
            using (var stream = file.OpenRead())
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }



        /// <summary>
        /// Generate the sha512 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Sha512(this string filePath)
        {

            if (!File.Exists(filePath))
                throw new FileNotFoundException(filePath);

            using (var checksum = SHA512.Create())
            using (var stream = File.OpenRead(filePath))
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }

        /// <summary>
        /// Generate the sha512 checksum of the file.
        /// </summary>
        /// <param name="filePath">file path</param>
        /// <exception cref="FileNotFoundException" >if file not found</exception>
        public static string Sha512(this FileInfo file)
        {

            if (!file.Exists)
                throw new FileNotFoundException(file.FullName);

            using (var checksum = SHA512.Create())
            using (var stream = file.OpenRead())
            {
                byte[] hash = checksum.ComputeHash(stream);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }

        }



    }


}

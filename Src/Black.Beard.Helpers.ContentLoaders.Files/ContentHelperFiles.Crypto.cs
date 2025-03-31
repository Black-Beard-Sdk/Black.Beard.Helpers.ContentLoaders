using System;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;


namespace Bb
{

    public static partial class ContentHelperFiles
    {

        /// <summary>
        /// Encrypts a file using AES-256 encryption and writes the encrypted content to a specified output file.
        /// </summary>
        /// <param name="filePath">The path of the file to encrypt. Must not be null or empty.</param>
        /// <param name="encryptionKey">The encryption key to use. Must be 32 characters long to match AES-256 requirements.</param>
        /// <param name="outputFilePath">The path where the encrypted file will be saved. Must not be null or empty.</param>
        /// <remarks>
        /// This method uses AES-256 encryption to securely encrypt the contents of the specified file.
        /// The encryption key must be exactly 32 characters long to meet the AES-256 key size requirement.
        /// The method also initializes a 16-byte IV (Initialization Vector) with default values.
        /// </remarks>
        /// <exception cref="FileNotFoundException">Thrown when the input file does not exist.</exception>
        /// <exception cref="ArgumentException">Thrown when the encryption key is not 32 characters long.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Encrypt a file
        /// string filePath = "example.txt";
        /// string encryptionKey = "12345678901234567890123456789012"; // 32 characters
        /// string outputFilePath = "example_encrypted.txt";
        /// 
        /// filePath.EncryptFileAes256(encryptionKey, outputFilePath);
        /// Console.WriteLine("File encrypted successfully.");
        /// </code>
        /// </example>
        public static void EncryptFileAes256(this string filePath, string encryptionKey, string outputFilePath)
        {
            var file = new FileInfo(filePath);
            file.Refresh();

            if (!file.Exists)
                throw new FileNotFoundException(filePath);

            if (encryptionKey.Length != 32)
                throw new ArgumentException("The encryption key must be 32 characters long.", nameof(encryptionKey));

            if (!IsAscii(encryptionKey))
                throw new ArgumentException("The encryption key must contain only ASCII characters.", nameof(encryptionKey));

            var targetFile = new FileInfo(outputFilePath);
            targetFile.Refresh();
            if (targetFile.Exists)
                targetFile.Delete();

            byte[] key = Encoding.ASCII.GetBytes(encryptionKey);
            byte[] iv = new byte[16]; 

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var fsInput = file.OpenRead())
                using (var fsOutput = new FileStream(outputFilePath, FileMode.Create))
                using (var cs = new CryptoStream(fsOutput, encryptor, CryptoStreamMode.Write))
                {
                    fsInput.CopyTo(cs);
                }
            }
        }

        /// <summary>
        /// Decrypts an AES-256 encrypted file and returns its original content as a string.
        /// </summary>
        /// <param name="encryptedFilePath">The path of the encrypted file to decrypt. Must not be null or empty.</param>
        /// <param name="encryptionKey">The encryption key used to encrypt the file. Must be 32 characters long to match AES-256 requirements.</param>
        /// <returns>
        /// A <see cref="string"/> containing the decrypted content of the file.
        /// </returns>
        /// <remarks>
        /// This method uses AES-256 decryption to securely decrypt the contents of the specified file.
        /// The encryption key must be exactly 32 characters long to meet the AES-256 key size requirement.
        /// The method also initializes a 16-byte IV (Initialization Vector) with default values.
        /// </remarks>
        /// <exception cref="FileNotFoundException">Thrown when the encrypted file does not exist.</exception>
        /// <exception cref="ArgumentException">Thrown when the encryption key is not 32 characters long.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Decrypt a file
        /// string encryptedFilePath = "example_encrypted.txt";
        /// string encryptionKey = "12345678901234567890123456789012"; // 32 characters
        /// 
        /// string decryptedContent = encryptedFilePath.DecryptFileEas256(encryptionKey);
        /// Console.WriteLine("Decrypted content:");
        /// Console.WriteLine(decryptedContent);
        /// </code>
        /// </example>
        public static string DecryptFileEas256(this string encryptedFilePath, string encryptionKey)
        {

            var file = new FileInfo(encryptedFilePath);
            file.Refresh();

            if (!file.Exists)
                throw new FileNotFoundException(encryptedFilePath);

            if (encryptionKey.Length != 32)
                throw new ArgumentException("The encryption key must be 32 characters long.", nameof(encryptionKey));

            if (!IsAscii(encryptionKey))
                throw new ArgumentException("The encryption key must contain only ASCII characters.", nameof(encryptionKey));


            byte[] key = Encoding.ASCII.GetBytes(encryptionKey);
            byte[] iv = new byte[16];

            using (var aes = Aes.Create())
            {

                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var fs = file.OpenRead()) // new FileStream(encryptedFilePath, FileMode.Open))
                using (var cs = new CryptoStream(fs, decryptor, CryptoStreamMode.Read))
                using (var sr = new StreamReader(cs))
                {
                    return sr.ReadToEnd();
                }

            }
        }


        private static bool IsAscii(string value)
        {
            return value.All(c => c <= sbyte.MaxValue);
        }

    }


}

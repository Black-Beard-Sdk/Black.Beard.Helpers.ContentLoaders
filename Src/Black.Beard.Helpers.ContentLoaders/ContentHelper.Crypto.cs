using System.Security.Cryptography;
using System.Text;

namespace Bb
{
    public static partial class ContentHelper2
    {

        /// <summary>
        /// Encrypts a string using AES-256 encryption and returns the encrypted content as a base64 string.
        /// </summary>
        /// <param name="plainText">The string to encrypt. Must not be null or empty.</param>
        /// <param name="encryptionKey">The encryption key to use. Must be 32 characters long to match AES-256 requirements.</param>
        /// <returns>
        /// A base64 encoded string containing the encrypted content.
        /// </returns>
        /// <remarks>
        /// This method uses AES-256 encryption to securely encrypt the provided string. 
        /// The encryption key must be exactly 32 characters long to meet the AES-256 key size requirement.
        /// A 16-byte initialization vector (IV) is used for encryption.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the input string is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when the encryption key is not 32 characters long or contains non-ASCII characters.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Encrypt a string
        /// string plainText = "Sensitive data to encrypt";
        /// string encryptionKey = "12345678901234567890123456789012"; // 32 characters
        /// 
        /// string encryptedText = plainText.EncryptStringAes256(encryptionKey);
        /// Console.WriteLine($"Encrypted Text: {encryptedText}");
        /// </code>
        /// </example>
        public static string EncryptStringAes256(this string plainText, string encryptionKey)
        {

            if (string.IsNullOrEmpty(plainText))
                throw new ArgumentNullException(nameof(plainText));

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

                using (var encryptor = aes.CreateEncryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream())
                using (var cs = new CryptoStream(ms, encryptor, CryptoStreamMode.Write))
                using (var sw = new StreamWriter(cs))
                {
                    sw.Write(plainText);
                    sw.Flush();
                    cs.FlushFinalBlock();
                    return Convert.ToBase64String(ms.ToArray());
                }
            }
        }

        /// <summary>
        /// Decrypts an AES-256 encrypted base64 string and returns its original content as a string.
        /// </summary>
        /// <param name="encryptedText">The base64 encoded string to decrypt. Must not be null or empty.</param>
        /// <param name="encryptionKey">The encryption key used to encrypt the string. Must be 32 characters long to match AES-256 requirements.</param>
        /// <returns>
        /// A <see cref="string"/> containing the decrypted content.
        /// </returns>
        /// <remarks>
        /// This method uses AES-256 decryption to securely decrypt the provided base64 encoded string. 
        /// The encryption key must be exactly 32 characters long to meet the AES-256 key size requirement.
        /// A 16-byte initialization vector (IV) is used for decryption.
        /// </remarks>
        /// <exception cref="ArgumentNullException">Thrown when the input string is null or empty.</exception>
        /// <exception cref="ArgumentException">Thrown when the encryption key is not 32 characters long or contains non-ASCII characters.</exception>
        /// <example>
        /// <code lang="C#">
        /// // Decrypt a string
        /// string encryptedText = "Base64EncryptedStringHere";
        /// string encryptionKey = "12345678901234567890123456789012"; // 32 characters
        /// 
        /// string decryptedText = encryptedText.DecryptStringAes256(encryptionKey);
        /// Console.WriteLine($"Decrypted Text: {decryptedText}");
        /// </code>
        /// </example>
        public static string DecryptStringAes256(this string encryptedText, string encryptionKey)
        {
            if (string.IsNullOrEmpty(encryptedText))
                throw new ArgumentNullException(nameof(encryptedText));

            if (encryptionKey.Length != 32)
                throw new ArgumentException("The encryption key must be 32 characters long.", nameof(encryptionKey));

            if (!IsAscii(encryptionKey))
                throw new ArgumentException("The encryption key must contain only ASCII characters.", nameof(encryptionKey));



            byte[] key = Encoding.ASCII.GetBytes(encryptionKey);
            byte[] iv = new byte[16]; // Initialisation vector (IV) de 16 octets
            byte[] buffer = Convert.FromBase64String(encryptedText);

            using (var aes = Aes.Create())
            {
                aes.Key = key;
                aes.IV = iv;

                using (var decryptor = aes.CreateDecryptor(aes.Key, aes.IV))
                using (var ms = new MemoryStream(buffer))
                using (var cs = new CryptoStream(ms, decryptor, CryptoStreamMode.Read))
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

using System.Text;

namespace PteroController.Handlers
{
    public class Base64EncryptionHandler
    {
        public static string Encrypt(string plainText)
        {
            byte[] plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            string encryptedText = Convert.ToBase64String(plainTextBytes);
            return encryptedText;
        }

        public static string Decrypt(string encryptedText)
        {
            byte[] encryptedTextBytes = Convert.FromBase64String(encryptedText);
            string decryptedText = Encoding.UTF8.GetString(encryptedTextBytes);
            return decryptedText;
        }
    }
}

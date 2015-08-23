namespace zynchronyze.util.Security
{
    using System.Security.Cryptography;
    using System.Text;

    public class CryptoHelper
    {
        /// <summary>
        /// Encrypts a string using the MD5 hash encryption algorithm.
        /// Message Digest is 128-bit and is commonly used to verify data, by checking
        /// the 'MD5 checksum' of the data. Information on MD5 can be found at:
        /// 
        /// http://www.faqs.org/rfcs/rfc1321.html
        /// </summary>
        /// <param name="Data">A string containing the data to encrypt.</param>
        /// <returns>A string containing the string, encrypted with the MD5 hash.</returns>
        public static string MD5Hash(string Data)
        {
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] hash = md5.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        public static string MD5Hash(byte[] Data)
        {
            // step 1, calculate MD5 hash from input
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] hash = md5.ComputeHash(Data);

            // step 2, convert byte array to hex string
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hash.Length; i++)
            {
                sb.Append(hash[i].ToString("X2"));
            }
            return sb.ToString();        
        }

        /// <summary>
        /// Encrypts a string using the SHA256 (Secure Hash Algorithm) algorithm.
        /// Details: http://www.itl.nist.gov/fipspubs/fip180-1.htm
        /// This works in the same manner as MD5, providing however 256bit encryption.
        /// </summary>
        /// <param name="Data">A string containing the data to encrypt.</param>
        /// <returns>A string containing the string, encrypted with the SHA256 algorithm.</returns>
        public static string SHA256Hash(string Data)
        {
            SHA256 sha = new SHA256Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }

        /// <summary>
        /// Encrypts a string using the SHA384(Secure Hash Algorithm) algorithm.
        /// This works in the same manner as MD5, providing 384bit encryption.
        /// </summary>
        /// <param name="Data">A string containing the data to encrypt.</param>
        /// <returns>A string containing the string, encrypted with the SHA384 algorithm.</returns>
        public static string SHA384Hash(string Data)
        {
            SHA384 sha = new SHA384Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }


        /// <summary>
        /// Encrypts a string using the SHA512 (Secure Hash Algorithm) algorithm.
        /// This works in the same manner as MD5, providing 512bit encryption.
        /// </summary>
        /// <param name="Data">A string containing the data to encrypt.</param>
        /// <returns>A string containing the string, encrypted with the SHA512 algorithm.</returns>
        public static string SHA512Hash(string Data)
        {
            SHA512 sha = new SHA512Managed();
            byte[] hash = sha.ComputeHash(Encoding.ASCII.GetBytes(Data));

            StringBuilder stringBuilder = new StringBuilder();
            foreach (byte b in hash)
            {
                stringBuilder.AppendFormat("{0:x2}", b);
            }
            return stringBuilder.ToString();
        }
    }
}

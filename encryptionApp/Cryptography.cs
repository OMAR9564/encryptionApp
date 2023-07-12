using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using Org.BouncyCastle.Crypto.Digests;

namespace encryptionApp
{
    internal class Cryptography
    {
        public string CalculateMD5(string input)
        {
            MD5 md5 = MD5.Create();
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = md5.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }
        public string CalculateSHA1(string input)
        {
            SHA1 sha1 = SHA1.Create();
            
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha1.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }
        public string CalculateRIPEMD128(string input)
        {
            
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            RipeMD128Digest ripemd128 = new RipeMD128Digest();
            ripemd128.BlockUpdate(inputBytes, 0, inputBytes.Length);
            byte[] hashBytes = new byte[ripemd128.GetDigestSize()];
            ripemd128.DoFinal(hashBytes, 0);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }
        public string CalculateSHA256(string input)
        {
            SHA256 sha256 = SHA256.Create();
            
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha256.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }
        public string CalculateSHA512(string input)
        {
            SHA512 sha512 = SHA512.Create();
            
            byte[] inputBytes = Encoding.UTF8.GetBytes(input);
            byte[] hashBytes = sha512.ComputeHash(inputBytes);

            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < hashBytes.Length; i++)
            {
                builder.Append(hashBytes[i].ToString("x2"));
            }
            return builder.ToString();
            
        }

    }
}

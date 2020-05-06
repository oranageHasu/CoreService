using Microsoft.AspNetCore.DataProtection;
using System;
using System.Security.Cryptography;
using System.Text;

namespace CoreService.Classes.Encryption_System
{
    public static class Encryption
    {
        #region constants

        public const string ENCRYPTION_HIDDENCHAR = "-";
        public const string ENCRYPTION_REPLACECHAR = "";

        #endregion
        #region methods

        public static string Encrypt(IDataProtector protector, string data)
        {
            string retval = string.Empty;

            try
            {
                retval = protector.Protect(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return retval;
        }

        public static string Decrypt(IDataProtector protector, string data)
        {
            string retval = string.Empty;

            try
            {
                retval = protector.Unprotect(data);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return retval;
        }

        public static string HMACSerialization(string data, string APIKey)
        {

            Byte[] hashBytes, textBytes, keyBytes = null;
            string retval = string.Empty;

            try
            {

                ASCIIEncoding encoding = new ASCIIEncoding();

                textBytes = encoding.GetBytes(data);
                keyBytes = encoding.GetBytes(APIKey);

                using (HMACSHA256 hash = new HMACSHA256(keyBytes))
                {
                    hashBytes = hash.ComputeHash(textBytes);
                }

                retval = BitConverter.ToString(hashBytes).Replace(ENCRYPTION_HIDDENCHAR, ENCRYPTION_REPLACECHAR).ToLower();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }

            return retval;

        }

        #endregion
    }
}

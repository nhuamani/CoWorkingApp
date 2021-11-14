using System;
using System.Net.Mime;
using System.Text;
using System.Security.Cryptography;

namespace CoWorkingApp.Data.Helpers
{
    public static class EncryptData
    {
        public static string EncryptText(string clearText)
        {
            using(var sha256 = SHA256.Create())
            {
                var hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(clearText));

                var has = BitConverter.ToString(hashBytes).Replace("-","").ToLower();

                return has;
            }
        }

        
    }
}
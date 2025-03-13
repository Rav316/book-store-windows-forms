using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace book_store.util
{
    public class PasswordEncoder
    {
        public static string Encode(string input)
        {
            using (SHA512 sha512Hasher = SHA512.Create())
            {
                byte[] data = sha512Hasher.ComputeHash(Encoding.UTF8.GetBytes(input));
                StringBuilder sBuilder = new StringBuilder();

                foreach (byte byteValue in data)
                {
                    sBuilder.Append(byteValue.ToString("x2"));
                }

                return sBuilder.ToString();
            }
        }

        public static bool Matches(string input, string hash)
        {
            string hashOfInput = Encode(input);

            return string.Equals(hashOfInput, hash, StringComparison.OrdinalIgnoreCase);
        }
    }
}

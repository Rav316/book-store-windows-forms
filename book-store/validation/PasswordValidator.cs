using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace book_store.validation
{
    internal class PasswordValidator
    {
        private static readonly Regex PasswordRegex = new Regex(
        @"^(?=.*[A-Z])(?=.*\d)(?=.*[\W_]).{6,}$",
        RegexOptions.Compiled);

        public static bool IsValidPassword(string password)
        {
            if (string.IsNullOrWhiteSpace(password))
                return false;

            return PasswordRegex.IsMatch(password);
        }
    }
}

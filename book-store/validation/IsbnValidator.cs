using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.validation
{
    public sealed class IsbnValidator
    {
        private IsbnValidator() { }
        public static bool IsValid(string isbn)
        {
            if (!isbn.All(char.IsDigit))
                return false;

            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                int digit = isbn[i] - '0';
                sum += (i % 2 == 0) ? digit : digit * 3;
            }

            int checkDigit = (10 - (sum % 10)) % 10;
            return checkDigit == (isbn[12] - '0');
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace book_store.validation
{
    public sealed class CardNumberValidator
    {
        private CardNumberValidator() { }
        public static bool IsValid(string number)
        {
            number = number.Replace(" ", "");

            if (!long.TryParse(number, out _))
            {
                return false;
            }

            int sum = 0;
            bool doubleDigit = false;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                int digit = number[i] - '0';

                if (doubleDigit)
                {
                    digit *= 2;
                    if (digit > 9)
                    {
                        digit -= 9;
                    }
                }

                sum += digit;
                doubleDigit = !doubleDigit; 
            }

            return sum % 10 == 0;
        }
    }
}

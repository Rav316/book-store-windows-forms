namespace book_store.validation
{
    public sealed class IsbnValidator
    {
        private IsbnValidator() { }
        public static bool IsValid(string isbn)
        {
            string cleaned = new string(isbn.Where(c => char.IsDigit(c)).ToArray());

            if (cleaned.Length != 13)
                return false;

            int sum = 0;
            for (int i = 0; i < 13; i++)
            {
                int digit = cleaned[i] - '0';
                sum += digit * (i % 2 == 0 ? 1 : 3);
            }

            return sum % 10 == 0;
        }
    }
}

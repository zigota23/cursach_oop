using System.Text.RegularExpressions;

namespace cursach
{
    internal class Validation
    {
        public static bool IsValidEmail(string email)
        {
            string emailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
            Regex regex = new Regex(emailPattern);
            return regex.IsMatch(email);
        }

        public static bool IsValidPassword(string password)
        {
            return password.Length >= 6;
        }
    }
}

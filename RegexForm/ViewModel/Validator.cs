using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;

namespace RegexForm.ViewModel
{
    class Validator
    {

        private const string EmailPattern = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";
        private const string NamePattern = @"^([A-Za-z]+\s*)+$";
        private const string PhoneNumberPattern = @"^\(?(\d{3})\)?[\s\-]?(\d{3})\-?(\d{4})$";


        private static Match CheckInputForMatch(string input, string pattern)
        {
            return Regex.Match(input, pattern);
        }

        public static bool IsEmailValid(string email)
        {
            Match match = CheckInputForMatch(email, EmailPattern);

            return match.Success;
        }

        public static bool IsPhoneNumberValid(string phone)
        {
            Match match = CheckInputForMatch(phone, PhoneNumberPattern);

            return match.Success;
        }

        public static bool IsNameValid(string name)
        {
            Match match = CheckInputForMatch(name, NamePattern);

            return match.Success;
        }

        public static string ReformatPhoneNumber(string phoneNumber)
        {

        }
    }
}

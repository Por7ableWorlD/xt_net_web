using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Task_3._3._2___Super_string
{
    public static class SuperString
    {
        public static string CheckingLanguage(this string input)
        {
            string russianInput = @"^[а-яё]+$";
            string englishInput = @"^[a-z]+$";
            Regex numericInput = new Regex(@"^[0-9]+$");

            if (Regex.IsMatch(input, russianInput, RegexOptions.IgnoreCase))
            {
                return "Russian";
            }

            else if (Regex.IsMatch(input, englishInput, RegexOptions.IgnoreCase))
            {
                return "English";
            }

            else if (numericInput.IsMatch(input))
            {
                return "Numeric";
            }

            else
            {
                return "Mixed";
            }
        }
    }
}

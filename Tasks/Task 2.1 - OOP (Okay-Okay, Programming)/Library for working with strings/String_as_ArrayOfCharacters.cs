using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_for_working_with_strings
{
    public class StringAsArrayOfCharacters
    {
        private char[] array;

        public int Length
        {
            get
            {
                return array.Length;
            }
        }


        public StringAsArrayOfCharacters(string line)
        {
            array = line.ToCharArray();
        }


        public char this[int index]
        {
            get
            {
                return array[index];
            }
            set
            {
                array[index] = value;
            }
        }


        public static StringAsArrayOfCharacters operator +(StringAsArrayOfCharacters first_line, StringAsArrayOfCharacters second_line)
        {
            string third_String = first_line.ToString() + second_line.ToString();
            return new StringAsArrayOfCharacters (third_String);
        }


        public static StringAsArrayOfCharacters Concatenation(StringAsArrayOfCharacters first_line, StringAsArrayOfCharacters second_line)
        {
            return first_line + second_line;
        }


        public static bool Comparison(StringAsArrayOfCharacters first_line, StringAsArrayOfCharacters second_line)
            => string.Compare(first_line.ToString(), second_line.ToString()) == 0 ? true : false;


        public static int Searching(StringAsArrayOfCharacters first_line, StringAsArrayOfCharacters second_line, char symbol)
        {
            return (first_line + second_line).ToString().IndexOf(symbol);
        }


        public override string ToString()
        {
            StringBuilder line = new StringBuilder();
            foreach (var symbol in array)
            {
                line.Append(symbol);
            }

            return line.ToString();
        }
    }
}

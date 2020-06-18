using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_for_working_with_strings
{
    public class String_as_ArrayOfCharacters
    {
        private char[] array;

        public int Length
        {
            get
            {
                return array.Length;
            }
        }


        public String_as_ArrayOfCharacters(string line)
        {
            array = line.ToCharArray();
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


        public static String_as_ArrayOfCharacters operator +(String_as_ArrayOfCharacters first_line, String_as_ArrayOfCharacters second_line)
        {
            return new String_as_ArrayOfCharacters (first_line.ToString() + second_line.ToString());
        }


        public static String_as_ArrayOfCharacters Concatenation(String_as_ArrayOfCharacters first_line, String_as_ArrayOfCharacters second_line)
        {
            return first_line + second_line;
        }


        public static bool Comparison(String_as_ArrayOfCharacters first_line, String_as_ArrayOfCharacters second_line)
        {
            if (string.Compare(first_line.ToString(), second_line.ToString()) == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        public static int Searching(String_as_ArrayOfCharacters first_line, String_as_ArrayOfCharacters second_line, char symbol)
        {
            return (first_line + second_line).ToString().IndexOf(symbol);
        }
    }
}

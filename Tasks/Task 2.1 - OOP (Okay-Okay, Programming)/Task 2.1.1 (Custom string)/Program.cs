using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Library_for_working_with_strings;

namespace Task_2._1._1__Custom_string_
{
    class Program
    {
        static void Main(string[] args)
        {
            var first_String = new StringAsArrayOfCharacters("Hello");
            var second_String = new StringAsArrayOfCharacters(" world!");


            Console.WriteLine($"Length:\nfirst_string = {first_String.Length}\nsecond_string = {second_String.Length}\n");


            if (StringAsArrayOfCharacters.Comparison(first_String, second_String))
             {
                 Console.WriteLine($"Comparison: Lines are equal!\n");
             }
             else
             {
                 Console.WriteLine("Comparison: Lines are not equal!\n");
             }


            Console.WriteLine($"Сoncatenation: {StringAsArrayOfCharacters.Concatenation(first_String, second_String)}\n");


            int search = StringAsArrayOfCharacters.Searching(first_String, second_String, 'r');
            if (search != -1)
            {
                Console.WriteLine($"Searching: Index of your symbol = {search}\n");
            }
            else
            {
                Console.WriteLine("Searching: Your symbol was not found!\n");
            }



            Console.ReadKey();
        }
    }
}

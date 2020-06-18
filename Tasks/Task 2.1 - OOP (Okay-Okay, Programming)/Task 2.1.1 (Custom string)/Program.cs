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
            var first_string = new String_as_ArrayOfCharacters("Hello");
            var second_string = new String_as_ArrayOfCharacters(" world!");


            Console.WriteLine($"Length:\nfirst_string = {first_string.Length}\nsecond_string = {second_string.Length}\n");


            if (String_as_ArrayOfCharacters.Comparison(first_string, second_string))
             {
                 Console.WriteLine($"Comparison: Lines are equal!\n");
             }
             else
             {
                 Console.WriteLine("Comparison: Lines are not equal!\n");
             }


            Console.WriteLine($"Сoncatenation: {String_as_ArrayOfCharacters.Concatenation(first_string, second_string)}\n");


            int search = String_as_ArrayOfCharacters.Searching(first_string, second_string, 'r');
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

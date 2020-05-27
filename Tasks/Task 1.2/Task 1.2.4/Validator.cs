using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._4
{
    class Validator
    {
        static void Main(string[] args)
        {
            Console.Write("Enter some text: ");
            StringBuilder str = new StringBuilder(Console.ReadLine());

            if (char.IsLower(str[0]))
                str[0] = char.ToUpper(str[0]);

            for (int i = 0; i < str.Length; i++)
            {
                if ( (str[i] == '.' || str[i] == '?' || str[i] == '!') && (i + 2 < str.Length) && (char.IsLower(str[i+2])) )
                    str[i + 2] = char.ToUpper(str[i + 2]);
            }
            Console.WriteLine(str);


            Console.ReadKey();
        }
    }
}

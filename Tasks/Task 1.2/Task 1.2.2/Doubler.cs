using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._2
{
    class Doubler
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first string: ");
            StringBuilder str1 =  new StringBuilder(Console.ReadLine());
            Console.Write("Enter second string: ");
            string str2 = Console.ReadLine();

            for (int i = 0; i < str1.Length; i++)
                if (str2.Contains(str1[i]))
                {
                    str1.Insert(i, str1[i]);
                    i++;
                }

            Console.WriteLine(str1);

            Console.ReadKey();
        }
    }
}

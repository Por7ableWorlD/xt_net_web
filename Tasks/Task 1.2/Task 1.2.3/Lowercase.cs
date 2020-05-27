using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._3
{
    class LowerCase
    {
        static void Main(string[] args)
        {
            Console.Write("Enter something: ");
            string str = Console.ReadLine();
            string[] split = str.Split(new char[] { ' ', ',', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);
            int result = 0;
            foreach (var word in split)
            {
                if (char.IsLower(word[0]))
                    result += 1;
            }
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}

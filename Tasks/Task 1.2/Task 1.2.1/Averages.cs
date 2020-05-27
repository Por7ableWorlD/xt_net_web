using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._2._1
{
    class Averages
    {
        static void Main(string[] args)
        {

            Console.Write("Enter something: ");
            string str = Console.ReadLine();
            string[] split = str.Split(new char[] { ' ', '.', ',', '?', '!', ':', ';' }, StringSplitOptions.RemoveEmptyEntries);

            double average = 0;
            foreach (var word in split)
            {
                average += word.Length;
            }
            Console.WriteLine($"Average = {average/split.Length}");

            Console.ReadKey();
        }
    }
}

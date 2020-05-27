using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._1
{
    class Rectangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a = ");
            var a = Console.ReadLine();
            Console.Write("Enter b = ");
            var b = Console.ReadLine();

            if (int.TryParse(a, out var A) == false || int.TryParse(b, out var B) == false)
                Console.WriteLine("You entered nor correct data!");
            else
            {
                if ((A <= 0) || (B <= 0))
                    Console.WriteLine("You entered nor correct data!");
                else
                {
                    var result = A * B;
                    Console.WriteLine($"Answer = {result}");
                }
            }
            Console.ReadKey();
        }
    }
}

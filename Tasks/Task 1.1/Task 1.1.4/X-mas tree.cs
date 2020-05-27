using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of triangles: ");
            if (int.TryParse(Console.ReadLine(), out int N) != false && N > 0)
            {
                for (int i = 0; i <= N; i++)
                {
                    for (int j = 1; j <= i+1; j++)
                    {
                        for (int q = 0; q <= N - j; q++)
                            Console.Write(" ");
                        for (int q = 1; q <= j * 2 - 1; q++)
                            Console.Write("*");

                        Console.WriteLine();
                    }
                }
            }
            else
                Console.WriteLine("You entered nor correct data!");
            Console.ReadKey();
        }
    }
}

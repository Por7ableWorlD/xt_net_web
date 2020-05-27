using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._2
{
    class Triangle
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int N) != false && N > 0)
                for (int i = 0, j = i; i < N; i++, j = i)
                {
                    while (j != -1)
                    {
                        Console.Write('*');
                        j -= 1;
                    }
                    Console.WriteLine();
                }
            else
                Console.WriteLine("You entered nor correct data!");
            Console.ReadKey();
        }
    }
}

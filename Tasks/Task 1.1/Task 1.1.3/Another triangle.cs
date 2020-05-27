using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of rows: ");
            if (int.TryParse(Console.ReadLine(), out int N) != false && N > 0)
            {
                int check = 1;
                string star = "*";
                for (int i = 1; i < N; i++)
                {
                    check += 2;
                }
                check = check / 2 + 1;
                for (int i = 0; i < N; i++)
                {
                    for (int j = 0; j < check - i; j++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(star);
                    star += "**";
                    Console.WriteLine();
                }
            }
            else
                Console.WriteLine("You entered nor correct data!");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_11._1._10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] arr = new int[3, 4];
            Random rand = new Random();

            Console.WriteLine("Array: ");
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = rand.Next(-100, 100);
                    Console.Write($"arr[{i}][{j}] = {arr[i, j]}\t");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == j)
                        sum += arr[i, j];
                }

            Console.WriteLine($"Sum = {sum}");

            Console.ReadKey();
        }
    }
}

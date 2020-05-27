using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            Console.Write("Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
                if (arr[i] > 0)
                    sum += arr[i];
            Console.WriteLine($"Sum of positive elements = {sum}");

            Console.ReadKey();
        }
    }
}

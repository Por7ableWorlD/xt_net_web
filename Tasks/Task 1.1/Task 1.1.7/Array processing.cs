using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._7
{
    class Program
    {
        static void Sort(int[] arr)
        {
            int t;
            for (int i = 0; i < arr.Length; i++)
                for (int j = 0; j < arr.Length - i - 1; j++)
                    if (arr[j] > arr[j + 1])
                    {
                        t = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = t;
                    }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rand = new Random();

            Console.Write("Unsorted array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(-100, 100);
                Console.Write($"{arr[i]} ");
            }
            Console.WriteLine();

            Sort(arr);
            int min = arr[0];
            int max = arr[9];

            Console.Write("Sorted array: ");
            for (int i = 0; i < arr.Length; i++)
                Console.Write($"{arr[i]} ");

            Console.WriteLine();

            Console.WriteLine($"min = {min}");
            Console.WriteLine($"max = {max}");

            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] arr = new int[1, 2, 3];
            Random rand = new Random();

            Console.Write("Original array: ");
            for (int z = 0; z < arr.GetLength(0); z++)
                for (int y = 0; y < arr.GetLength(1); y++)
                    for (int x = 0; x < arr.GetLength(2); x++)
                    {
                        arr[z, y, x] = rand.Next(-100, 100);
                        Console.Write($"{arr[z, y, x]} ");
                    }
            Console.WriteLine();

            Console.Write("Changed array: ");
            for (int z = 0; z < arr.GetLength(0); z++)
                for (int y = 0; y < arr.GetLength(1); y++)
                    for (int x = 0; x < arr.GetLength(2); x++)
                    {
                        if (arr[z, y, x] > 0)
                            arr[z, y, x] = 0;
                        Console.Write($"{arr[z, y, x]} ");
                    }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}

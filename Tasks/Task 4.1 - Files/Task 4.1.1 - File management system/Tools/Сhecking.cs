using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task_4._1._1___File_management_system
{
   public class Сhecking
    {
        public static int RangeInsert(int min, int max)
        {
            bool flag = false;
            int result;

            Console.Write("Your choise: ");

            do
            {
                flag = int.TryParse(Console.ReadLine(), out result);
                if (!flag || result < min || result > max)
                {
                    Console.WriteLine("Incorrect insert!");
                    Console.Write("\nTry one more time: ");
                    flag = false;
                }
            } while (!flag);

            Console.WriteLine();

            return result;
        }
    }
}

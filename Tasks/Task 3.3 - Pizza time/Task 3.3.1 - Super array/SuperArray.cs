using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._3._1___Super_array
{
    public static class SuperArray
    {
        public static int[] Additional(this int[] array, Func<int, int> func)
        {
            if (array == null || func == null)
            {
                throw new ArgumentNullException("array or func", "They can't be null");
            }
            else
            {
                return array.Select(item => func(item)).ToArray();
            }
        }

        public static double Average(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "It can't be null");
            }

            return array.Sum() / array.Length;
        }

        public static T Repeated<T>(this T[] array) where T : struct
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "It can't be null");
            }

            return array.OrderBy(item => item).GroupBy(item => item).OrderByDescending(item => item.Count()).FirstOrDefault().Key;
        }

        public static int Sum(this int[] array)
        {
            if (array == null)
            {
                throw new ArgumentNullException("array", "It can't be null");
            }

            int sum = 0;
            array.Select(item => sum += item);
            return sum;
        }

    }
}

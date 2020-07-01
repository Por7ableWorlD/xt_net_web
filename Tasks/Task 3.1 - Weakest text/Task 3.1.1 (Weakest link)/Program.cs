using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._1__Weakest_link_
{
    class Program
    {
        static void Main(string[] args)
        {
            int index = 0;
            int N;
            int position;

            Console.Write("Enter the number of people: ");
            var number = Console.ReadLine();
            Console.Write("Enter which person's score will be crossed out each round: ");
            var numeric = Console.ReadLine();

            /// <summary>
            /// 
            /// </summary>
            /// <param name="number"></param>
            /// <param name="numeric"></param>
            /// <exception cref="System.FormatException">Thrown when user input is incorrect</exception>
            /// <returns></returns>
            try
            {
                N = CheckingСonversion(number);
                position = CheckingСonversion(numeric);
            }
            catch (InvalidCastException ex)
            {
                throw new FormatException("User input is incorrect", ex);
            }


            /// <summary>
            /// 
            /// </summary>
            /// <param name="position"></param>
            /// <param name="N"></param>
            /// <exception cref="System.ArgumentOutOfRangeException">Thrown when the "position" parameter is greater than the "N" parameter</exception>
            /// <returns></returns>
            if (position > N)
            {
                throw new ArgumentOutOfRangeException("position", "The number of the person being crossed out cannot be more than the number of people");
            }

            List<int> list = new List<int>(N);
            Console.WriteLine("\nAll people who play counting games: ");
            while (index < N)
            {
                list.Add(index + 1);
                Console.Write($"{list[index]}, ");
                index += 1;
            }
            Console.WriteLine();

            index = 0;

            while (position <= N)
            {
                if (position > N)
                {
                    Console.WriteLine("\n\nThe game is over. You can't cross out more people.");
                    break;
                }
                list.RemoveAt(position - 1);
                Console.Write($"\nRound {index += 1}. A person is crossed out. People left: {N -= 1}.");
                position += position;
            }

            Console.WriteLine("\n\nPeople who are not crossed out: ");
            foreach (var item in list)
            {
                Console.Write($"{item}, ");
            }

            Console.ReadKey();
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="userInput"></param>
        /// <exception cref="System.InvalidCastException">Thrown when user input cannot convert to int</exception>
        /// <returns></returns>
        public static int CheckingСonversion(string userInput)
        {
            if (int.TryParse(userInput, out int value) == !false)
            {
                return value;
            }
            else
            {
                throw new InvalidCastException("Invalid input! Cannot convert to int!");
            }
        }
    }
}

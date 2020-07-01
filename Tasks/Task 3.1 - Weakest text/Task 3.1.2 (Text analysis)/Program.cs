using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3._1._2__Text_analysis_
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            bool flag = false;
            int numberRepeated = 1;
            int maxRepetitions = -1;

            Console.WriteLine("I am very happy to welcome you to my program. Let's check your speech for monotony and find a \"favorite\" words. " +
                "Write me something:\n");
            string str = Console.ReadLine();

            string[] split = str.Split(new char[] {' ', '.', ',', '?', '!', ':', ';'}, StringSplitOptions.RemoveEmptyEntries);
            string[] prepositionsAndKeywords = new string[] { "a", "the", "of", "at", "on", "in", "am", "is", "are", "by", "for" };

            List<int> number = new List<int>(split.Length);
            List<string> list = new List<string>(split.Length);

            for (int i = 0; i < split.Length; i++)
            {
                foreach (var item in prepositionsAndKeywords)
                {
                    if (split[i].ToLower() == item)
                    {
                        flag = true;
                        break;
                    }
                }

                if (!flag)
                {
                    list.Add(split[i]);
                }
                else
                {
                    flag = false;
                }
            }
            
            Console.WriteLine("\nThe number of repetitions of each word from the text you entered: ");
            for (int i = 0; i < list.Count(); i++)
            {

                for (int j = i + 1; j < list.Count(); j++)
                {
                    if (list[i].ToString().ToLower() == list[j].ToString().ToLower())
                    {
                        numberRepeated++;
                        list.RemoveAt(j);
                        j--;
                    }
                }

                if (maxRepetitions < numberRepeated)
                {
                    maxRepetitions = numberRepeated;
                }

                number.Add(numberRepeated);
                numberRepeated = 1;

                Console.WriteLine($"{list[i]} = {number[i]}");
            }

            foreach (var item in number)
            {
                if (item != maxRepetitions)
                {
                    flag = true;
                    break;
                }
            }

            if (flag)
            {
                Console.WriteLine("\nYour \"favorite\" words:");
                for (int i = 0; i < number.Count(); i++)
                {
                    if (number[i] == maxRepetitions)
                    {
                        count++;
                        Console.Write($"{list[i]}, ");
                    }
                }
                Console.WriteLine($"you repeated them {maxRepetitions} times");

                if (count > 2 || maxRepetitions > 2)
                {
                    Console.WriteLine("\nYour speech is too monotonous. Try to use your \"favorite\" words less often.");
                }
                else
                {
                    Console.WriteLine("\nCongratulations!!! Your speech is diverse!");
                }

            }
            else if (maxRepetitions > 2)
            {
                Console.WriteLine("\nWe didn't find your \"favorite\" word. All the words were repeated the same number of times, " +
                    "but your speech is still very monotonous. Try to avoid tautology.");
            }
            else
            {
                Console.WriteLine("\nWe didn't find your \"favorite\" word. All the words were repeated the same number of times, " +
                    "but your speech is diverse. Congratulations!!!");
            }

            Console.ReadKey();
        }
    }
}

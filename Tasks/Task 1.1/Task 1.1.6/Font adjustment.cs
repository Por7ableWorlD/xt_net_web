using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_1._1._6
{
    class Program
    {
        [Flags]
        enum Fonts
        {
            None = 0,
            Bold,
            Italic,
            Underline = 4
        }

        private static string Get_font_type(Fonts FontType)
        {
            while (true)
            {
                if (int.TryParse(Console.ReadLine(), out int elem) != false)
                {
                    switch (elem)
                    {
                        case 0:
                            return "До свидания!";
                        case 1:
                            FontType = FontType ^ Fonts.Bold;
                            break;
                        case 2:
                            FontType = FontType ^ Fonts.Italic;
                            break;
                        case 3:
                            FontType = FontType ^ Fonts.Underline;
                            break;
                    }
                    Console.WriteLine("Параметры надписи: {0}", FontType);
                    Console.WriteLine("Введите:\n\t1: Bold\n\t2: Italic\n\t3: Underline\n\t0: Выход из программы");
                }
                else
                    return "Вы должны были ввести цифру от 0 до 3!";
            }

        }
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Fonts FontType = Fonts.None;
            Console.WriteLine("Параметры надписи: {0}", FontType);
            Console.WriteLine("Введите:\n\t1: Bold\n\t2: Italic\n\t3: Underline\n\t0: Выход из программы");
            Console.WriteLine(Get_font_type(FontType));

            Console.ReadKey();
        }
    }
}
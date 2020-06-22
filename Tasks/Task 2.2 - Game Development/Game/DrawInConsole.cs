using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class DrawInConsole : SetValue
    {
        static public void Draw()
        {
            Console.Clear();
            Console.WriteLine("Collect all the fruits of your neighbors and don't get caught by their dogs!" +
                "\nHint: go through the holes in the fences\n");

            for (int i = 0; i < Width; i++)
            {
                Console.Write('#');
            }

            Console.Write($"\t\tFruits: {score/10}");
            Console.WriteLine();

            for (int i = 0; i < Height; i++)
            {
                for (int j = 0; j < Width; j++)
                {
                    if (j == 0 || j == Width - 1 || (i == 1 && j != 1 && j != 2) || (i == 3 && j != 5 && j != 6) ||
                        (i == 5 && j != 2 && j != 3) || (i == 7 && j != 4 && j != 5))
                    {
                        Console.Write('#');
                    }
                    else if (i == player_Y && j == player_X)
                    {
                        Console.Write('0');
                    }
                    else if (i == first_monsterY && j == first_monsterX)
                    {
                        Console.Write('@');
                    }
                    else if (i == second_monsterY && j == second_monsterX)
                    {
                        Console.Write('@');
                    }
                    else if (i == third_monsterY && j == third_monsterX)
                    {
                        Console.Write('@');
                    }
                    else if (i == fourth_monsterY && j == fourth_monsterX)
                    {
                        Console.Write('@');
                    }
                    else if (i == fruit_Y && j == fruit_X)
                    {
                        Console.Write('F');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }

                Console.WriteLine();
            }

            for (int i = 0; i < Width; i++)
            {
                if (i != 2)
                {
                    Console.Write('#');
                }
                else
                {
                    Console.Write(' ');
                }
            }

            Console.WriteLine();

            Console.WriteLine("\nClick \"x\" to exit the game");
        }
    }
}

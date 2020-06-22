using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class UserInput : BaseGame
    {
        static public void Input()
        {
            switch (Console.ReadKey(true).Key)
            {
                case ConsoleKey.A:
                    dir = eDirection.LEFT;
                    break;

                case ConsoleKey.D:
                    dir = eDirection.RIGHT;
                    break;

                case ConsoleKey.W:
                    dir = eDirection.UP;
                    break;

                case ConsoleKey.S:
                    dir = eDirection.DOWN;
                    break;

                case ConsoleKey.X:
                    gameOver = true;
                    break;
            }
        }
    }
}

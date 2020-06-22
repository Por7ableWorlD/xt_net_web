using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            SetValue.Setup();
            while (!BaseGame.gameOver)
            {
               DrawInConsole.Draw();
                UserInput.Input();
                GameLogic.Logic();
                //Thread.Sleep(250);
            }

            Console.ReadKey();
        }
    }
}

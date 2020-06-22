using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class BaseGame
    {
        static public bool gameOver;

        static protected int first_monsterX;
        static protected int first_monsterY;

        static protected int second_monsterX;
        static protected int second_monsterY;

        static protected int third_monsterX;
        static protected int third_monsterY;

        static protected int fourth_monsterX;
        static protected int fourth_monsterY;

        static protected int fruit_X;
        static protected int fruit_Y;

        static protected int player_X;
        static protected int player_Y;

        static public int score;

        static protected int Height = 9;
        static protected int Width = 15;

        protected enum eDirection { STOP = 0, LEFT = 1, RIGHT = 2, UP = 3, DOWN = 4 };
        static protected eDirection dir;

        static protected Random random = new Random();
    }
}

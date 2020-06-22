using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class SetValue : BaseGame
    {
        static public void Setup()
        {
            gameOver = false;

            dir = eDirection.STOP;

            player_X = Width - 2;
            player_Y = 0;

            fruit_X = 6;
            fruit_Y = 2;

            first_monsterX = 1;
            first_monsterY = 2;

            second_monsterX = Width - 2;
            second_monsterY = 4;

            third_monsterX = 1;
            third_monsterY = 6;

            fourth_monsterX = Width - 2;
            fourth_monsterY = 8;

            score = 0;
        }
    }
}

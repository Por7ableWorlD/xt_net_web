using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    public class GameLogic : SetValue
    {
        static public void Logic()
        {

            switch (dir)
            {
                case eDirection.LEFT:
                    player_X--;
                    break;

                case eDirection.RIGHT:
                    player_X++;
                    break;

                case eDirection.UP:
                    player_Y--;
                    break;

                case eDirection.DOWN:
                    player_Y++;
                    break;
            }

            if (player_X == 2 && player_Y == 9 && score == 40)
            {
                Console.Clear();
                Console.WriteLine("You won!!!");
                Console.Write($"You collected all the fruits and didn't get caught by the dogs!");
                gameOver = true;
            }
            else if (player_X == 2 && player_Y == 9 && score != 40)
            {
                Console.Clear();
                Console.WriteLine("You've lost! You didn't collect all the fruit from the neighbors!");
                Console.Write($"You collected {score / 10} fruits, but you needed 4!");
                gameOver = true;
            }
            else if (player_X + 2 > Width || player_X - 1 < 0 || player_Y + 1 > Height || player_Y < 0 || (player_X != 1 && player_X != 2 && player_Y == 1) 
                || (player_X != 5 && player_X != 6 && player_Y == 3) || (player_X != 2 && player_X != 3 && player_Y == 5)
                || (player_X != 4 && player_X != 5 && player_Y == 7))
            {
                Console.Clear();
                Console.WriteLine("You've lost! You crashed into a fence!");
                Console.Write($"You have collected {score / 10} fruits");
                gameOver = true;
            }

            if (player_X == fruit_X && player_Y == fruit_Y)
            {
                score += 10;
                fruit_X = random.Next(1, 3);
                fruit_Y += 2;
            }

            if ((player_X == first_monsterX && player_Y == first_monsterY) || (player_X == second_monsterX && player_Y == second_monsterY) ||
                (player_X == third_monsterX && player_Y == third_monsterY) || (player_X == fourth_monsterX && player_Y == fourth_monsterY))
            {
                Console.Clear();
                Console.WriteLine("You've lost! You were bitten by a dog");
                Console.Write($"You have collected {score / 10} fruits");
                gameOver = true;
            }

            if (first_monsterX != (Width - 2) && third_monsterX != (Width - 2) && second_monsterX != 0 && fourth_monsterX != 0)
            {
                first_monsterX++;
                third_monsterX++;
                second_monsterX--;
                fourth_monsterX--;
            }
            else
            {
                first_monsterX = 1;
                third_monsterX = 1;
                second_monsterX = Width - 2;
                fourth_monsterX = Width - 2;
            }

            if ((player_X == first_monsterX && player_Y == first_monsterY) || (player_X == second_monsterX && player_Y == second_monsterY) ||
                (player_X == third_monsterX && player_Y == third_monsterY) || (player_X == fourth_monsterX && player_Y == fourth_monsterY))
            {
                Console.Clear();
                Console.WriteLine("You've lost! You were bitten by a dog");
                Console.Write($"You have collected {score/10} fruits");
                gameOver = true;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeAndLadderComputation
    {
        public const int player = 1;
        public const int playerposition = 0;
        public static void GameStart()
        {
            Random random = new Random();
            int diceroll = random.Next(1, 7);
            Console.WriteLine("position of the player is:"+diceroll);
        }
    }
}

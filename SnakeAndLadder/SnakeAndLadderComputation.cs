using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeAndLadder
{
    class SnakeAndLadderComputation
    {
        public const int player = 1;
        public const int playerposition =0;
        public const int Ladder = 1;
        public const int Snake = 2;
        public const int NoPlay = 3;
        public static void GameStart()
        {
            Random random = new Random();
            int diceroll = random.Next(1, 7);
            int option = random.Next(1, 4);
            switch(option)
            {
                case Ladder:
                    int playerPosition = diceroll + playerposition;
                    Console.WriteLine("position of the player is:"+playerPosition);
                    break;
                case Snake:
                    int playerPosition1= playerposition - diceroll;
                    if(playerPosition1<0)
                    {
                        Console.WriteLine("Got Snake:"+playerposition);
                        //Console.WriteLine("position of the player is:"+playerposition);
                    }
                    
                    break;
                default:
                    Console.WriteLine("position of the player is:"+playerposition);
                    break;
            }
            
        }
    }
}

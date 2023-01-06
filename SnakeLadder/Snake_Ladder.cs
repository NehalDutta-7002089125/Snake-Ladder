using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class Snake_Ladder
    {
        public static void dice()
        {
            Console.WriteLine("Roll the dice");
            Random obj= new Random();
            int check=obj.Next(2);
            if(check==0)
            {
                Console.WriteLine("You are in start");
            }
            else
            {
                Console.WriteLine("Sorry, the game has not started yet");
            }
        }
    }
}

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
            int check=obj.Next(0,7);
            if(check==0)
            {
                Console.WriteLine("You are in start");
            }
            else
            {
                Console.WriteLine("You have moved to {0} postition", check);
            }
        }
    }
}

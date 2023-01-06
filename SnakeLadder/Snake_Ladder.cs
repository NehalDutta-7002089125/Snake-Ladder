using System;
using System.Collections.Generic;
using System.Text;

namespace SnakeLadder
{
    public class Snake_Ladder
    {
        public static void dice()
        {
            int p = 0;
            while (p != 100)
            {
                Random obj = new Random();
                int check = obj.Next(0, 7);
                Console.WriteLine("you have got {0} ", check);

                int a = obj.Next(1, 3);
                if (check == 0)
                {
                    Console.WriteLine("You have to stay");
                }
                else if (a == 1)
                {
                    p += check;
                    Console.WriteLine("Congratulation, Step the ladder by getting" + p);
                    p++;
                }
                else
                {
                    p -= check;
                    Console.WriteLine("Sorry, it's snake step dowen by getting" + p);
                }
            }
             
        }
    }
}

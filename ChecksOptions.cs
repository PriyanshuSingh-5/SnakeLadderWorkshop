using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNdLadder
{
    class ChecksOptions
    {

        public static void OptionToPlay()
        {

            const int NO_PLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
           
                Random random = new Random();
                int option = random.Next(0, 3);
                int dieValue = random.Next(0, 6);
                int player = 0;
                switch (option)
                {
                    case NO_PLAY:
                        Console.WriteLine("No Play, Pass the chance");
                        break;
                    case LADDER:
                        player += dieValue;
                        Console.WriteLine("You got Ladder \n player position = " + player);
                        break;
                    case SNAKE:
                        player -= dieValue;
                        Console.WriteLine("You gotSnake \n player position = " + player);
                        break;
                }
            }
        }
    }


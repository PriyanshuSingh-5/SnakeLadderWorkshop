using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeNdLadder
{
    class DieRoll
    {
        public static void RollTheDie()
        {
            Random random = new Random();
            int DieValue = random.Next(0, 6);
            Console.WriteLine("player rolls a die" + DieValue);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Program
    {
        static void Main(string[] args)
        {

            Game game = new Game();

            UI.introduction();
            Console.WriteLine("");
            UI.rules1();
            Console.WriteLine("");
            UI.rules2();
            Console.WriteLine("");
            game.playGame();
            Console.WriteLine("Press Any Button to Exist");
            Console.ReadKey();
        }
    }
}

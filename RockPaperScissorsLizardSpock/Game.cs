using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {
        Player playerOne;
        Player playerTwo;

        public void playGame()
        {

            switch (getNumberofHumans())
            {
                case "1":
                    //functions for player vs computer
                    break;
                case "2":
                    //functions for player vs player
                    break;
                default:
                    UI.PleaseTryAgain();
                    UI.askNumberofHumans();
                    playGame();
                    //text function that says try again.
                    break;
            }
        }

        public string getNumberofHumans()
        {
            string humans;
            UI.askNumberofHumans();
            humans = Console.ReadLine();
            return humans;
        }
    }
}

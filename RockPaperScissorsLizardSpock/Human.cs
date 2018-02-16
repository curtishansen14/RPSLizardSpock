using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {
        //member variables
        string userInput;

        //constructor
        public Human()
        {
            Score = 0;
        }

        //member methods
        public override string GetName()
        {
            Name = Console.ReadLine();
            return Name;
        }

        public override int GetChampion()
        {
            UI.askForChampionName();
            switch (getUserInput())
            {
                case "1":
                    return Champion = 0;
                case "2":
                    return Champion = 1;
                case "3":
                    return Champion = 2;
                case "4":
                    return Champion = 3;
                case "5":
                    return Champion = 4;
                default:
                    UI.PleaseTryAgain();
                    GetChampion();
                    break;         
            }
                   
            return base.GetChampion();
        }

        public string getUserInput()
        {
            userInput = Console.ReadLine();
            return userInput;
        }
    }
}

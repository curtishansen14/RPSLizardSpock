using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    public static class UI
    {
        public static void introduction()
        {
            Console.WriteLine("Welcome to Rock Paper Scissors Lizard Spock");
            Console.WriteLine("Best two out of three wins");
            Console.WriteLine("The game works just like Rock Paper Scissors but this a Lizard and a Spock");
            Console.WriteLine("You can play against another person or against the computer");
        }

        public static void rules1()
        {
            Console.WriteLine("Scissors cuts Paper");
            Console.WriteLine("Paper covers Rock");
            Console.WriteLine("Rock crushes Lizard");
            Console.WriteLine("Lizard poisons Spock");
            Console.WriteLine("Spock smashes Scissors");
            Console.WriteLine("Scissors decapitates Lizard");
            Console.WriteLine("Lizard eats Paper");
            Console.WriteLine("Paper disproves Spock");
            Console.WriteLine("Spock vaporizes Rock");
            Console.WriteLine("Rock crushes Scissors");
        }

        public static void rules2()
        {
            Console.WriteLine("Put another way that is:");
            Console.WriteLine("Scissors beats Paper & Lizard");
            Console.WriteLine("Paper beats Spock & Paper");
            Console.WriteLine("Rock beats Lizard & Scissors");
            Console.WriteLine("Spock beats Scissors & Rock");
            Console.WriteLine("Lizard beats Paper & Spock ");
        }

        public static void reminder()
        {
            Console.WriteLine("Scissors beats Paper & Lizard");
            Console.WriteLine("Paper beats Spock & Paper");
            Console.WriteLine("Rock beats Lizard & Scissors");
            Console.WriteLine("Spock beats Scissors & Rock");
            Console.WriteLine("Lizard beats Paper & Spock ");
        }

        public static void askNumberofHumans()
        {
            Console.WriteLine("How many humans are playing 1 or 2?");
        }

        public static void askForName()
        {
            Console.WriteLine("Please enter your name");
        }

        public static void askForChampionName()
        {
            Console.WriteLine("Select Champion");
            Console.WriteLine("1 for Rock");
            Console.WriteLine("2 for Paper");
            Console.WriteLine("3 for Scissors");
            Console.WriteLine("4 for Lizard");
            Console.WriteLine("5 for Spock");
        }

        public static void playerVsPlayerIntro()
        {
            Console.WriteLine("You have chosen Human vs Human.");
        }

        public static void playerVsComputer()
        {
            Console.WriteLine("You have choosen Human vs computer");
        }

        public static void DisplayScore(string P1name, int P1score, string P2Name, int P2Score)
        {
            Console.WriteLine("{0}: {1} {2}: {3}", P1name, P1score, P2Name, P2Score);
        }

        public static void Scores(string name)
        {
            Console.WriteLine("{0} scores.", name);
        }

        public static void DeclareWinner(string name, int score, int Score)
        {
            Console.WriteLine("{0} Wins! {1} to {2} ", name, score, Score);
        }
        //Error Messages 


        public static void PleaseTryAgain()
        {
            Console.WriteLine("Please try again.");
        }


        //Delcaration of Winning Champions  
        public static void ScissorsCutsPaper()
        {
            Console.WriteLine("Scissors Cuts Paper");

        }
        public static void paperCoversRock()
        {
            Console.WriteLine("Paper covers Rock");

        }

        public static void RockCrushesLizard()
        {
            Console.WriteLine("Rock crushes Lizard");

        }
        public static void LizardPoisonsSpock()
        {
            Console.WriteLine("Lizard poisons Spock");

        }
        public static void SpockSmashesScissors()
        {
            Console.WriteLine("Spock smach Scissors");

        }

        public static void ScissorsDecapitatesLizard()
        {
            Console.WriteLine("Scissors decapitates Lizard");

        }
        public static void LizardEatsPaper()
        {
            Console.WriteLine("Lizards eats Paper");

        }
        public static void PaperDisprovesSpock()
        {
            Console.WriteLine("Paper dispove Spock");

        }
        public static void SpockVaporizesRock()
        {
            Console.WriteLine("Spock vaporizes Rock");

        }
        public static void RockCrushesScissors()
        {
            Console.WriteLine("Rock crushes Scissors");

        }

    }
}


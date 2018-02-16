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
        int judge;
        int numberOfChampions;
        int Champion1;
        int Champion2;
        string humans;
        int Winner;

        public Game()
        {
            Winner = 0;
            numberOfChampions = 5;
            playerOne = new Player();
            playerTwo = new Player();
        }

        public void playGame()
        {
            
            switch (getNumberOfHumans())
            {
                case "1":
                    playerOne = new Human();
                    playerTwo = new Computer();
                    UI.askForName();
                    playerOne.GetName();
                    playerTwo.GetName();
                    PlayervsPlayer();
                    return;
                case "2":
                    playerOne = new Human();
                    playerTwo = new Human();
                    UI.askForName();
                    playerOne.GetName();
                    UI.askForName();
                    playerTwo.GetName();
                    PlayervsPlayer();
                    return;
                default:
                    UI.PleaseTryAgain();
                    playGame();
                    break;
            }
        }

        public void PlayervsPlayer()
        {
            while (Winner != 1)
            {
                Round();
                CheckWinner(playerOne.Score, playerTwo.Score);
            }
        }

        public string getNumberOfHumans()
        {
            UI.askNumberofHumans();
            humans = Console.ReadLine();
            return humans;
        }

        public int setJudge(int Champion1, int Champion2)
        {

            judge = (NumberofChampions + Champion1 - Champion2) % NumberofChampions;

            return judge; 
        }

        public void ScoreRound(int judge)
        {
            if (judge == 1 || judge == 3)
            {
                playerOne.Score+= 1;
                UI.Scores(playerOne.Name);
            }
            else if (judge == 2 || judge == 4)
            {
                playerTwo.Score+= 1;
                UI.Scores(playerTwo.Name);
            }
            else
            {
                Console.WriteLine("Stalemate!");
            }
                
        }

        public void Round()
        {
            Champion1 = playerOne.GetChampion();
            Champion2 = playerTwo.GetChampion();

            judge = setJudge(Champion1, Champion2);
            ScoreRound(judge);
        }

        public int CheckWinner(int P1Score, int P2Score)
        {
                if (P1Score >= 2 )
                {
                    UI.DisplayScore(playerOne.Name, playerOne.Score, playerTwo.Name, playerTwo.Score);
                    Console.WriteLine("");
                    UI.DeclareWinner(playerOne.Name, playerOne.Score, playerTwo.Score);
                    return Winner = 1; 
                }
                if (P2Score >= 2)
                {
                UI.DisplayScore(playerOne.Name, playerOne.Score, playerTwo.Name, playerTwo.Score);
                Console.WriteLine("");
                UI.DeclareWinner(playerTwo.Name, playerTwo.Score, playerOne.Score);
                return Winner = 1;
                }
            Winner = 0;
            return Winner;
        }

        public int Judge
        {
            get { return judge; }
            set { judge = value; }
        }

        public int NumberofChampions
        {
            get { return numberOfChampions; }
            set { numberOfChampions = value; }
        }
    }
}

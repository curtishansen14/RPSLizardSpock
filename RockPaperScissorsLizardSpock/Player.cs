using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Player
    {
        //member variables
        int champion;
        string name;
        int score;

        //constructor
        public Player()
        {

        }
        //member methods
        public virtual int GetChampion()
        {
            return champion;
        }

        public virtual string GetName()
        {
            return name;
        }

        public  int Champion
        {
            get { return champion; }
            set { champion = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Score
        {
            get { return score; }
            set { score = value; }
        }
    }
}

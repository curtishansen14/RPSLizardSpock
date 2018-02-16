using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        //member variables
        Random rnd;

        //constructor
        public Computer()
        {
            rnd = new Random();
            Score = 0;
        }

        //member methods
        public override int GetChampion()
        {
            Champion = rnd.Next(0, 5);
            return Champion;
        }

        public override string GetName()
        {
            Name = "Gerrald 'Say his name' WALLACE!";
            return Name;
        }
    }
}

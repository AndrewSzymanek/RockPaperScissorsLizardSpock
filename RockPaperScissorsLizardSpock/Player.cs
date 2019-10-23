using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    abstract class Player
    {

        // member variables (HAS A)
        public int score;
        public string name;
        public List<string> gestures;


        // constructor
        public Player()
        {
            score = 0;
            gestures = new List<string>(){ "rock", "paper", "scissors", "lizard", "spock" };
        }



        // member methods (CAN DO)
        public virtual void ChooseGesture()
        {
            //can stay empty since it's virtual and will be overridden
        }
    }
}

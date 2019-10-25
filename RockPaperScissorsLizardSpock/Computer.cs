using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Computer : Player
    {
        // member variables (HAS A)
        private Random randomGesture;

        // constructor
        public Computer()
        {
            randomGesture= new Random();
            
        }

        // member methods (CAN DO)
        public override string ChooseGesture()
        {
           int randomNum = randomGesture.Next(0, gestures.Count);
            string chosenGesture = gestures[randomNum];
            return chosenGesture;           
        }
        public override void ChooseName()
        {
            name = "The Iron Giant";
        }
    }
}

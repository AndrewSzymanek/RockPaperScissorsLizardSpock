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




        // constructor
        public Computer()
        {
            name = "Computer";
        }



        // member methods (CAN DO)
        public override void ChooseGesture()
        {
            //computer needs to be able to randomly pick a gesture from the list
        }
    }
}

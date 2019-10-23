using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Human : Player
    {

        // member variables (HAS A)


        // constructor
        public Human()
        {
            name = "Andrew";
        }

        public override void ChooseGesture()
        {
            //need to specify how the human is going to choose from the list of gestures
        }

        // member methods (CAN DO)
    }
}

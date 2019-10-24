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

        //inherits Player member variables(score, name, and list of gestures)

        // constructor
        public Human()
        {
            
        }

        public override string ChooseGesture()
        {
            Console.WriteLine("Please enter a gesture from the following: 'rock', 'paper', 'scissors', 'lizard', 'spock'");
            string chosenGesture = Console.ReadLine();

            return chosenGesture;
            //need to specify how the human is going to choose from the list of gestures
        }
        public override void ChooseName()
        {
            Console.WriteLine("Choose your name");
            name = Console.ReadLine();
        }

        // member methods (CAN DO)
    }
}

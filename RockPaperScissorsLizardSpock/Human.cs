﻿using System;
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
            
        }

      


        // member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("Choose your name");
            name = Console.ReadLine();
        }
        public override string ChooseGesture()
        {
            Console.WriteLine("Please enter a gesture from the following: rock, paper, scissors, lizard, spock");
            string chosenGesture = Console.ReadLine();

            //verify user input is gesture from list gestures
           
                return chosenGesture;
            
           
            
        }
    }
}

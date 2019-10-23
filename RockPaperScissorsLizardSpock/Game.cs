using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissorsLizardSpock
{
    class Game
    {

        // member variables (HAS A)
        Player player1;
        Player player2;
        Player computer;

        // constructor

        public Game() {
            player1 = new Human();
            player2 = new Human();
            computer = new Computer();


        }


        // member methods (CAN DO)

        public void Rules()
        {
            Console.WriteLine("Play RockPaperScissorsLizardSpock like the Big Bang cast.");
        }

        public void RunGame()
        {
            while(player1.score < 2) 
            {

            }

        }
        public string SingleOrMultiPrompt()
        {
            Console.WriteLine("Would you like to play against a computer buddy or a human buddy? Answer 'human' or 'computer'.");
            string result = Console.ReadLine();

            switch (result)
            {
                case "human":
                    Console.WriteLine("You chose a human buddy.");
                    break;
                case "computer":
                    Console.WriteLine("You chose a computer buddy.");
                    break;
                default:
                    Console.WriteLine("Not a valid response. Enter 'human' or 'computer'.");
                    break;
            }
            return result;
        }

      

        
    }
}

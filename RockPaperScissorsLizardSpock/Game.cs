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
        

        // constructor

        public Game() {
            player1 = new Human();
            player2 = new Human();
            


        }


        // member methods (CAN DO)


        public void RunGame()
        {

            //display rules
            CreatePlayers(playersResult);
            player1.ChooseGesture();
            player2.ChooseGesture();

        }
        public void Rules()
        {
            Console.WriteLine("Play RockPaperScissorsLizardSpock like the Big Bang cast.");
        }

        
        public void SingleOrMultiPrompt()
        {
            Console.WriteLine("Would you like to play against a computer buddy or a human buddy? Answer 'human' or 'computer'.");
            string playerResult = Console.ReadLine();

            CreatePlayers(playerResult);
            
        }

        public void CreatePlayers(string playersResult)
        {
            if (playersResult == "computer")
            {
                player1 = new Human();
                player2 = new Computer();
            }
                
            else if(playersResult == "human"){
                player1 = new Human();
                player2 = new Human();
            }

        }

      

        
    }
}

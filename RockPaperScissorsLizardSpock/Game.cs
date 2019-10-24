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
        string player1Gesture; //not sure if I want these 
        string player2Gesture; //
        

        // constructor

        public Game() {
           
           
        }


        // member methods (CAN DO)

        public void RunGame()
        {

            Rules();
            string playersResult = SingleOrMultiPrompt();
            CreatePlayers(playersResult);
            string player1Gesture = player1.ChooseGesture();
            string player2Gesture = player2.ChooseGesture();
            CompareGestures(player1Gesture, player2Gesture);
        }
        public void Rules()
        {
            Console.WriteLine("Play RockPaperScissorsLizardSpock like the Big Bang Theory cast. Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
        }

        
        public string SingleOrMultiPrompt()
        {
            Console.WriteLine("Would you like to play against a computer buddy or a human buddy? Answer 'human' or 'computer'.");
            string playerResult = Console.ReadLine();

           
            return playerResult;
            
            
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
            player1.ChooseName();
            player2.ChooseName();

        }

        public void CompareGestures(string Gesture1, string Gesture2)
        {
            Gesture1 = player1Gesture;
            Gesture2 = player2Gesture;
            if( player1Gesture = rock)

            }
           
            //switch case?




            //player1.score = score++;
            //player2.score = score++;
        }
        
    }
}

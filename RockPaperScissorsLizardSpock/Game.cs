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
                     
        }

        // member methods (CAN DO)
        public void RunGame()
        {

            Rules();
            string playersResult = SingleOrMultiPrompt();
            CreatePlayers(playersResult);
            while(player1.score <= 2 && player2.score <= 2)
            {
                string player1Gesture = player1.ChooseGesture();
                Console.WriteLine(player1.name + " "+  "chose:" + " " + player1Gesture);
                string player2Gesture = player2.ChooseGesture();
                Console.WriteLine(player2.name + " "+ "chose:" + " " + player2Gesture);
                CompareGestures(player1Gesture, player2Gesture);
                Console.WriteLine(player1.name + " " + "score is: " + player1.score);
                Console.WriteLine(player2.name + " " + "score is: " + player2.score);
            }
            if(player1.score == 3 || player2.score == 3)
            {
                Console.WriteLine("We have a winner!");                
            }
        }
        public void Rules()
        {
            Console.WriteLine("Play RockPaperScissorsLizardSpock like the Big Bang Theory cast!");
            Console.WriteLine("Rock crushes Scissors\nScissors cuts Paper\nPaper covers Rock\nRock crushes Lizard\nLizard poisons Spock\nSpock smashes Scissors\nScissors decapitates Lizard\nLizard eats Paper\nPaper disproves Spock\nSpock vaporizes Rock");
        }       
        public string SingleOrMultiPrompt()
        {
            Console.WriteLine("Would you like to play against a computer buddy or a human buddy? Answer 'human' or 'computer'.");
            string playerResult = Console.ReadLine();

            if (playerResult == "human" || playerResult == "computer")
            {
                return playerResult;
            }
            else
            {
                Console.WriteLine("Write 'human' or 'computer'.");
                return SingleOrMultiPrompt();
            }
        }
        public void CreatePlayers(string playersResult)
        {
            if (playersResult == "computer")
            {
                player1 = new Human();
                player2 = new Computer();
                player1.ChooseName();
                player2.ChooseName();
            }
            else if (playersResult == "human")
            {
                player1 = new Human();               
                player2 = new Human();
                Console.WriteLine("Player1, please...");
                player1.ChooseName();
                Console.WriteLine("Player2, please...");
                player2.ChooseName();
            }
        }
        public void CompareGestures(string player1Gesture, string player2Gesture)
        {          
            if (player1Gesture == player2Gesture)
            {
                Console.WriteLine("It's a tie!");
            }
            else if (player1Gesture != player2Gesture)
            {
                switch (player1Gesture)
                {
                    case "rock":
                        switch (player2Gesture)
                        {
                            case "scissors":
                                player1.score++;
                                break;
                            case "lizard":
                                player1.score++;
                                break;
                            default:
                                player2.score++;
                                break;
                        }
                        break;
                    case "paper":
                        switch (player2Gesture)
                        {
                            case "rock":
                                player1.score++;
                                break;
                            case "spock":
                                player1.score++;
                                break;
                            default:
                                player2.score++;
                                break;
                        }
                        break;
                    case "scissors":
                        switch (player2Gesture)
                        {
                            case "paper":
                                player1.score++;
                                break;
                            case "lizard":
                                player1.score++;
                                break;
                            default:
                                player2.score++;
                                break;
                        }
                        break;
                    case "lizard":
                        switch (player2Gesture)
                        {
                            case "paper":
                                player1.score++;
                                break;
                            case "spock":
                                player1.score++;
                                break;
                            default:
                                player2.score++;
                                break;
                        }
                        break;
                    case "spock":
                        switch (player2Gesture)
                        {
                            case "rock":
                                player1.score++;
                                break;
                            case "scissors":
                                player1.score++;
                                break;
                            default:
                                player2.score++;
                                break;
                        }
                        break;
                }
            }       
        }
    }
}


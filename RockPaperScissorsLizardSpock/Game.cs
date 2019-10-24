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
            Console.WriteLine("Play RockPaperScissorsLizardSpock like the Big Bang Theory cast.");
            Console.WriteLine("Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock");
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


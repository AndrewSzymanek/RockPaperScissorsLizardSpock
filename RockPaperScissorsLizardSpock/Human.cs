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
            
        }

      


        // member methods (CAN DO)
        public override void ChooseName()
        {
            Console.WriteLine("Choose your name");
            name = Console.ReadLine();
        }
        public override string ChooseGesture()
        {
            Console.WriteLine("Please enter a number for a gesture from the following: \n1)rock\n2)paper\n3)scissors\n4)lizard\n5)spock");
            string chosenGesture = "";
            try
            {
                int choice = Int32.Parse(Console.ReadLine());
                chosenGesture = gestures[choice - 1];
            }
            catch(IndexOutOfRangeException)
            {
                Console.WriteLine("Please enter a number between 1 and 5 representing your choice of gesture.");
                ChooseGesture();
            }
            catch(FormatException)
            {
                Console.WriteLine("Please enter a number, not a word.");
                ChooseGesture();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //validate user input is gesture from list gestures
           
                return chosenGesture;
                     
            
        }
    }
}

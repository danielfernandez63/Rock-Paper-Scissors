using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Player
    {
        public string answer;
        public int choice;
        public string name;
        public int score;
        public int wins;
        
        public virtual void  ChooseGesture()   
       {
        Console.WriteLine("");
        Console.WriteLine("Please select your choice. Select one of the following gestures: 'rock' 'paper' 'scissor' 'spock' 'lizard'." );
        answer = Console.ReadLine().ToLower().Trim();

            if (answer == "rock")
            {
                choice = 0;
            }
            else if (answer == "paper")
            {
                choice = 1;
            }
            else if (answer == "scissor")
            {
                choice = 2;
            }
            else if (answer == "spock")
            {
                choice = 3;
            }
            else if (answer == "lizard")
            {
                choice = 4;
            }
            else 
            {
                Console.WriteLine("Not a valid response. Please follow directions. Hit enter when ready");
                Console.ReadLine();
                ChooseGesture();
            }


        }

    }
}

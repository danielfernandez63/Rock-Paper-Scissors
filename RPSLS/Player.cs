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

         //inheriting who 
        //make a method for human rolling?
        
        //make a method for computer rolling
        

        

        //playing gestures aka back and forth

       public virtual void  ChooseGesture()   //need to make sure this is my abstract as this will pass on my commands but ai needs to override.
       {
        Console.WriteLine("Please select your choice, select one of these: 'rock' 'paper' 'scissor' 'spock' 'lizard'." );
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
                Console.WriteLine("Not a valid response. Please follow directions");
                Console.ReadLine();
                ChooseGesture();
            }


        }



    }
}

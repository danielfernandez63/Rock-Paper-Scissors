using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        
       Players player1;
       Players player2;
       public string response;

        public void StartDirections()
        {
         Console.WriteLine("");
         Console.WriteLine("This is like a traditional game of rock paper scissors. But there is an added element of lizard and spock.");
         Console.WriteLine("");
         Console.WriteLine("Directions for how to win: Rock crushes Scissors, Scissors cuts Paper, Paper covers Rock, Rock crushes Lizard, Lizard poisons Spock, Spock smashes Scissors, Scissors decapitates Lizard, Lizard eats Paper, Paper disproves Spock, Spock vaporizes Rock.");
         Console.WriteLine("");
         Console.WriteLine("Hit enter when ready.");
         Console.ReadLine();
         Console.WriteLine("");
            StartGame();
        }
    
        public void StartGame()
        {
         Console.WriteLine("Welcome to RPSLS! Do you want to play with someone or the computer. Type 'PVP' for person and 'PVE' for computer");
         response = Console.ReadLine().ToLower().Trim();

          if (response == "pvp")
          {
          player1 = new Human("Player 1");
          player2 = new Human("Players 2");
          }

          else if (response == "pve")
          {
          player1 = new Human("Player 1");
          player2 = new Computer("Computer");
          }

          else
          {
          Console.WriteLine("Not a valid response. Please follow directions");
          Console.ReadLine();
          StartGame();
          }
           Players players = new Players();
           players.ChooseGesture();
            
            
        }

        
         //method to read results from the score board to obtain who is winner
            
            
            
            

            
            
        
            
        
 
    }

}

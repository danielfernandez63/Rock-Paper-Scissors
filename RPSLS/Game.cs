using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {
        //member vars (HAS A)
       Players player1;
       Players player2;
       public string response;


        //public Game()
        //{
        //userPlayer1 = new Human();
        //}
        


        public void StartGame()
        {

         Console.WriteLine("Welcome to RPSLS, do you want to play with someone or the computer. Type 'PVP' for person and 'PVE' for computer");
         response = Console.ReadLine();

          if (response == "PVP")
          {
          player1 = new Human();
          player2 = new Human();
          }

          else if (response == "PVE")
          {
          player1 = new Human();
          player2 = new Computer();
          }

          else
          {
          Console.WriteLine("Not a valid response. Please follow directions");
          Console.ReadLine();
          StartGame();
          }

           Players players = new Players();
           players.PlayGame();
            
          
                 
            
        }

         //method to read results from the score board to obtain who is winner
            
            
            
            

            
            
        
            
        
 
    }

}

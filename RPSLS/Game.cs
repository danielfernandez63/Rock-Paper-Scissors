using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    class Game
    {
        //member vars (HAS A)
       public string userPlayer1;
       public string userPlayer2;
       public string response;

        //public Game()
        //{
            //userPlayer1 = new Human();

        //}

        public void StartGame()
        {

         //public string response;

         Console.WriteLine("Welcome to RPSLS, do you want to play with someone or the computer. Type 'PVP' for person and 'PVE' for computer");
         response = Console.ReadLine();

          if (response == "PVP")
          {
          userPlayer1 = new Human();
          userPlayer2 = new Human();
          }

          else if (response == "PVE")
          {
          userPlayer1 = new Human();
          userPlayer2 = new Computer();
          }

          else
          {
          Console.WriteLine("Not a valid response. Please follow directions");
          Console.ReadLine();
          StartGame();
          }
                
          
                 
            
        }

         
            public void Human()
            {
            
            }

            public void Computer()
            {

            }
        
 
    }

}

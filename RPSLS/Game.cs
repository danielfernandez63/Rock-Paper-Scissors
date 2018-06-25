using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPSLS
{
    public class Game
    {

       Player player1;
       Player player2;
       public string response;
       public int wins;

       public List<string> gestureOptions;

       public string[,] gestureOutcomes;

       public List<int> calculationOptions;



        //member constructor

        public Game()

        {

            gestureOptions = new List<string> { "Rock", "Paper", "Scissors", "Spock", "Lizard" };

            gestureOutcomes = new string[,] { { "", "", "crushes", "", "crushes" }, { "covers", "", "", "disproves", "" }, { "", "cuts", "", "", "decapitates" }, { "vaporizes", "", "disassembles", "", "" }, { "", "eats", "", "poisons", "" } };

            calculationOptions = new List<int> { 4, 0, 1, 2, 3, 4, 0, 1 };

        }


        public void RunGame()
        {
            StartDirections();
            SetUpGame();

            for (int i = 0; (player1.wins < 2 && player2.wins < 2); i++)

            {

                PlayGame();
                CompareGestures();

            }

            FindWinner();
            Console.ReadLine();

        }

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
            
        }
    
        public void SetUpGame()
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
          Console.ReadLine();
          SetUpGame();
          }
            
        }

        public void PlayGame()
        {
            player1.ChooseGesture();
            player2.ChooseGesture();
            if (player1.choice == player2.choice)
            {
                Console.WriteLine("Both players have picked  " + player1.choice + "!  It's a tie, try again!");
                Console.ReadLine();
                PlayGame();
            }
            else
            {
                CompareGestures();
            }
        }

        public void CompareGestures()
        {
               

            if ((player2.choice==calculationOptions[player1.choice])||(player2.choice==calculationOptions[player1.choice+3]))

            {

                Console.WriteLine("Player one wins!  "+ gestureOptions[player1.choice]+" "+ gestureOutcomes[player1.choice,player2.choice]+" "+gestureOptions[player2.choice]+"!");

                player1.wins += 1;

            }

            else

            {

                Console.WriteLine("Player two wins!  " + gestureOptions[player2.choice] + " " + gestureOutcomes[player2.choice, player1.choice] + " " + gestureOptions[player1.choice]+"!");

                player2.wins += 1;


            }


        }

        public void FindWinner()
        {
            if (player1.wins == 2)
            {

                Console.WriteLine("Player One is the winner!");

            }
    
            else
            {

                Console.WriteLine("Player Two is the winner!");

            }

        }



    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public class Game
    {
        //                  MEMBER VARIABLES (WHAT IT HAS)
        public int roundCount;
        public List<Player> players;
        public HumanPlayer playerOneHuman;
        public HumanPlayer playerTwoHuman;
        public ComputerPlayer playerTwoComputer;

        //                  CONSTRUCTOR (SPAWNER)
        public Game()
        {
            this.roundCount = 0;
            players = new List<Player>();
        }

        //                  MEMBER METHODS (WHAT IT CAN DO)
        public void AskForGesture()
        {
            Console.WriteLine("Please type your selected gesture and press Enter");
            Console.WriteLine("Choose from: Rock - Paper - Scissors - Lizard - Spock");
        }

        public void SinglePlayerCreatePlayers()
        {
            
            playerOneHuman = new HumanPlayer();
            players.Add(playerOneHuman);
            playerTwoComputer = new ComputerPlayer();
            players.Add(playerTwoComputer);

        }

        public void MultiplayerCreatePlayers()
        {
            playerOneHuman = new HumanPlayer();
            players.Add(playerOneHuman);
            playerTwoHuman = new HumanPlayer();
            players.Add(playerTwoHuman);
        }
        
        public void InitialMenu()
        {
            Console.WriteLine("ROCK PAPER SCISSORS LIZARD SPOCK");
            Console.WriteLine("Enter 1 for Singleplayer or 2 for Multiplayer");
            string input = Console.ReadLine();
            switch(input)
            {
                case "1" :
                    SinglePlayerCreatePlayers();
                    break;
                case "2" :
                    MultiplayerCreatePlayers();
                    break;
            }
        }

        public void ShowScore()
        {
            Console.WriteLine("Player 1: " + players[0].score);
            Console.WriteLine("Player 1: " + players[1].score);
        }

        public void gestureCompare(string player1gesture, string player2gesture, Player player1, Player player2)
        {
            //Player 1 round victory cases
            if (player1gesture == player1.gestures[0] && player2gesture == player2.gestures[2])
            {
                Console.WriteLine("Player 1's " + player1gesture + " crushes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[2] && player2gesture == player2.gestures[1])
            {
                Console.WriteLine("Player 1's " + player1gesture + " cuts Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[1] && player2gesture == player2.gestures[0])
            {
                Console.WriteLine("Player 1's " + player1gesture + " covers Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[0] && player2gesture == player2.gestures[3])
            {
                Console.WriteLine("Player 1's " + player1gesture + " crushes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[3] && player2gesture == player2.gestures[4])
            {
                Console.WriteLine("Player 1's " + player1gesture + " poisons Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[4] && player2gesture == player2.gestures[2])
            {
                Console.WriteLine("Player 1's " + player1gesture + " smashes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[2] && player2gesture == player2.gestures[3])
            {
                Console.WriteLine("Player 1's " + player1gesture + " decapitates Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[3] && player2gesture == player2.gestures[1])
            {
                Console.WriteLine("Player 1's " + player1gesture + " eats Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[1] && player2gesture == player2.gestures[4])
            {
                Console.WriteLine("Player 1's " + player1gesture + " disproves Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            else if (player1gesture == player1.gestures[4] && player2gesture == player2.gestures[0])
            {
                Console.WriteLine("Player 1's " + player1gesture + " vaporizes Player 2's " + player2gesture + "!");
                player1.IncrementScore();
            }
            //player 2 round victory cases
            else if (player2gesture == player2.gestures[0] && player1gesture == player1.gestures[2])
            {
                Console.WriteLine("Player 2's " + player2gesture + " crushes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[2] && player1gesture == player1.gestures[1])
            {
                Console.WriteLine("Player 2's " + player2gesture + " cuts Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[1] && player1gesture == player1.gestures[0])
            {
                Console.WriteLine("Player 2's " + player2gesture + " covers Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[0] && player1gesture == player1.gestures[3])
            {
                Console.WriteLine("Player 2's " + player2gesture + " crushes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[3] && player1gesture == player1.gestures[4])
            {
                Console.WriteLine("Player 2's " + player2gesture + " poisons Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[4] && player1gesture == player1.gestures[2])
            {
                Console.WriteLine("Player 2's " + player2gesture + " smashes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[2] && player1gesture == player1.gestures[3])
            {
                Console.WriteLine("Player 2's " + player2gesture + " decapitates Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[3] && player1gesture == player1.gestures[1])
            {
                Console.WriteLine("Player 2's " + player2gesture + " eats Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[1] && player1gesture == player1.gestures[4])
            {
                Console.WriteLine("Player 2's " + player2gesture + " disproves Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            else if (player2gesture == player2.gestures[4] && player1gesture == player1.gestures[0])
            {
                Console.WriteLine("Player 2's " + player2gesture + " vaporizes Player 1's " + player1gesture + "!");
                player2.IncrementScore();
            }
            //edge case
            else
            {
                Console.WriteLine("Error comparing player gestures");
            }
        }
    }
}

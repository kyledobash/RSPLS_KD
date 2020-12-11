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

        public void gestureCompare(string player1gesture, string player2gesture, Player player1, Player player2)
        {
            if (player1gesture == "Rock" && player2gesture == "Scissors" )
            {
                Console.WriteLine(player1gesture + " crushes " + player2gesture);
                playerOne.score++
            }
        }
    }
}

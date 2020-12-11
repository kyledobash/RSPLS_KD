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
        int roundCount;

        //                  CONSTRUCTOR (SPAWNER)
        public Game()
        {
            this.roundCount = 0;
        }

        //                  MEMBER METHODS (WHAT IT CAN DO)
        public void AskForGesture()
        {
            Console.WriteLine("Please type your selected gesture and press Enter");
            Console.WriteLine("Choose from: Rock - Paper - Scissors - Lizard - Spock");
        }

        public void SinglePlayerCreatePlayers()
        {
            HumanPlayer playerOne = new HumanPlayer();
            ComputerPlayer playerTwo = new ComputerPlayer();
        }

        public void MultiplayerCreatePlayers()
        {
            HumanPlayer playerOne = new HumanPlayer();
            HumanPlayer playerTwo = new HumanPlayer();
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
    }
}

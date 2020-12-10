using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public class Game
    {
        //MEMBER VARIABLES (WHAT IT HAS)
        int roundCount;

        //CONSTRUCTOR (SPAWNER)
        public Game()
        {
            this.roundCount = 0;
        }

        //MEMBER METHODS (WHAT IT CAN DO)
        public void AskForGesture()
        {
            Console.WriteLine("Please type your selected gesture and press Enter");
            Console.WriteLine("Choose from: Rock - Paper - Scissors - Lizard - Spock");
        }

        //create a vet input method
    }
}

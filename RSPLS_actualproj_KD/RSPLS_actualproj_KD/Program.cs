using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate a new game
            //call a master method, that calls all other methods in order
            Game game = new Game();
            game.ExecuteGameFlow();

            //Player somePlayer = new Player();
            //HumanPlayer anotherPlayer = new HumanPlayer();
            //ComputerPlayer evilRobotPlayer = new ComputerPlayer();


            // KYLE'S HOMEWORK (NO GOLD STAR, SORRY)
            // Fix inheritance stuff (Player parent class as member variables in Game)
            // Research .ToLower() extension method in C# and refactor COMPLETE
        }
    }
}

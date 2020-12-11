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
            game.MultiplayerCreatePlayers();
        }
    }
}

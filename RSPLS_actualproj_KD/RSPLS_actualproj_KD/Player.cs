using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public abstract class Player
    {
        //                  MEMBER VARIABLES (WHAT IT HAS)
        public List<string> gestures;
        public int score;

        //                  CONSTRUCTOR (SPAWNER)
        public Player()
        {
            score = 0;

            gestures = new List<string> { };
            gestures.Add("Rock");
            gestures.Add("Paper");
            gestures.Add("Scissors");
            gestures.Add("Lizard");
            gestures.Add("Spock");
        }

        //                  MEMBER METHODS (WHAT IT CAN DO)

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public class HumanPlayer : Player
    {
        //MEMBER VARIABLES (WHAT IT HAS)

        //CONSTRUCTOR (SPAWNER)
        public HumanPlayer()
        {

        }
        //MEMBER METHODS (WHAT IT CAN DO)
        public string HumanPickGesture()
        {
            string humanInput = Console.ReadLine();
            humanInput.ToUpper();

            switch (humanInput)
            {
                case "ROCK" :
                    return gestures[0];
                case "PAPER" :
                    return gestures[1];
                case "SCISSORS" :
                    return gestures[2];
                case "LIZARD" :
                    return gestures[3];
                case "SPOCK" :
                    return gestures[4];
                default :
                    return "INVALID";
            }
        }
    }
}

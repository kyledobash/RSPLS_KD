using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RSPLS_actualproj_KD
{
    public class ComputerPlayer : Player
    {
        //                  MEMBER VARIABLES (WHAT IT HAS)


        //                  CONSTRUCTOR (SPAWNER)
        public ComputerPlayer()
        {
            
        }

        //                  MEMBER METHODS (WHAT IT CAN DO)
        public override string PickGesture()
        {
            Random selection = new Random();
            int selectionInt = selection.Next(0, 4);
            return gestures[selectionInt];
        }
    }
}

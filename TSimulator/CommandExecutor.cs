using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSimulator.StreamModels;

namespace TSimulator
{
    class CommandExecutor
    {
        /// <summary>
        /// Executes a top or end command
        /// </summary>
        /// <param name="command"></param>
        public static void ExecuteCommand(Command command)
        {
            if (command.CommandType == ControlInputModel.CommandType.top)
            {
                
            }
            else if (command.CommandType == ControlInputModel.CommandType.end)
            {
                Console.WriteLine("Exiting program.");
            }
            else
            {
                throw new Exception("CommandType was not set.");
            }
        }

        /// <summary>
        /// Replaces current history file with all the bids in the current bid streams
        /// </summary>
        /// <param name="state"></param>
        public static void SaveHistory(StreamStates state)
        {
            
        }
    }
}

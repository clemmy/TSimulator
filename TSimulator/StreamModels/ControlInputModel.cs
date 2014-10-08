using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using TSimulator.Helpers;

namespace TSimulator.StreamModels
{
    class ControlInputModel
    {
        public enum CommandType
        {
            none,
            top,
            end
        };

        public Command CurrentCommand { get; set; }

        /// <summary>
        /// Updates the command in the control input text file stream
        /// </summary>
        /// <param name="line">the string representation of the command</param>
        public void UpdateCurrentCommand(string line)
        {
            try
            {
                string[] words = line.Split(' ');
                if (words.Count() == 3)
                {
                    if (words[0].Equals("top") && isInt(words[1]) && isInt(words[2]))
                    {
                        CurrentCommand = new Command(Int32.Parse(words[1]), Int32.Parse(words[2]));
                        OutputHelper.WriteInRed("top command!");
                    }
                    else
                    {
                        throw new Exception("Invalid command");
                    }
                }
                else if (words.Count() == 1)
                {
                    if (!words[0].Equals("end"))
                        throw new Exception("Invalid command");

                    this.CurrentCommand = new Command() {CommandType = CommandType.end};
                    OutputHelper.WriteInRed("end command!");
                }
                else
                {
                    throw new Exception("Invalid command.");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            
        }

        private bool isInt(string s)
        {
            try
            {
                int dummy = Int32.Parse(s);
            }
            catch (Exception)
            {
                throw;
            }
            return true;
        }

        public ControlInputModel()
        {
            this.CurrentCommand = new Command();
        }
    }

    class Command
    {
        public ControlInputModel.CommandType CommandType { get; set; }
        /// <summary>
        /// first argument specified by user
        /// </summary>
        public int? TotalBids { get; set; }
        /// <summary>
        /// second argument specified by user
        /// </summary>
        public int? NumArg { get; set; }

        public Command()
        {
            this.CommandType = ControlInputModel.CommandType.none;
            TotalBids = null;
            NumArg = null;
        }

        public Command(int totalBids, int numArgs)
        {
            this.CommandType = ControlInputModel.CommandType.top;
            TotalBids = totalBids;
            NumArg = numArgs;
        }
    }
}

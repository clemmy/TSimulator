using System;
using System.Linq;
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
                        Console.WriteLine(line);
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
                    OutputHelper.WriteInRed("end");
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


}

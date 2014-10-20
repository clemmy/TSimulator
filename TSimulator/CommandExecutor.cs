using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using TSimulator.Helpers;

namespace TSimulator
{
    class CommandExecutor
    {
        /// <summary>
        /// Executes a top command
        /// NOTE: end command should be taken care of in the calling function
        /// </summary>
        /// <param name="totalBids"></param>
        /// <param name="numArg"></param>
        /// <param name="bids"></param>
        /// <param name="outputfilename"></param>
        public static void ExecuteTopCommand(int totalBids, int numArg, List<int> bids, string outputfilename )
        {
            //figure out bids
            while (bids.Count < totalBids)
            {
                Thread.Sleep(TimeSpan.FromSeconds(0.5));
            }
            List<int> top_n_bids = new List<int>();
            for (int i = bids.Count-1; i >= bids.Count - numArg; i--)
            {
                top_n_bids.Add(bids[i]);
            }
            string topBids = String.Join(" ", top_n_bids);
            OutputHelper.WriteInBlue(topBids);
            using (StreamWriter writer = new StreamWriter(outputfilename, false))
            {
                writer.WriteLine(topBids);
            }
        }

        /// <summary>
        /// Replaces current history file with all the bids in the current bid streams
        /// </summary>
        /// <param name="state"></param>
        public static void SaveHistory(StreamStates state)
        {
            using (StreamWriter writer = new StreamWriter(state.Filenames.History, false))
            {
                writer.WriteLine(state.ListOfTodaysBids.Count);
                foreach (int bid in state.ListOfTodaysBids)
                {
                    writer.WriteLine(bid);
                }
            }
        }

        /// <summary>
        /// Wipes clean the bid, input, and output streams so that a re-launch of the application will not result in an exception
        /// </summary>
        /// <param name="state"></param>
        public static void ClearBidAndIoStreams(StreamStates state)
        {
            foreach (string filename in state.Filenames.Streams)
            {
                File.WriteAllText(filename, String.Empty);
            }
            File.WriteAllText(state.Filenames.ControlInput, String.Empty);
            File.WriteAllText(state.Filenames.ControlOutput, String.Empty);
        }
    }
}

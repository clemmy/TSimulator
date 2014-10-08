using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSimulator.StreamModels;
using System.Threading;
using System.IO;

namespace TSimulator
{
    class StreamStates
    {
        public HistoryModel HistoryStream { get; set; }
        public ControlInputModel ControlInputStream { get; set; }
        public ControlOutputModel ControlOutputStream { get; set; }
        public BidStreamModel[] BidStreamModels { get; set; }
        public Filenames Filenames { get; set; }

        private void WatchBidStream(string filepath, BidStreamModel bsModel)
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;
                Follow(filepath);
            }).Start();
        }

        /// <summary>
        /// Factory method that creates a streamStates object
        /// </summary>
        /// <param name="filenames"></param>
        /// <returns></returns>
        public static StreamStates GetStreamStates(Filenames filenames)
        {
            var s = new StreamStates()
            {
                BidStreamModels = new BidStreamModel[4],
                Filenames = filenames
            };
           
            return s;
        }

        /// <summary>
        /// Monitor the files for changes, and synchronizes it with the stream models found in this object
        /// </summary>
        public void StartWatching()
        {
            for (int i = 0; i < 4; i++)
            {
                this.WatchBidStream(Filenames.Streams[i], BidStreamModels[i]);
            }
        }

        public void StopWatching()
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Monitors changes being appended to end of file
        /// </summary>
        /// <param name="path"></param>
        private static void Follow(string path)
        {
            using (FileStream fileStream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            {
                using (StreamReader streamReader = new StreamReader(fileStream))
                {
                    for (;;)
                    {
                        Thread.Sleep(TimeSpan.FromSeconds(0.5));
                        string read = streamReader.ReadToEnd();
                        if (!string.IsNullOrEmpty(read))
                        {
                            Console.Out.WriteLine(path + ": " + read);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Blocks class from being constructed
        /// </summary>
        private StreamStates()
        {
            
        }
    }
}

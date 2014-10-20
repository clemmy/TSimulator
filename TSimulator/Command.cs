using TSimulator.StreamModels;

namespace TSimulator
{
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

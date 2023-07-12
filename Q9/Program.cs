using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q9
{
   class Program
    {
        static void Main(string[] args)
        {
            List<BatsmanData> batsmen = new List<BatsmanData>
        {
            new BatsmanData { Batsman = "Virat Kholi", RunsScored = 50, StrikeRate = 78.30 },
            new BatsmanData { Batsman = "M.S.Dhoni", RunsScored = 61, StrikeRate = 58.90 },
            new BatsmanData { Batsman = "Rohit Sharma", RunsScored = 13, StrikeRate = 124.0 }
        };

            string bestBatsman = GetBatsmanWithBestMomentum(batsmen);
            Console.WriteLine("Batsman with the best batting momentum: " + bestBatsman);
        }

        static string GetBatsmanWithBestMomentum(List<BatsmanData> batsmen)
        {
            string bestBatsman = "";
            double highestMomentum = 0;

            foreach (var batsman in batsmen)
            {
                double momentum = batsman.RunsScored * batsman.StrikeRate;

                if (momentum > highestMomentum)
                {
                    highestMomentum = momentum;
                    bestBatsman = batsman.Batsman;
                }
            }

            return bestBatsman;
        }
    }

    class BatsmanData
    {
        public string Batsman { get; set; }
        public int RunsScored { get; set; }
        public double StrikeRate { get; set; }
    }

}

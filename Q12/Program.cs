using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q12
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PlayerLineup> lineups = new List<PlayerLineup>
        {
            new PlayerLineup { PlayerId = 21, PlayerName = "Y. Chahal" },
            new PlayerLineup { PlayerId = 22, PlayerName = "Bhuvneshwar Kumar" },
            new PlayerLineup { PlayerId = 23, PlayerName = "Jasprit Bumrah" },
            new PlayerLineup { PlayerId = 24, PlayerName = "Hardik Pandya" },
            new PlayerLineup { PlayerId = 25, PlayerName = "Ravindra Jadeja" },
            new PlayerLineup { PlayerId = 26, PlayerName = "Mohammed Shami" }
        };

            List<BowlingStats> bowlingStats = new List<BowlingStats>
        {
            new BowlingStats { PlayerId = 21, Wickets = 2 },
            new BowlingStats { PlayerId = 22, Wickets = 1 },
            new BowlingStats { PlayerId = 23, Wickets = 3 },
            new BowlingStats { PlayerId = 26, Wickets = 1 }
        };

            var mergedData = lineups.Join(
                bowlingStats,
                lineup => lineup.PlayerId,
                stats => stats.PlayerId,
                (lineup, stats) => new { lineup.PlayerName, stats.Wickets }
            );

            Console.WriteLine("Player - Wickets");
            foreach (var data in mergedData)
            {
                Console.WriteLine($"{data.PlayerName} - {data.Wickets}");
            }
        }
    }

    class PlayerLineup
    {
        public int PlayerId { get; set; }
        public string PlayerName { get; set; }
    }

    class BowlingStats
    {
        public int PlayerId { get; set; }
        public int Wickets { get; set; }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q10
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>
        {
            new Player { PlayerName = "Virat Kholi", IsRetired = 1 },
            new Player { PlayerName = "M.S. Dhoni", IsRetired = 1 },
            new Player { PlayerName = "Hardik Pandya", IsRetired = 1 },
            new Player { PlayerName = "Rohit Sharma", IsRetired = 1 },
            new Player { PlayerName = "Sachin Tendulkar", IsRetired = 0 },
            new Player { PlayerName = "Rahul Dravid", IsRetired = 0 },
            new Player { PlayerName = "Sourav Ganguly", IsRetired = 0 },
            new Player { PlayerName = "VVS Laxman", IsRetired = 0 }
        };

            List<Player> updatedPlayers = players.Select(p => new Player { PlayerName = p.PlayerName, IsRetired = (p.IsRetired == 0) ? 1 : 0 }).ToList();

            Console.WriteLine("Updated Player List:");
            foreach (var player in updatedPlayers)
            {
                Console.WriteLine("Player Name: " + player.PlayerName + ", IsRetired: " + player.IsRetired);
            }
        }
    }

    class Player
    {
        public string PlayerName { get; set; }
        public int IsRetired { get; set; }
    }

}

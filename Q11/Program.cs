using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Q11
{
    class Program
    {
        static void Main(string[] args)
        {
            Team team = new Team
            {
                Name_Full = "Sunrisers Hyderabad",
                Name_Short = "SRH",
                Players = new Players
            {
                { "5380", new Player { Position = "1", Name_Full = "David Warner", IsCaptain = true } },
                { "3722", new Player { Position = "2", Name_Full = "Shikhar Dhawan", IsCaptain = false } }
            }
            };

            string json = JsonConvert.SerializeObject(team, Formatting.Indented);
            Console.WriteLine(json);
        }
    }

    class Team
    {
        [JsonProperty("Name_Full")]
        public string Name_Full { get; set; }

        [JsonProperty("Name_Short")]
        public string Name_Short { get; set; }

        [JsonProperty("Players")]
        public Players Players { get; set; }
    }

    class Players : Dictionary<string, Player> { }

    class Player
    {
        [JsonProperty("Position")]
        public string Position { get; set; }

        [JsonProperty("Name_Full")]
        public string Name_Full { get; set; }

        [JsonProperty("IsCaptain")]
        public bool IsCaptain { get; set; }
    }

}

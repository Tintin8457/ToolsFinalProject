using System.Collections.Generic;
using Newtonsoft.Json;

namespace FinalProject
{
    public class MasteryDataTypes
    {
        public List<string> Champions { get; set; }

        [JsonProperty(Order = 1)]
        public string Name { get; set; }

        [JsonProperty(Order = 2)]
        public string ChampionID { get; set; }

        [JsonProperty(Order = 3)]
        public int ChampionLevel { get; set; }

        [JsonProperty(Order = 4)]
        public int TotalChampionPoints { get; set; }
        
        [JsonProperty(Order = 5)]
        public int CurrentLevelChampionPoints { get; set; }

        [JsonProperty(Order = 6)]
        public int ChampionPointsNeeded { get; set; }

        [JsonProperty(Order = 7)]
        public int TokensEarned { get; set; }
    }
}

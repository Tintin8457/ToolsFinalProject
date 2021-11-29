using System;
using System.Threading.Tasks;
using MingweiSamuel.Camille;
using MingweiSamuel.Camille.Enums;
using MingweiSamuel.Camille.SummonerV4;

namespace FinalProject
{
    class Demo
    {
        static async Task Demo(string[] args)
        {
            var riotApi = new RiotApi("RGAPI-letters1-letters2-letters3-letters4-letters5");

            var summoner = riotApi.SummonerV4.GetSummonerByName("Kingbran21");
            Console.WriteLine($"Name: {summoner.Name} Level: {summoner.SummonerLevel}");


        }
    }
}

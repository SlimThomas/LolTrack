using LolTrack.Services;
using System.Numerics;

namespace LolTrack.Models
{
	public class Player
	{
		
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int TotalWins { get; set; }
        public double WinPerC { get; set; }
        public double KDA { get; set; }
        public int TotalMatch { get; set; }
        public int TotalLosses { get; set; }
        public double AvgVision { get; set; }
		
        public Match MostPlayedChamp { get; set; }
		
        public Match MostPlayedLane { get; set; }
		public Match match { get; set; }

		public Player(int playerID, string playerName)
		{
			PlayerID = playerID;
			PlayerName = playerName;
			//WinPerC = winPerC;
			//KDA = kDA;
			//TotalMatch = totalMatch;
			//TotalLosses = totalLosses;
			//AvgVision = avgVision;
			//MostPlayedChamp = mostPlayedChamp;
			//MostPlayedLane = mostPlayedLane;
		}

		public Player()
		{
		}

    }
}

namespace LolTrack.Models
{
	public class Player
	{
        public int PlayerID { get; set; }
        public int TotalWins { get; set; }
        public double WinPerC { get; set; }
        public double KDA { get; set; }
        public int TotalMatch { get; set; }
        public int TotalLosses { get; set; }
        public double AvgVision { get; set; }
        public Match MostPlayedChamp { get; set; }
        public Match MostPlayedLane { get; set; }

		public Player(int playerID, int totalWins, double winPerC, double kDA, int totalMatch, 
			int totalLosses, double avgVision, Match mostPlayedChamp, Match mostPlayedLane)
		{
			PlayerID = playerID;
			TotalWins = totalWins;
			WinPerC = winPerC;
			KDA = kDA;
			TotalMatch = totalMatch;
			TotalLosses = totalLosses;
			AvgVision = avgVision;
			MostPlayedChamp = mostPlayedChamp;
			MostPlayedLane = mostPlayedLane;
		}

		public Player()
		{
		}
	}
}

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LolTrack.Models
{
	public class Player
	{
		[Key]
		[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PlayerID { get; set; }
        public string PlayerName { get; set; }
        public int TotalWins { get; set; }
        public double WinPerC { get; set; }
        public double KDA { get; set; }
        public int TotalMatch { get; set; }
        public int TotalLosses { get; set; }
        public double AvgVision { get; set; }
		[NotMapped]
        public Match MostPlayedChamp { get; set; }
		[NotMapped]
        public Match MostPlayedLane { get; set; }
		public Match match { get; set; }

		public ICollection<Match> Matches { get; set; } = new List<Match>();

		public Player(int playerID, int totalWins, string playerName, double winPerC, double kDA, int totalMatch, 
			int totalLosses, double avgVision/*, Match mostPlayedChamp, Match mostPlayedLane*/)
		{
			PlayerID = playerID;
			PlayerName = playerName;
			TotalWins = totalWins;
			WinPerC = winPerC;
			KDA = kDA;
			TotalMatch = totalMatch;
			TotalLosses = totalLosses;
			AvgVision = avgVision;
			//MostPlayedChamp = mostPlayedChamp;
			//MostPlayedLane = mostPlayedLane;
		}

		public Player()
		{
		}
	}
}

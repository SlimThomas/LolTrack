using LolTrack.Services;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Numerics;
using System.Windows.Markup;

namespace LolTrack.Models
{
	public class Player
	{
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int PlayerID { get; set; }
		[Required]
        public string PlayerName { get; set; }
		[Required]
        public int TotalWins { get; set; }
		[Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double WinPerC { get; set; }
		[Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double KDA { get; set; }
		[Required]
        public int TotalMatch { get; set; }
		[Required]
        public int TotalLosses { get; set; }
		[Required]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public double AvgVision { get; set; }

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

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LolTrack.Models
{
    //public enum LaneType
    //{
    //    Top,
    //    Jungle,
    //    Middle,
    //    Bottom,
    //    Support
    //}
    //public enum Items
    //{
    //    HealthPotion,
    //    WardingTotem,
    //    DoransBlade,
    //    DoransRing,
    //    DoransShield,
    //}

    //public enum Champions
    //{
    //    Aatrox,
    //    Annie,
    //    Ksante,
    //    Renekton, 
    //    Braum, 
    //    Caitlyn, 
    //    Diana, 
    //    Garen,
    //    Heimerdinger, 
    //    Illaoi, 
    //    Leona, 
    //    Poppy,
    //    Teemo,
    //    Yorick
    //}

    
    //public enum Runes
    //{
    //    Precision,
    //    Domination,
    //    Sorcery,
    //    Resolve,
    //    Inspiration
    //}

    public class Match
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        [Required]
        public int PlayerMatchID {  get; set; }
        [Required]
        public int UserMatchID { get; set; }
        [Required]
        public bool Win { get; set; }
        [Required]
        public int Kills { get; set; }
        [Required]
        public int Deaths { get; set; }
        [Required]
        public int Assists { get; set; }
        [Required]
        public double KDA { get; set; }
        [Required]
        public int Visionscore { get; set; }
        [Required]
        public int Minions { get; set; }
        [Required]
        public string LaneType { get; set; }
        public string Items { get; set; }
        [Required]
        public string Champions { get; set; }
        
        [Required]
        
        public string SSpells { get; set; }
        


        // Måske vi skal lave MatchDate, så man kan søge på en dag. og se hvor mange matches man har taget den dag

        public Match(int matchID, int playermatchID, int userMatchID, bool win, int kills, int deaths, int assists, double kDA, int visionscore, string laneType, string champions, string sSpells, int minions)
        {
            MatchID = matchID;
            PlayerMatchID = playermatchID;
            UserMatchID = userMatchID;
            Win = win;
            Kills = kills;
            Deaths = deaths;
            Assists = assists;
            KDA = kDA;
            Visionscore = visionscore;
            LaneType = laneType;
            Champions = champions;
            SSpells = sSpells;
            Minions = minions;
            
        }

        public Match()
        {
        }
    }
}

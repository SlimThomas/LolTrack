using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LolTrack.Models
{
    public enum LaneType
    {
        Top,
        Jungle,
        Middle,
        Bottom,
        Support
    }
    public enum Items
    {
        HealthPotion,
        WardingTotem,
        DoransBlade,
        DoransRing,
        DoransShield,
    }

    public enum Champions
    {
        Aatrox,
        Annie,
        Ksante,
        Renekton, 
        Braum, 
        Caitlyn, 
        Diana, 
        Garen,
        Heimerdinger, 
        Illaoi, 
        Leona, 
        Poppy,
        Teemo,
        Yorick
    }

    public enum Runes
    {
        Precision,
        Domination,
        Sorcery,
        Resolve,
        Inspiration
    }

    public class Match
    {
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MatchID { get; set; }
        public int PlayerMatchID {  get; set; }
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
        public LaneType LaneType { get; set; }
        public Items Items { get; set; }
        [Required]
        public Champions Champions { get; set; }
        [Required]
        public Runes Runes { get; set; }
        [Required]
        public SSpells SSpells { get; set; }
        public User User { get; set; }
        public Player Player { get; set; }


        // Måske vi skal lave MatchDate, så man kan søge på en dag. og se hvor mange matches man har taget den dag

        public Match(int matchID, int playermatchID, int userMatchID, bool win, int kills, int deaths, int assists, double kDA, int visionscore, LaneType laneType, Items items, Champions champions, Runes runes, SSpells sSpells, int minions)
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
            Items = items;
            Champions = champions;
            Runes = runes;
            SSpells = sSpells;
            Minions = minions;
            
        }

        
    }
}

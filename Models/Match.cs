namespace LolTrack.Models
{
    public class Match
    {
        public int MatchID { get; set; }
        public bool WinProcent { get; set; }
        public int Kills { get; set; }
        public int Deaths { get; set; }
        public int Assists { get; set; }
        public double KDA { get; set; }
        public int Visionscore { get; set; }
        public Enum LaneType { get; set; }
        public Enum Items {  get; set; }
        public Enum Champions { get; set; }
        public Enum Runes { get; set; }
        public Enum SSpells { get; set; } 
        public int Minions { get; set; }

        public Match(int matchID, bool winProcent, int kills, int deaths, int assists, double kDA, int visionscore, Enum laneType, Enum items, Enum champions, Enum runes, Enum sSpells, int minions)
        {
            MatchID = matchID;
            WinProcent = winProcent;
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

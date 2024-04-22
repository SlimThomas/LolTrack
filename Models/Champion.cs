namespace LolTrack.Models
{
	public class Champion
	{
		public Champion()
		{
		}

		public int ChampionID { get; set; }
        public string ChampName { get; set; }
        public string Ability { get; set; }
        public string ChampDesc { get; set; }
        public Enum Difficulty { get; set; }

		public Champion(int championID, string name, string ability, string desc, Enum difficulty)
		{
			ChampionID = championID;
			Name = name;
			Ability = ability;
			Desc = desc;
			Difficulty = difficulty;
		}
	}
}

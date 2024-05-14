namespace LolTrack.Models
{
	public class Champion
	{
		public Champion()
		{
		}

		public int ChampionID { get; set; }
        public string ChampName { get; set; }
        public string ChampDesc { get; set; }
        public string Difficulty { get; set; }
        public string ChampSplash { get; set; }
        public Ability ability { get; set; }

        public Champion(int championID, string name, string desc, string difficulty, string splash)
		{
			ChampionID = championID;
			ChampName = name;
			ChampDesc = desc;
			Difficulty = difficulty;
			ChampSplash = splash;
		}
	}
}

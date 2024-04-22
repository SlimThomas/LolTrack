namespace LolTrack.Models
{
	public class Rune
	{
        public int RuneID { get; set; }
        public string RunePageName  { get; set; }
        public Enum RuneType { get; set; }
        public string RuneDesc  { get; set; }

		public Rune(int runeID, string runePageName, Enum runeType, string runeDesc)
		{
			RuneID = runeID;
			RunePageName = runePageName;
			RuneType = runeType;
			RuneDesc = runeDesc;
		}

		public Rune()
		{
		}
	}
}

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace LolTrack.Models
{
	public class Rune
	{
        [Required]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RuneID { get; set; }
		[Required]
        public string RunePageName  { get; set; }
		[Required]
        public Enum RuneType { get; set; }
		[Required]
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

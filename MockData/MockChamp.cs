using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockChamp
	{
		private static List<Champion> _champions = new List<Champion>()
		{
			new Champion(1, "Aatrox", "He hits with q and shiz", "Aatrox is a big red demon guy and he angy", "Medium Difficulty"),
			new Champion(2, "Annie", "Her teddybear becomes big and hits you", "Annie is a little girl who is cursed, her best friend is her teddybear", "Easy Difficulty"),
			new Champion(159, "K'sante", "he hits you with q and shiz", "K'sante has big rocks for weapons", "Medium Difficulty")
		};
		public static List<Champion> GetMockChamps()
		{
			return _champions;
		}
	}
}

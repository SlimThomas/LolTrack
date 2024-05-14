using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockChamp
	{
		private static List<Champion> _champions = new List<Champion>()
		{
			new Champion(1, "Aatrox", "Aatrox is a big red demon guy and he angy", "Medium Difficulty", "Aatrox.jpg"),
			new Champion(2, "Annie",  "Annie is a little girl who is cursed, her best friend is her teddybear", "Easy Difficulty", "Annie.jpg"),
			new Champion(3, "K'sante", "K'sante has big rocks for weapons", "Medium Difficulty", "Ksante.jpg"),
			new Champion(4, "Renekton", "He is a big egyptian croc", "Easy Difficulty", "Renekton.jpg"),
			new Champion(5, "Braum", "He is a big egyptian croc", "Easy Difficulty", "Braum.jpg"),
			new Champion(6, "Illaoi", "He is a big egyptian croc", "Easy Difficulty", "Illaoi.jpg"),
			new Champion(7, "Teemo", "He is a big egyptian croc", "Easy Difficulty", "Teemo.jpg"),
			new Champion(8, "Diana", "He is a big egyptian croc", "Easy Difficulty", "Diana.jpg"),
			new Champion(9, "Leona", "He is a big egyptian croc", "Easy Difficulty", "Leona.jpg"),
			new Champion(10, "Garen", "He is a big egyptian croc", "Easy Difficulty", "Garen.jpg"),
			new Champion(11, "Poppy", "He is a big egyptian croc", "Easy Difficulty", "Poppy.jpg"),
			new Champion(12, "Heimerdinger", "He is a big egyptian croc", "Easy Difficulty", "Heimerdinger.jpg"),
			new Champion(13, "Yorick", "He is a big egyptian croc", "Easy Difficulty", "Yorick.jpg"),
			new Champion(14, "Yuumi", "He is a big egyptian croc", "Easy Difficulty", "Yuumi.jpg"),
			new Champion(15, "Zeri", "He is a big egyptian croc", "Easy Difficulty", "Zeri.jpg"),
			new Champion(16, "Caitlyn", "He is a big egyptian croc", "Easy Difficulty", "Caitlyn.jpg")
		};

		public static List<Champion> GetMockChamps()
		{
			return _champions;
		}
	}
}

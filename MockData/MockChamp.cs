using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockChamp
	{
		private static List<Champion> _champions = new List<Champion>();
		public static List<Champion> GetMockChamps()
		{
			return _champions;
		}
	}
}

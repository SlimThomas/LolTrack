using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockPlayer
	{
		private static List<Player> _players = new List<Player>();
		public static List<Player> GetMockPlayer()
		{
			return _players;
		}
	}
}

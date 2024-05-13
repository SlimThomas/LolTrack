using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockPlayer
	{
		private static List<Player> _players = new List<Player>()
		{
			new Player(1, 53, "Murt", 53, 3.5, 100, 47, 21.4),
			new Player(2, 57, "SlimThomas", 57, 5.1, 100, 43, 0)
		};
		public static List<Player> GetMockPlayer()
		{
			return _players;
		}
	}
}

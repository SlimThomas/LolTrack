using LolTrack.Models;

namespace LolTrack.MockData
{
	public class MockPlayer
	{
		private static List<Player> _players = new List<Player>()
		{
			new Player(1, "Murt"),
			new Player(2, "SlimThomas"),
			new Player(3, "Mikkel"),
			new Player(4, "Henrik"),
			new Player(5, "Censor")
		};
		public static List<Player> GetMockPlayer()
		{
			return _players;
		}
	}
}

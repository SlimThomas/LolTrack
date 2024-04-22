using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
	public class PlayerService
	{
		private List<Player> _players;
		
		public PlayerService()
		{
			_players = MockPlayer.GetMockPlayer();
		}

		public void AddPlayer()
		{
			_players.Add(player);
		}
	}
}

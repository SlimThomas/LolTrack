using LolTrack.MockData;
using LolTrack.Models;
using System.Security.Cryptography.X509Certificates;

namespace LolTrack.Services
{
	public class PlayerService
	{
		private List<Player> _players;
		
		public PlayerService()
		{
			_players = MockPlayer.GetMockPlayer();
		}

		public void AddPlayer(Player player)
		{
			_players.Add(player);
		}
		public Player GetPlayer(int id)
		{
			foreach (Player player in _players)
			{
				if (player.PlayerID == id) return player;
			}
			return null;
		}
		public Player GetPlayerName(string id)
		{
			foreach (Player player in _players)
			{
				if(player.PlayerName == id) return player;
			}
			return null;
		}

		public void UpdatePlayer(Player player)
		{
			if (player != null)
			{
				foreach (Player p in _players)
				{
					if (p.PlayerID == player.PlayerID)
					{
						p.PlayerName = player.PlayerName;
					}
				}
			}
		}
		public Player DeletePlayer(int? playerId)
		{
			Player playerToBeDeleted = null;
			foreach (Player player in _players)
			{
				if (player.PlayerID == playerId)
				{
					playerToBeDeleted = player;
					break;
				}
			}
			if (playerToBeDeleted != null)
			{
				_players.Remove(playerToBeDeleted);
			}
			return playerToBeDeleted;
		}

		public List<Player> GetPlayers() 
		{
			return _players; 
		}

		public IEnumerable<Player> PlayerSearch(string str)
		{
			var NameSearchQuery = from p in _players
								  where p.PlayerName.Contains(str)
								  select p;
			return NameSearchQuery;
		}
	}
}

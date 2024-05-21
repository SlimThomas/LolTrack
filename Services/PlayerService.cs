using LolTrack.MockData;
using LolTrack.Models;
using Microsoft.AspNetCore.Mvc.Formatters.Xml;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace LolTrack.Services
{
	public class PlayerService
	{
		private List<Player> _players;
		private List<Match> _matches;
		
		public PlayerService()
		{
			_matches = MockMatch.GetMockMatches();
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
		public int TotalW()
		{
			foreach (Player p in _players)
			{
				foreach (Match m in _matches)
				{
					if (m.PlayerMatchID == p.PlayerID)
					{
						var TotW = from ma in _matches
								   where ma.Win == true & ma.PlayerMatchID == p.PlayerID
								   select ma;
						int TotalWins = TotW.Count();
						p.TotalWins = TotalWins;
					}
					return p.TotalWins;
				}
			}
			return 0;
		}
		public int TotalL()
		{
			foreach (Player p in _players)
			{

				foreach (Match m in _matches)
				{
					if (m.PlayerMatchID == p.PlayerID)
					{
						var TotL = from ma in _matches
								   where ma.Win != true & ma.PlayerMatchID == p.PlayerID
                                   select ma;
						p.TotalLosses = TotL.Count();
					}
					return p.TotalLosses;
				}
			}
			return 0;
		}
        public double WinP()
        {
			foreach (Player p in _players)
			{
				foreach (Match m in _matches)
				{
					if (m.PlayerMatchID == p.PlayerID)
					{
						double WP = Convert.ToDouble(TotalW()) / p.TotalMatch;
						p.WinPerC = WP;
					}
					return p.WinPerC;
				}
			}
			return 0;
        }
        public double GetKDA()
        {
			foreach (Player p in _players)
			{
				foreach (Match m in _matches)
				{
					if (m.PlayerMatchID == p.PlayerID)
					{
						var kQ = from ma in _matches
								 where ma.PlayerMatchID == p.PlayerID
                                 select ma.Kills;
						var dQ = from ma in _matches
								 where ma.PlayerMatchID == p.PlayerID
                                 select ma.Deaths;
						var aQ = from ma in _matches
								 where ma.PlayerMatchID == p.PlayerID
                                 select ma.Assists;
						double kda = Convert.ToDouble((kQ.Sum() + aQ.Sum())) / Convert.ToDouble(dQ.Sum());
						p.KDA = kda;
					}
					return p.KDA;
				}
			} return 0;
        }
        public double AVGVi()
        {
			foreach (Player p in _players)
			{
				foreach (Match m in _matches)
				{
					if (m.PlayerMatchID == p.PlayerID)
					{
						var VS = from ma in _matches
								 where ma.PlayerMatchID == p.PlayerID
                                 select ma.Visionscore;
						double aVS = Convert.ToDouble(VS.Sum()) / Convert.ToDouble(_matches.Count());
						p.AvgVision = aVS;
					}
					return p.AvgVision;
				}
			}
			return 0;
        }
    }
}

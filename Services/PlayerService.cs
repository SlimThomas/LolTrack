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
		private DbService _dbService; 

		public PlayerService(DbService dbService)
		{
			_matches = MockMatch.GetMockMatches();
			_players = MockPlayer.GetMockPlayer();
			_dbService = dbService;
			//_dbService.SavePlayers(_players);
			//_players = _dbService.GetPlayers().Result;
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
				if (player.PlayerName == id) return player;
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
			//if(str == null)
			//{
			//}
			List<Player> list = new List<Player>();
			if (str != null)
			{
				var NameSearchQuery = from p in _players
									  where p.PlayerName.Contains(str)
									  select p;
				return NameSearchQuery;
			}
			return list;
		}
		public IEnumerable<Player> PlayerNameSearch(string str)
		{
            var NameSearchQuery = from p in _players
                                  where p.PlayerName.Contains(str)
                                  select p;
            return NameSearchQuery;
        }

		public int MCount(Player player)
		{
			int TotalM = 0;
			foreach (Match m in _matches)
			{
				if (m.PlayerMatchID == player.PlayerID)
				{
					TotalM++;
				}
			}
			return TotalM;
		}
		public int TotalW(Player player)
		{
			int TotalW = 0;
			foreach (Match m in _matches)
			{
				if (m.PlayerMatchID == player.PlayerID)
				{
					if(m.Win == true)
					{
						TotalW++;
					}
				}
			}
			return TotalW;
		}
		public int TotalL(Player p)
		{
			int totalL = 0;
			foreach (Match m in _matches)
			{
				if (m.PlayerMatchID == p.PlayerID)
				{
					if(m.Win != true)
					{
						totalL++;
					}
				}

			}
			return totalL;
		}
		public double WinP(Player p)
		{
			foreach (Match m in _matches)
			{
				if (m.PlayerMatchID == p.PlayerID)
				{
					double WP = Convert.ToDouble(TotalW(p)) / p.TotalMatch;
					p.WinPerC = WP;
				}
			}
			return p.WinPerC;
		}
		public double GetKDA(Player p)
		{
            double kda = 0;
					var kQ = from ma in _matches
							 where ma.PlayerMatchID == p.PlayerID
							 select ma.Kills;
					var dQ = from ma in _matches
							 where ma.PlayerMatchID == p.PlayerID
                             select ma.Deaths;
					var aQ = from ma in _matches
							 where ma.PlayerMatchID == p.PlayerID
                             select ma.Assists;
					kda = Convert.ToDouble((kQ.Sum() + aQ.Sum())) / Convert.ToDouble(dQ.Sum());
			return kda;
		}
        public double AVGVi(Player p)
        {
			double aVS = 0;
                        var VS = from ma in _matches
								 where ma.PlayerMatchID == p.PlayerID
                                 select ma.Visionscore;
                        aVS = Convert.ToDouble(VS.Sum()) / Convert.ToDouble(_matches.Count());
            return aVS;
        }
    }
}

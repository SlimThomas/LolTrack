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
        private JsonFileService<Player> _fileService;
        private JsonFileService<Match> _mfileService;
        private DbService _dbService; 

        public PlayerService(DbService dbService, JsonFileService<Player> fileService, JsonFileService<Match> mfileService)
        {
            //_matches = MockMatch.GetMockMatches();
            //_players = MockPlayer.GetMockPlayer();
            _fileService = fileService;
            _mfileService = mfileService;
            _dbService = dbService;
            //_players = _fileService.GetJsonObjects().ToList();
            _matches = _mfileService.GetJsonObjects().ToList();
            //_fileService.SaveJsonObjects(_players);
            //_mfileService.SaveJsonObjects(_matches);
            _players = _dbService.GetPlayers().Result;
            _dbService.SavePlayers(_players);
            //_dbService.SaveMatches(_matches);
        }

        public void AddPlayer(Player player)
		{
			_players.Add(player);
            _fileService.SaveJsonObjects(_players);
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
                _fileService.SaveJsonObjects(_players);
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
                _fileService.SaveJsonObjects(_players);
            }
			return playerToBeDeleted;
		}

		public List<Player> GetPlayers()
		{
			return _players;
		}
        //public List<Match> GetMatches()
        //{
        //    return _matches;
        //}

        //public void AddMatch(Match match)
        //{
        //    _matches.Add(match);
        //    _mfileService.SaveJsonObjects(_matches);
        //}

        //// vi ville have en update metode, til hvis vi kom til at create forkert - men i det endelige produkt, ville en update funktion ikke være nødvendig

        //public Match GetMatch(int id)
        //{
        //    foreach (Match match in _matches)
        //    {
        //        if (match.MatchID == id) return match;
        //    }
        //    return null;
        //}

        //public Match DeleteMatch(int? id)
        //{
        //    Match matchTobeDeleted = null;
        //    foreach (Match match in _matches)
        //    {
        //        if (match.MatchID == id)
        //        {
        //            matchTobeDeleted = match;
        //            break;
        //        }
        //    }
        //    if (matchTobeDeleted != null)
        //    {
        //        _matches.Remove(matchTobeDeleted);
        //        _mfileService.SaveJsonObjects(_matches);
        //    }
        //    return matchTobeDeleted;
        //}

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

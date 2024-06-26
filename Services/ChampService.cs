﻿using LolTrack.MockData;
using LolTrack.Models;
using System.Diagnostics.Eventing.Reader;

namespace LolTrack.Services
{
	public class ChampService
	{
		private List<Champion> _champions;
        private JsonFileService<Champion> _fileService;
        private DbService _dbService;

		public ChampService(DbService dbService, JsonFileService<Champion> fileService)
		{
			//_champions = MockChamp.GetMockChamps();
			_fileService = fileService;
            _champions = _fileService.GetJsonObjects().ToList();
            _dbService = dbService;
            //_fileService.SaveJsonObjects(_champions);
            //_champions = _dbService.GetChampions().Result;
            _dbService.SaveChampions(_champions);
        }
		public void AddChamp(Champion champ)
		{
			_champions.Add(champ);
            _fileService.SaveJsonObjects(_champions);
            //_dbService.AddChampion(champ);
        }
		public Champion GetChampion(int id)
		{
			foreach (Champion champ in _champions)
			{
				if (champ.ChampionID == id) return champ;
			}
			return null;
		}
		public void UpdateChamp(Champion champ)
		{
			if (champ != null)
			{
				foreach (Champion c in _champions)
				{
					if (c.ChampionID == champ.ChampionID)
					{
						c.ChampDesc = champ.ChampDesc;
						c.ChampName = champ.ChampName;
					}
				}
                _fileService.SaveJsonObjects(_champions);
                _dbService.SaveChampions(_champions);
            }
		}
		public Champion DeleteChamp(int? champid)
		{
			Champion champToBeDeleted = null;
			foreach (Champion champ in _champions)
			{
				if (champ.ChampionID == champid)
				{
					champToBeDeleted = champ;
					break;
				}
			}
			if (champToBeDeleted != null)
			{
				_champions.Remove(champToBeDeleted);
                _fileService.SaveJsonObjects(_champions);
                //_dbService.SaveChampions(_champions);
            }
            return champToBeDeleted;
		}
		public List<Champion> GetChampions()
		{
			return _champions;
		}

		public IEnumerable<Champion> ChampSearch(string str)
		{
			var ChampSearchQ = from c in _champions
							   where c.ChampName.Contains(str)
							   select c;
			return ChampSearchQ;
		}
		public IEnumerable<Champion> SortByName()
		{
			var NameQ = from c in _champions
						orderby c.ChampName ascending
						select c;
			return NameQ;
		}

		public IEnumerable<Champion> SortByNameDesc()
		{
			var NameQ = from c in _champions
						orderby c.ChampName descending
						select c;
			return NameQ;
		}
	}
}

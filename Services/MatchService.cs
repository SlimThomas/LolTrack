
using LolTrack.MockData;
using LolTrack.Models;
using Microsoft.EntityFrameworkCore;

namespace LolTrack.Services
{
    public class MatchService
    {
        private JsonFileService<Match> _fileService;
        private List<Match> _matches; 
        private DbService _dbService;
        

        public MatchService(DbService dbService, JsonFileService<Match> fileService)
        {
            //_matches = MockMatch.GetMockMatches();
            _fileService = fileService;
            _matches = _fileService.GetJsonObjects().ToList();
            _dbService = dbService;
            //_matches = _dbService.GetMatches().Result;
            _dbService.SaveMatches(_matches);
            //_fileService.SaveJsonObjects(_matches);
            
        }

      

        public List<Match> GetMatches()
        {
            return _matches;
        }

        public void AddMatch(Match match)
        {
            _matches.Add(match);
            _fileService.SaveJsonObjects(_matches);
        }

        // vi ville have en update metode, til hvis vi kom til at create forkert - men i det endelige produkt, ville en update funktion ikke være nødvendig

        public Match GetMatch(int id)
        {
            foreach (Match match in _matches)
            {
                if (match.MatchID == id) return match;
            }
            return null; 
        }

        public Match DeleteMatch(int? id)
        {
            Match matchTobeDeleted = null; 
            foreach (Match match in _matches)
            {
                if (match.MatchID == id) 
                { 
                    matchTobeDeleted = match;
                    break; 
                }
            }
            if (matchTobeDeleted != null)
            {
                _matches.Remove(matchTobeDeleted);
                _fileService.SaveJsonObjects(_matches);
            }
            return matchTobeDeleted; 
        }


    }
}

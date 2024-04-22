﻿using LolTrack.MockData;
using LolTrack.Models;

namespace LolTrack.Services
{
    public class MatchService
    {
        private List<Match> _matches; 

        public MatchService()
        {
            _matches = MockMatch.GetMockMatches();
        }

        public List<Match> GetMatches()
        {
            return _matches;
        }

        public void AddMatch(Match match)
        {
            _matches.Add(match);
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
            }
            return matchTobeDeleted; 
        }


    }
}
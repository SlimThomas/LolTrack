using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDMatch
{
    public class GetAllMatchesModel : PageModel
    {
        private MatchService _matchService; 
        public List<Match> _matches {  get; set; }

        public GetAllMatchesModel(MatchService matchService)
        {
            this._matchService = matchService; 
        }
        
        
        
        public void OnGet()
        {
            _matches = _matchService.GetMatches(); 
        }
    }
}

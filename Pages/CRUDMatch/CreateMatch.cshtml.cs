using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDMatch
{
    public class CreateMatchModel : PageModel
    {

        private MatchService _matchService; 
        public void OnGet()
        {
        }
    }
}

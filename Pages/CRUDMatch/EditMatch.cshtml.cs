using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDMatch
{
    public class EditMatchModel : PageModel
    {

        private MatchService _matchService;

        [BindProperty]
        public Match Match { get; set; }

        public EditMatchModel(MatchService matchsService) 
        {
            _matchService = matchsService;
        }
        public IActionResult OnGet(int id)
        {
            Match = _matchService.GetMatch(id); 
            if (Match == null)
            {
                return RedirectToPage("/NotFound"); 
            }
            return Page(); 
        }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page(); // Denne OnPost skal opdateres, hvis vi vælger at kunne update en match
            }
            return RedirectToPage("GetAllMatches"); 
        }
    }
}

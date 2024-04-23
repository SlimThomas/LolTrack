using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDMatch
{
    public class CreateMatchModel : PageModel
    {

        private MatchService _matchService;

        [BindProperty]
        public Models.Match Match { get; set; } 

        public CreateMatchModel(MatchService matchService)
        {
            _matchService = matchService;
        }

        public IActionResult OnGet()
        {
            return Page(); 
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _matchService.AddMatch(Match);
            return RedirectToPage("GetAllMatches"); 
        }
        
    }
}

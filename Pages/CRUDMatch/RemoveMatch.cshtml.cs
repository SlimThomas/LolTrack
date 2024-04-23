using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.VisualBasic.FileIO;
using System.Text.RegularExpressions;

namespace LolTrack.Pages.CRUDMatch
{
    public class RemoveMatchModel : PageModel
    {

        private MatchService _matchService;

        [BindProperty]
        public Models.Match match { get; set; }

        public RemoveMatchModel(MatchService matchService)
        {
            _matchService = matchService;
        }

        public IActionResult OnGet(int id)
        {
            match = _matchService.GetMatch(id);
            if (match == null)
            {
                return RedirectToPage("/NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            Models.Match deletedMatch = _matchService.DeleteMatch(match.MatchID);
            if (deletedMatch == null)
            {
                return RedirectToPage("/NotFound"); 
            }
            return RedirectToPage("GetAllMatches"); 
        }
    }
}

using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDChamp
{
    public class RemoveChampModel : PageModel
    {
        private ChampService _champService;

        public RemoveChampModel(ChampService champService)
        {
            _champService = champService;
        }
        [BindProperty]
        public Champion champion { get; set; }

        public IActionResult OnGet(int id)
        {
            champion = _champService.GetChampion(id);
            if (champion == null)
                return RedirectToPage("NotFound");//ikke implementeret
            return Page();
        }

        public IActionResult OnPost()
        {
            Champion deletedChamp = _champService.DeleteChamp(champion.ChampionID);
            if (deletedChamp == null)
                return RedirectToPage("NotFound");//ikke implementeret
            return RedirectToPage("GetAllChamps");
        }
    }
}

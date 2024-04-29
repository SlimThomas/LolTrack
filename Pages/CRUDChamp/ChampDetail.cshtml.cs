using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDChamp
{
    public class ChampDetailModel : PageModel
    {
        private ChampService _champService;

        public ChampDetailModel(ChampService champService)
        {
            _champService = champService;
        }
        public Champion champion { get; set; }

        public IActionResult OnGet(int id)
        {
            champion = _champService.GetChampion(id);
            if (champion == null)
            {
                return RedirectToPage("/NotFound");//NotFound er ikke defineret endnu
            }
            return Page();
        }
    }
}

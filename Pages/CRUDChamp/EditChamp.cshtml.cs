using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDChamp
{
    public class EditChampModel : PageModel
    {
        private ChampService _champService;

        public EditChampModel(ChampService champService)
        {
            _champService = champService;
        }
        [BindProperty]
        public Champion champion { get; set; }

        public IActionResult OnGet(int id)
        {
            champion = _champService.GetChampion(id);
            if (champion == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _champService.UpdateChamp(champion);
            return RedirectToPage("GetAllChamps");
        }
    }
}

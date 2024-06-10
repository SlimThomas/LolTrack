using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace LolTrack.Pages.CRUDChamp
{
    public class CreateChampModel : PageModel
    {
        private ChampService _champservice;
        private IWebHostEnvironment webHostEnvironment;

        public CreateChampModel(ChampService champservice)
        {
            _champservice = champservice;
        }
        [BindProperty]
        public Champion champion { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _champservice.AddChamp(champion);
            return RedirectToPage("GetAllChamps");
        }
    }
}

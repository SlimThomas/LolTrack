using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDChamp
{
    public class ChampDetailModel : PageModel
    {
        private ChampService _champService;
        private AbilityService _abilityService;

        public ChampDetailModel(ChampService champService, AbilityService abilityService)
        {
            _champService = champService;
            _abilityService = abilityService;
        }
        public List<Ability> Abilities { get; private set; }
        public Champion champion { get; set; }
        public Ability Ability { get; set; }

        public IActionResult OnGet(int id)
        {
            Abilities = _abilityService.GetAbilities();
            champion = _champService.GetChampion(id);
            if (champion == null)
            {
                return RedirectToPage("/NotFound");//NotFound er ikke defineret endnu
            }
            return Page();
        }
    }
}

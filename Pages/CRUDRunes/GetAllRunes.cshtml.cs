using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDRunes
{
    public class GetAllRunesModel : PageModel
    {
        private RuneService _runeService;

        public GetAllRunesModel(RuneService runeService)
        {
            _runeService = runeService;
        }
        public List<Rune> Runes { get; private set; }
        public void OnGet()
        {
            Runes = _runeService.GetRunes();
        }
    }
}

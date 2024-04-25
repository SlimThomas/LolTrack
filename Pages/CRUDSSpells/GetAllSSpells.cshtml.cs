using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDSSpells
{
    public class GetAllSSpellsModel : PageModel
    {
        private SSpellService _sspellservice;
        public List<SSpell> sspells { get; set; }
        public GetAllSSpellsModel(SSpellService sSpellService)
        {
            this._sspellservice = sSpellService;
        }
        public void OnGet()
        {
            sspells = _sspellservice.GetSspells();
        }

    }
}

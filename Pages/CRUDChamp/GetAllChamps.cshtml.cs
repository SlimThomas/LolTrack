using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDChamp
{
    public class GetAllChampsModel : PageModel
    {
        private ChampService _champservice;

		public GetAllChampsModel(ChampService champservice)
		{
			_champservice = champservice;
		}

        public List<Champion> Champions { get; private set; }
        [BindProperty]
        public string Search { get; set; }

        public void OnGet()
        {
            Champions = _champservice.GetChampions();
        }

        public IActionResult OnGetSortByName()
        {
            Champions = _champservice.SortByName().ToList();
            return Page();
        }
        public IActionResult OnGetSortByNameDesc()
        {
            Champions = _champservice.SortByNameDesc().ToList();
            return Page();
        }
        public IActionResult OnPostChampSearch()
        {
            Champions = _champservice.ChampSearch(Search).ToList();
            return Page();
        }
    }
}

using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class PlayerCompareModel : PageModel
    {
        private PlayerService _playerService;
        public PlayerCompareModel(PlayerService playerService)
        {
            _playerService = playerService;
        }
        public Player player { get; set; }
        public List<Player> players { get; set; }
        [BindProperty]
        public string Search { get; set; }
        public IActionResult OnGet(int id)
        {
            player = _playerService.GetPlayer(id);
            if (player == null)
            {
                return RedirectToPage("/NotFound");//NotFound er ikke defineret endnu
            }
            return Page();
        }

        public IActionResult OnPostPlayerSearch()
        {
            players = _playerService.PlayerSearch(Search).ToList();
            return Page();
        }
    }
}

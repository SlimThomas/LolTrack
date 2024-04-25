using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class CreatePlayerModel : PageModel
    {
        private PlayerService _playerService;

        public CreatePlayerModel(PlayerService playerService)
        {
            _playerService = playerService;
        }
        [BindProperty]
        public Player player { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _playerService.AddPlayer(player);
            return RedirectToPage("GetAllPlayers");
        }
    }
}

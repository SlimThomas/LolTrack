using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class EditPlayerModel : PageModel
    {
        private PlayerService _playerService;

        public EditPlayerModel(PlayerService playerService)
        {
            _playerService = playerService;
        }

        [BindProperty]
        public Player player { get; set; }
        public IActionResult OnGet(int id)
        {
            player = _playerService.GetPlayer(id);
            if (player == null)
                return RedirectToPage("/NotFound"); //NotFound er ikke defineret endnu

            return Page();
        }
        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _playerService.UpdatePlayer(player);
            return RedirectToPage("GetAllPlayers");
        }
    }
}

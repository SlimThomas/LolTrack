using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class RemovePlayerModel : PageModel
    {
        private PlayerService _playerService;
        [BindProperty]
        public Player player { get; set; }
        public RemovePlayerModel(PlayerService playerService)
        {
            _playerService = playerService;
        }
        public IActionResult OnGet(int id)
        {
            player = _playerService.GetPlayer(id);
            if (player == null)
            {
                return RedirectToPage("/NotFound"); 
            }
            return Page(); 
        }
        public IActionResult OnPost() 
        {
            Player deletedPlayer = _playerService.DeletePlayer(player.PlayerID);
            if (deletedPlayer == null)
            {
                return RedirectToPage("/NotFound"); 
            }
            return RedirectToPage("GetAllPlayers"); 
        }
    }
}

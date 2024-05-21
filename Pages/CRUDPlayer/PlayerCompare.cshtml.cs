using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class PlayerCompareModel : PageModel
    {
        private PlayerService _playerService;
        private UserService _userService;
        public PlayerCompareModel(PlayerService playerService, UserService userService)
        {
            _playerService = playerService;
            _userService = userService; 
        }
        public User user { get; set; }
        public Player player { get; set; }
        public List<Player> players { get; set; }
        [BindProperty]
        public string Search { get; set; }
        public IActionResult OnGet(int id)
        {
            var u = _userService.GetUserByUsername(User.Identity.Name);
            player = _playerService.GetPlayer(id);

            player.TotalMatch = _playerService.MCount(player);
            player.TotalWins = _playerService.TotalW(player);
            player.TotalLosses = _playerService.TotalL(player);
            player.WinPerC = _playerService.WinP(player);
            player.KDA = _playerService.GetKDA(player);
            player.AvgVision = _playerService.AVGVi(player);


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

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
        public Player userplayer { get; set; }
        public List<Player> players { get; set; }
        [BindProperty]
        public string Search { get; set; }
        public IActionResult OnGet(int id)
        {
            user = _userService.GetUserByUsername(User.Identity.Name);
            if (user == null)
            {
                return RedirectToPage("/LogIn/LogInPage");
            }

            player = _playerService.GetPlayer(id);
            int uid = user.UserPlayerID;
            userplayer = _playerService.GetPlayer(uid);

            player.TotalMatch = _playerService.MCount(player);
            player.TotalWins = _playerService.TotalW(player);
            player.TotalLosses = _playerService.TotalL(player);
            player.WinPerC = _playerService.WinP(player);
            player.KDA = _playerService.GetKDA(player);
            player.AvgVision = _playerService.AVGVi(player);

            userplayer.TotalMatch = _playerService.MCount(userplayer);
            userplayer.TotalWins = _playerService.TotalW(userplayer);
            userplayer.TotalLosses = _playerService.TotalL(userplayer);
            userplayer.WinPerC = _playerService.WinP(userplayer);
            userplayer.KDA = _playerService.GetKDA(userplayer);
            userplayer.AvgVision = _playerService.AVGVi(userplayer);

            

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

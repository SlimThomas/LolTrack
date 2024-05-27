using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Numerics;

namespace LolTrack.Pages.MyProfile
{
    [Authorize]
    public class MyProfileModel : PageModel
    {
        private readonly UserService _userService;
        private MatchService _matchService;
        private PlayerService _playerService;
        public User user { get; set; }
        public Player player { get; set; }
        public Match userMatchID { get; set; }
        public List<Player> players { get; set; }
        public List<Match> matches { get; set; }

        public MyProfileModel(UserService userService, MatchService matchService, PlayerService playerService)
        {
            _userService = userService;
            _matchService = matchService;
            _playerService = playerService;
        }



        //public async Task<IActionResult> OnGetAsync()
        //{
        //    user = _userService.GetUserByUsername(User.Identity.Name);
        //    if (user == null)
        //    {
        //        return NotFound("User Not Found.");
        //    }
        //    player = _playerService.GetPlayer(user.UserPlayerID);
        //    matches = _matchService.GetMatches();
        //    player.TotalMatch = _playerService.MCount(user);
        //    player.TotalWins = _playerService.TotalW(user);
        //    player.TotalLosses = _playerService.TotalL(user);
        //    player.WinPerC = _playerService.WinP(user);
        //    player.KDA = _playerService.GetKDA(user);
        //    player.AvgVision = _playerService.AVGVi(user);


        //    return Page();
        //}
        public IActionResult OnGet()
        {
            user = _userService.GetUserByUsername(User.Identity.Name);
            if (user == null)
            {
                return NotFound("User Not Found.");
            }
            int id = user.UserPlayerID;
            player = _playerService.GetPlayer(id);
            matches = _matchService.GetMatches();
<<<<<<< Updated upstream
=======
<<<<<<< HEAD
           
            TotalMatch = _playerService.MCount(user);
            TotalWins = _playerService.TotalW(user);
            TotalLosses = _playerService.TotalL(user);
            WinPerC = _playerService.WinP(user);
            KDA = _playerService.GetKDA(user);
            AvgVision = _playerService.AVGVi(user);
=======
>>>>>>> Stashed changes
            player.TotalMatch = _playerService.MCount(player);
            player.TotalWins = _playerService.TotalW(player);
            player.TotalLosses = _playerService.TotalL(player);
            player.WinPerC = _playerService.WinP(player);
            player.KDA = _playerService.GetKDA(player);
            player.AvgVision = _playerService.AVGVi(player);
<<<<<<< Updated upstream
=======
>>>>>>> 43bdd880540aa350a3062a951e14d4b7b86168d9
>>>>>>> Stashed changes


            return Page();
        }

    }
}

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

        public string UserName { get; set; }
        public int UserID { get; set; }
        public User user { get; set; }
        public string ProfilePic { get; set; }
        public Player Player { get; set; }
        public int TotalMatch { get; set; }
        public int TotalWins { get; set; }
        public int TotalLosses { get; set; }
        public double WinPerC { get; set; }
        public double KDA { get; set; }
        public double AvgVision { get; set; }
        public Match userMatchID { get; set; }



        public List<Match> matches { get; set; }

        public MyProfileModel(UserService userService, MatchService matchService, PlayerService playerService)
        {
            _userService = userService;
            _matchService = matchService;
            _playerService = playerService;
        }



        public async Task<IActionResult> OnGetAsync()
        {
            user = _userService.GetUserByUsername(User.Identity.Name);
            if (user == null)
            {
                return NotFound("User Not Found.");
            }
            UserName = user.UserName;
            UserID = user.UserPlayerID;
            ProfilePic = user.ProfileSplash;
            matches = _matchService.GetMatches();
            TotalMatch = _playerService.MCount(user);
            TotalWins = _playerService.TotalW(user);
            TotalLosses = _playerService.TotalL(user);
            WinPerC = _playerService.WinP(user);
            KDA = _playerService.GetKDA(user);
            AvgVision = _playerService.AVGVi(user);


            return Page();
        }


    }
}

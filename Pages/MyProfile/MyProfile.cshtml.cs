using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.MyProfile
{
    [Authorize]
    public class MyProfileModel : PageModel
    {
        private readonly UserService _userService;
        private MatchService _matchService;

        public string UserName { get; set; }
        public int UserID { get; set; }
        public User user { get; set; }
        public string ProfilePic { get; set; }
        
        public List<Match> matches { get; set; }

        public MyProfileModel(UserService userService, MatchService matchService)
        {
            _userService = userService;
            _matchService = matchService;
        }



        public async Task<IActionResult> OnGetAsync()
        {
            var user = _userService.GetUserByUsername(User.Identity.Name);
            if (user == null)
            {
                return NotFound("User Not Found.");
            }
            UserName = user.UserName;
            UserID = user.UserPlayerID;
            ProfilePic = user.ProfileSplash;
            matches = _matchService.GetMatches();


            return Page();
        }


    }
}

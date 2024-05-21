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

        public string UserName { get; set; }
        public int UserID { get; set; }

        public MyProfileModel(UserService userService)
        {
            _userService = userService;
        }

        public async Task<IActionResult> OnGetAsync()
        {
            var user = _userService.GetUserByUsername(User.Identity.Name); 
            if (user == null)
            {
                return NotFound("User Not Found."); 
            }
            UserName = user.UserName;
            UserID = user.UserID;

            return Page(); 
        }
        
    }
}

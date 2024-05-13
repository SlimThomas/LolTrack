using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.LogIn
{
    public class LogOutPageModel : PageModel
    {
        public async Task<IActionResult> OnGet()
        {
            if (HttpContext.User.Identity.IsAuthenticated)
            {
                await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
                return RedirectToPage("/index");
            }
            return RedirectToPage("/LogIn/LogInPage"); // Redirect to login page if not logged in
        }

    }
}

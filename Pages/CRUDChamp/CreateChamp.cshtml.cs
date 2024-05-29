using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Reflection.Metadata.Ecma335;

namespace LolTrack.Pages.CRUDChamp
{
    public class CreateChampModel : PageModel
    {
        private ChampService _champservice;
        private IWebHostEnvironment webHostEnvironment;

        public CreateChampModel(ChampService champservice)
        {
            _champservice = champservice;
        }
        [BindProperty]
        public Models.Champion champion { get; set; }
        //[BindProperty]
        //public IFormFile? Splash { get; set; }
        //private string ProcessUploadedFile()
        //{
        //    string uniqueFileName = null;
        //    if (Splash != null)
        //    {
        //        string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "Images");
        //        uniqueFileName = Guid.NewGuid().ToString() + "_" + Splash.FileName;

        //        string filePath = Path .Combine(uploadsFolder, uniqueFileName);

        //        using (var fileStream = new FileStream(filePath, FileMode.Create)
        //        {
        //            Splash.CopyTo(fileStream)
        //        }
        //    }
        //}

        public IActionResult OnGet()
        {
            return Page();
        }
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _champservice.AddChamp(champion);
            return RedirectToPage("GetAllChamps");
        }
    }
}

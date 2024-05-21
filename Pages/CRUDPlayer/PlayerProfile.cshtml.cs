using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages.CRUDPlayer
{
    public class PlayerProfileModel : PageModel
    {
        private PlayerService _playerService;
        private MatchService _matchService;
        public PlayerProfileModel(PlayerService playerService, MatchService matchService)
        {
            _playerService = playerService;
            _matchService = matchService;
        }
        public Player player { get; set; }
        public List<Match> matches { get; set; }
        public Match match { get; set; }
        public IActionResult OnGet(int id)
        {
            matches = _matchService.GetMatches();
            player = _playerService.GetPlayer(id);
            //var p = _playerService.GetPlayer(id);
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

    }
}

using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace LolTrack.Pages
{
    public class IndexModel : PageModel
    {
        private PlayerService _playerService;
        private MatchService _matchService;
        private readonly ILogger<IndexModel> _logger;
        [BindProperty]
        public string SearchStr { get; set; }
        public List<Player> PlayerList { get; set; }
        public Player player { get; set; }

        public IndexModel(ILogger<IndexModel> logger, PlayerService playerService)
        {
            _logger = logger;
            _playerService = playerService;
        }

        public void OnGet()
        {
            PlayerList = _playerService.GetPlayers();
        }
        public IActionResult OnPostPlayerSearch()
        {
            PlayerList = _playerService.PlayerSearch(SearchStr).ToList();
            player = _playerService.GetPlayerName(SearchStr);
            return Page();
            //return RedirectToPage("/CrudPlayer/PlayerProfile");
        }
    }
}

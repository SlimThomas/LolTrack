using LolTrack.Models;
using LolTrack.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net;

namespace LolTrack.Pages.CRUDPlayer
{
    public class GetAllPlayersModel : PageModel
    {
        private PlayerService _playerService;
        public List<Player> players {  get; set; }
        public GetAllPlayersModel(PlayerService playerService)
        {
            this._playerService = playerService;
        }
        public void OnGet()
        {
            players = _playerService.GetPlayers(); 
        }
    }
}

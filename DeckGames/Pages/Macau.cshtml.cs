using DeckGames.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DeckGames.Pages
{
    public class MacauModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        public MacauGameCall macauGame;
        public MacauModel(ILogger<PrivacyModel> logger, MacauGameCall macauGameCall)
        {
            _logger = logger;
            macauGame = macauGameCall;
        }
        public void OnGet()
        {
            macauGame.MacauAppLaunch();
        }
    }
}

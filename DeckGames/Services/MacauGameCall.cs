using System.Diagnostics;
using System.Text.Json;

namespace DeckGames.Services
{

    public class MacauGameCall
    {
        public MacauGameCall(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }
        public IWebHostEnvironment WebHostEnvironment { get; }
        private string MacauGameDirectory
        {
            get { return Path.Combine(WebHostEnvironment.ContentRootPath, "Cards.exe"); }
        }
        public void MacauAppLaunch()
        {
            Process proc = new Process();

            proc.StartInfo.UseShellExecute = true;
            proc.StartInfo.FileName = MacauGameDirectory;
            //proc.StartInfo.WorkingDirectory = MacauGameDirectory;

            proc.Start();
            proc.WaitForExit();
        }
    }
}

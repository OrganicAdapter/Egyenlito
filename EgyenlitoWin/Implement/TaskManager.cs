using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System;

namespace EgyenlitoWin.Implement
{
    public class TaskManager : ITaskManager
    {
        public async void OpenWebpage(string uri)
        {
            var page = new Uri(uri);
            await Launcher.LaunchUriAsync(page);
        }

        public async void SendEmail()
        {
            var mailto = new Uri("mailto:?to=ujegyenlito2013@gmail.com&subject=Észrevétel");
            await Launcher.LaunchUriAsync(mailto);
        }
    }
}

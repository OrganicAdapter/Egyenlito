using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface ITaskManager
    {
        void OpenWebpage(string uri);
        void SendEmail();
    }
}

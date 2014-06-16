using EgyenlitoLIB.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface IEventManager
    {
        Task<List<Event>> GetEvents();
        Task<List<Upholder>> GetUpholders();
    }
}

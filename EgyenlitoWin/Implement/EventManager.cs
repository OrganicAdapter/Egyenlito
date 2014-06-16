using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using EgyenlitoWin.EventService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoWin.Implement
{
    public class EventManager : IEventManager
    {
        public WinEventServiceClient Service { get; set; }


        public EventManager()
        {
            Service = new WinEventServiceClient();
        }


        public async Task<List<Event>> GetEvents()
        {
            var json = await Service.GetEventsAsync();
            return await JsonConvert.DeserializeObjectAsync<List<Event>>(json);
        }

        public async Task<List<Upholder>> GetUpholders()
        {
            var json = await Service.GetUpholdersAsync();
            return await JsonConvert.DeserializeObjectAsync<List<Upholder>>(json);
        }
    }
}

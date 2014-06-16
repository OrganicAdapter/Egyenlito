using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class EventViewModel : ViewModelBase
    {
        private List<Event> _eventslist;
        public List<Event> EventsList
        {
            get { return _eventslist; }
            set { _eventslist = value; OnPropertyChanged("EventsList"); }
        }

        private List<Upholder> _upholders;
        public List<Upholder> Upholders
        {
            get { return _upholders; }
            set { _upholders = value; OnPropertyChanged("Upholders"); }
        }


        public RelayCommand<Event> OpenEvent { get; set; }


        public EventViewModel()
        {
            GetEvents();
            GetUpholders();

            OpenEvent = new RelayCommand<Event>((x) => ExecuteOpenEvent(x));
        }


        private async void GetEvents()
        {
            Loading = true;
            EventsList = await Main.EventManager.GetEvents();
            Loading = false;
        }

        private async void GetUpholders()
        {
            Upholders = await Main.EventManager.GetUpholders();
        }

        private void ExecuteOpenEvent(Event eve)
        {
            Main.Event = eve;
            Main.NavigationService.Navigate("EventReaderView");
        }
    }
}

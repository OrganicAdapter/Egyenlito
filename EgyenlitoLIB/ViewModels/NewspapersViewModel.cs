using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class NewspapersViewModel : ViewModelBase
    {
        private List<Newspaper> _newspapers;
        public List<Newspaper> Newspapers
        {
            get { return _newspapers; }
            set { _newspapers = value; OnPropertyChanged("Newspapers"); }
        }


        public RelayCommand GetNewspapers { get; set; }
        public RelayCommand<Newspaper> OpenNewspaper { get; set; }


        public NewspapersViewModel()
        {
            GetNewspapers = new RelayCommand(ExecuteGetNewspapers);
            OpenNewspaper = new RelayCommand<Newspaper>((newspaper) => ExecuteOpenNewspaper(newspaper));
        }


        private async void ExecuteGetNewspapers()
        {
            Loading = true;
            Newspapers = await Main.DataManager.GetNewspapers();
            Loading = false;
        }

        private void ExecuteOpenNewspaper(Newspaper newspaper)
        {
            Main.Newspaper = newspaper;
            Main.NavigationService.Navigate("ArticlesView");
        }
    }
}

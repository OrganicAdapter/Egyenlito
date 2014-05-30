using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class ViewModelBase : INotifyPropertyChanged
    {
        public MainViewModel Main { get; set; }
        
        private bool _loading;
        public bool Loading
        {
            get { return _loading; }
            set { _loading = value; OnPropertyChanged("Loading"); }
        }


        public RelayCommand GoBack { get; set; }
        public RelayCommand<string> Navigate { get; set; }
        public RelayCommand SendEmail { get; set; }
        public RelayCommand<string> OpenWebPage { get; set; }


        public ViewModelBase()
        {
            GoBack = new RelayCommand(ExecuteGoBack);
            Navigate = new RelayCommand<string>((path) => ExecuteNavigate(path));
            SendEmail = new RelayCommand(ExecuteSendEmail);
            OpenWebPage = new RelayCommand<string>((uri) => ExecuteOpenWebPage(uri));

            Main = MainViewModel.Instance;
        }


        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(e));
        }


        private void ExecuteGoBack()
        {
            Main.NavigationService.GoBack();
        }

        private void ExecuteNavigate(string path)
        {
            Main.NavigationService.Navigate(path);
        }

        private void ExecuteSendEmail()
        {
            Main.TaskManager.SendEmail();
        }

        private void ExecuteOpenWebPage(string uri)
        {
            Main.TaskManager.OpenWebpage(uri);
        }
    }
}

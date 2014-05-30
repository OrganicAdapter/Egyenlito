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


        public ViewModelBase()
        {
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

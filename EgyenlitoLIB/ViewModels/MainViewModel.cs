using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class MainViewModel
    {
        private static MainViewModel _instance;
        public static MainViewModel Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new MainViewModel();

                return _instance;
            }
        }


        public IDataManager DataManager { get; set; }
        public IDownloadManager DownloadManager { get; set; }
        public IFacebookManager FacebookManager { get; set; }
        public ILocalFileManager LocalFileManager { get; set; }
        public INavigationService NavigationService { get; set; }
        public IPdfRenderer PdfRenderer { get; set; }
        public ITaskManager TaskManager { get; set; }

        public Article Article { get; set; }
        public Newspaper Newspaper { get; set; }


        public async void Init()
        {
            await LocalFileManager.GetArticles();
        }
    }
}

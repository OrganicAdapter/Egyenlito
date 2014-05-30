using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class LocalArticlesViewModel : ViewModelBase
    {
        private List<Article> _articles;
        public List<Article> Articles
        {
            get { return _articles; }
            set { _articles = value; OnPropertyChanged("Articles"); }
        }


        public RelayCommand GetAllArticles { get; set; }
        public RelayCommand<Article> OpenArticle { get; set; }


        public LocalArticlesViewModel()
        {
            Init();

            GetAllArticles = new RelayCommand(ExecuteGetAllArticles);
            OpenArticle = new RelayCommand<Article>((article) => ExecuteOpenArticle(article));
        }


        private async void Init()
        {
            Articles = await Main.LocalFileManager.GetArticles();
        }

        private async void ExecuteGetAllArticles()
        {
            Loading = true;
            Articles = await Main.LocalFileManager.GetArticles();
            Loading = false;
        }

        private void ExecuteOpenArticle(Article article)
        {
            Main.Article = article;
            Main.NavigationService.Navigate("PdfReaderView");
        }
    }
}

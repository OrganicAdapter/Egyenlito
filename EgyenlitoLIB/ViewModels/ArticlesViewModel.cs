using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class ArticlesViewModel : ViewModelBase
    {
        private List<Article> _articles;
        public List<Article> Articles
        {
            get { return _articles; }
            set { _articles = value; OnPropertyChanged("Articles"); }
        }


        public RelayCommand GetArticles { get; set; }
        public RelayCommand<Article> OpenArticle { get; set; }


        public ArticlesViewModel()
        {
            GetArticles = new RelayCommand(ExecuteGetArticles);
            OpenArticle = new RelayCommand<Article>((article) => ExecuteOpenArticle(article));
        }


        private async void ExecuteGetArticles()
        {
            Loading = true;
            await Main.LocalFileManager.GetArticles();
            Articles = await Main.DataManager.GetArticles(Main.Newspaper.NewspaperId);
            Loading = false;
        }

        private void ExecuteOpenArticle(Article article)
        {
            Main.Article = article;
            Main.NavigationService.Navigate("PdfReaderView");
        }
    }
}

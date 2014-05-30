using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class AllArticlesViewModel : ViewModelBase
    {
        private List<Article> _articles;
        public List<Article> Articles
        {
            get { return _articles; }
            set { _articles = value; OnPropertyChanged("Articles"); }
        }


        public RelayCommand GetAllArticles { get; set; }
        public RelayCommand<Article> OpenArticle { get; set; }


        public AllArticlesViewModel()
        {
            GetAllArticles = new RelayCommand(ExecuteGetAllArticles);
            OpenArticle = new RelayCommand<Article>((article) => ExecuteOpenArticle(article));
        }


        private async void ExecuteGetAllArticles()
        {
            Loading = true;
            await Main.LocalFileManager.GetArticles();
            Articles = await Main.DataManager.GetAllArticles();
            Loading = false;
        }

        private void ExecuteOpenArticle(Article article)
        {
            Main.Article = article;
            Main.NavigationService.Navigate("PdfReaderView");
        }
    }
}

using EgyenlitoLIB.Models.Data;
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


        public ArticlesViewModel()
        {

        }


        private async void ExecuteGetArticles()
        {
            Loading = true;
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

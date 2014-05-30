using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Implement
{
    public class LocalFileManager : ILocalFileManager
    {
        public ILocalDataManager DataManager { get; set; }
        public List<Article> Articles { get; set; }


        public LocalFileManager(ILocalDataManager dataManager)
        {
            DataManager = dataManager;
        }


        public async Task<List<Article>> GetArticles()
        {
            Articles = await DataManager.Load();
            return Articles;
        }

        public bool ArticleExists(Article article)
        {
            return Articles.Contains(article);
        }

        public async void AddArticle(Article article)
        {
            Articles.Add(article);

            await DataManager.Save(Articles);
        }

        public async void DeleteArticle(Article article)
        {
            Articles.Remove(article);

            await DataManager.Save(Articles);
        }
    }
}

using EgyenlitoLIB.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface ILocalFileManager
    {
        ILocalDataManager DataManager { get; set; }

        Task<List<Article>> GetArticles();
        bool ArticleExists(int articleId);
        void AddArticle(Article article);
        void DeleteArticle(Article article);
    }
}

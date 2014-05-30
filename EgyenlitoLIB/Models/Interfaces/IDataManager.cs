using EgyenlitoLIB.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface IDataManager
    {
        Task<List<Newspaper>> GetNewspapers();
        Task<List<Article>> GetAllArticles();
        Task<List<Article>> GetArticles(int newspaperID);
    }
}

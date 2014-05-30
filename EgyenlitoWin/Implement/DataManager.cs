using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoWin.Implement
{
    public class DataManager : IDataManager
    {
        public Task<List<Newspaper>> GetNewspapers()
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetAllArticles()
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> GetArticles(int newspaperID)
        {
            throw new NotImplementedException();
        }
    }
}

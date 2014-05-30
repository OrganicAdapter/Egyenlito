using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoWin.Implement
{
    public class LocalDataManager : ILocalDataManager
    {
        public Task Save(List<Article> articles)
        {
            throw new NotImplementedException();
        }

        public Task<List<Article>> Load()
        {
            throw new NotImplementedException();
        }
    }
}

using EgyenlitoLIB.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface ILocalDataManager
    {
        Task Save(List<Article> articles);
        Task<List<Article>> Load();
    }
}

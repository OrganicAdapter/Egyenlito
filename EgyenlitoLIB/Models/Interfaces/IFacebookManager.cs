using EgyenlitoLIB.Models.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface IFacebookManager
    {
        void Authenticate(Article article, Newspaper newspaper);
        Task Post();
    }
}

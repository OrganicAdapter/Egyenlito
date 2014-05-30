using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.Models.Interfaces
{
    public interface IPdfRenderer
    {
        Task<List<string>> RenderPDF(int articleId);
        Task<List<string>> RenderLocalPDF(int articleId);
    }
}

using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using EgyenlitoWin.DataProviderService;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoWin.Implement
{
    public class DataManager : IDataManager
    {
        public DataProviderServiceClient Service { get; set; }


        public DataManager()
        {
            Service = new DataProviderServiceClient();
        }


        public async Task<List<Newspaper>> GetNewspapers()
        {
            var json = await Service.GetNewspapersAsync();
            return await JsonConvert.DeserializeObjectAsync<List<Newspaper>>(json);
        }

        public async Task<List<Article>> GetAllArticles()
        {
            var json = await Service.GetAllArticlesAsync();
            return await JsonConvert.DeserializeObjectAsync<List<Article>>(json);
        }

        public async Task<List<Article>> GetArticles(int newspaperID)
        {
            var json = await Service.GetArticlesAsync(newspaperID);
            return await JsonConvert.DeserializeObjectAsync<List<Article>>(json);
        }
    }
}

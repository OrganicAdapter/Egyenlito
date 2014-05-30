using EgyenlitoLIB.Models.Data;
using EgyenlitoLIB.Models.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;

namespace EgyenlitoWin.Implement
{
    public class LocalDataManager : ILocalDataManager
    {
        public async Task Save(List<Article> articles)
        {
            StorageFile file = await ApplicationData.Current.LocalFolder.CreateFileAsync("locals.xml", CreationCollisionOption.ReplaceExisting);
            var json = "";
            await Task.Factory.StartNew(() =>
            {
                json = JsonConvert.SerializeObject(articles);
            });

            await FileIO.WriteTextAsync(file, json);
        }

        public async Task<List<Article>> Load()
        {
            try
            {
                var file = await ApplicationData.Current.LocalFolder.GetFileAsync("locals.xml");
                var json = await FileIO.ReadTextAsync(file);

                var articles = new List<Article>();
                await Task.Factory.StartNew(() =>
                {
                    articles = JsonConvert.DeserializeObject<List<Article>>(json);
                });

                return articles;
            }

            catch (FileNotFoundException)
            {
                return new List<Article>();
            }
        }
    }
}

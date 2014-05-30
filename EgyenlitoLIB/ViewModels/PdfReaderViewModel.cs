using EgyenlitoLIB.Models.Data;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EgyenlitoLIB.ViewModels
{
    public class PdfReaderViewModel : ViewModelBase
    {
        private List<string> _pages;
        public List<string> Pages
        {
            get { return _pages; }
            set { _pages = value; OnPropertyChanged("Pages"); }
        }

        private int _zoom;
        public int Zoom
        {
            get { return _zoom; }
            set { _zoom = value; OnPropertyChanged("Zoom"); }
        }


        public RelayCommand GetPdf { get; set; }
        public RelayCommand Post { get; set; }
        public RelayCommand Remove { get; set; }

        public PdfReaderViewModel()
        {
            Zoom = 250;

            GetPdf = new RelayCommand(ExecuteGetPdf);
            Post = new RelayCommand(ExecutePost);
            Remove = new RelayCommand(ExecuteRemove);
        }


        private async void ExecuteGetPdf()
        {
            Loading = true;
            if (Main.LocalFileManager.ArticleExists(Main.Article.ArticleId))
            {
                Pages = await Main.PdfRenderer.RenderLocalPDF(Main.Article.ArticleId);
            }
            else
            {
                await Main.DownloadManager.DownloadFile(Main.Article.PdfUri);
                
                Main.LocalFileManager.AddArticle(Main.Article);
                
                Pages = await Main.PdfRenderer.RenderPDF(Main.Article.ArticleId);
            }
            Loading = false;
        }

        private void ExecutePost()
        {
            Main.FacebookManager.Authenticate(Main.Article, Main.Newspaper);
        }

        private void ExecuteRemove()
        {
            Main.LocalFileManager.DeleteArticle(Main.Article);
            Main.NavigationService.GoBack();
        }
    }
}

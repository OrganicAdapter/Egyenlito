using EgyenlitoLIB.Models.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml.Controls;

namespace EgyenlitoWin.Implement
{
    public class NavigationService : INavigationService
    {
        private Frame RootFrame { get; set; }

        public NavigationService(Frame rootFrame)
        {
            RootFrame = rootFrame;
        }


        public void Navigate(string type)
        {
            RootFrame.Navigate(Type.GetType("EgyenlitoWin." + type));
        }

        public void GoBack()
        {
            RootFrame.GoBack();
        }
    }
}

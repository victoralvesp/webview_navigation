using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebviewNavigation.ViewModels;
using Xamarin.Forms;

namespace WebviewNavigation
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void WebView_Navigated(object sender, WebNavigatedEventArgs e)
        {
            if (BindingContext is MainViewModel vm)
            {
                vm.Navigated(Dispatcher);
            }
        }
    }
}

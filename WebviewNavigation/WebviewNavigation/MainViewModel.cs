using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using Xamarin.Forms;

namespace WebviewNavigation.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        // This method is called by the Set accessor of each property.
        // The CallerMemberName attribute that is applied to the optional propertyName
        // parameter causes the property name of the caller to be substituted as an argument.
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        private bool _showWebView;

        public bool ShowWebView
        {
            get { return _showWebView; }
            set
            {
                if (_showWebView != value)
                {
                    _showWebView = value;
                    NotifyPropertyChanged(); 
                }
            }
        }

        private bool _showLoading = true;

        public bool ShowLoading
        {
            get { return _showLoading; }
            set
            {
                if (_showLoading != value)
                {
                    _showLoading = value;
                    NotifyPropertyChanged();
                }
            }
        }


        internal void Navigated(IDispatcher dispatcher)
        {
            dispatcher.BeginInvokeOnMainThread(() =>
            {
                ShowWebView = true;
                ShowLoading = false;
            });
        }
    }
}

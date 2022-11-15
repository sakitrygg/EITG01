using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApplictionProject.Views
{
    
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
            Command BrowseCommand = new Command(async () => await Browser.OpenAsync("https://github.com/sakitrygg/EITG01/tree/main/ApplictionProject", BrowserLaunchMode.SystemPreferred));
        }
        
    }
}
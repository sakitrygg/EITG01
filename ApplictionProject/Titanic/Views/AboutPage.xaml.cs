using System;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Titanic.Views
{
    public partial class AboutPage : ContentPage
    {
        public AboutPage()
        {
            InitializeComponent();
        }
        async void BrowseCommand(object sender, EventArgs e)
        {
            /* opens external launcher */
            //await Launcher.OpenAsync("https://github.com/sakitrygg/EITG01/tree/main/ApplictionProject");

            /* opens internal launcher in the app */
            await Browser.OpenAsync("https://github.com/sakitrygg/EITG01/tree/main/ApplictionProject");
        }
    }
}
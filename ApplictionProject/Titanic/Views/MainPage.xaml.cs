using System;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Titanic.Views
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void ToIceBreaker (object sender, EventArgs e)
        {
            await Navigation.PushAsync(new QuestionPage());
        }
    }
}
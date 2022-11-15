using ApplictionProject.ViewModels;
using ApplictionProject.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;
using System.Windows.Input;
using Xamarin.Essentials;

namespace ApplictionProject
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(AboutPage), typeof(AboutPage));
        }      

       
    }
}

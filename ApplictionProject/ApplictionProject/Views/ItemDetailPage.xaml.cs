using ApplictionProject.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace ApplictionProject.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();


        }
    }
}
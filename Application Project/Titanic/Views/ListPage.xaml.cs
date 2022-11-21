using Titanic.ViewModels;
using Xamarin.Forms;

namespace Titanic.Views
{
    public partial class ListPage : ContentPage
    {
        readonly ListViewModel _viewModel;

        public ListPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ListViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }
    }
}
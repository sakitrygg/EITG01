
using Titanic.ViewModels;
using Xamarin.Forms;

namespace Titanic.Views
{
    public partial class QuestionPage : ContentPage
    {
        public QuestionPage()
        {
            InitializeComponent();
            BindingContext = new QuestionViewModel();
        }
    }
}

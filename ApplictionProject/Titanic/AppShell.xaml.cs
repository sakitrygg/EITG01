using Titanic.Views;
using Xamarin.Forms;
namespace Titanic
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

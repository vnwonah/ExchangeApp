using ExchangeApp.PageModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExchangeApp.Pages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            NavigationPage.SetHasNavigationBar(this, false);
            BindingContext = new HomePagePageModel();
        }
    }
}
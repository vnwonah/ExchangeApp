using System.Collections.Generic;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ExchangeApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MultiListElement : ContentView
    {
        public MultiListElement()
        {
            InitializeComponent();
            collectionView.ItemsSource = new List<string> { "Hello", "my", "man" };
        }
    }
}
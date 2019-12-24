using ExchangeApp.Models;
using ExchangeApp.Views;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExchangeApp.PageModels
{
    public class HomePagePageModel : BasePageModel
    {
        public ObservableCollection<Company> Companies { get; set; }
        public ObservableCollection<View> Offers { get; set; }

        public HomePagePageModel()
        {
            Task.Run(() => LoadCompanies());
            Task.Run(() => LoadOffers());
        }

        private void LoadCompanies()
        {
            Companies = new ObservableCollection<Company>()
            {
                new Company {ImageUrl = "https://i.ibb.co/XCnn7dt/cowrywise.png" },
                new Company {ImageUrl = "https://i.ibb.co/DVjcnHD/thriveagric.png" },
                new Company {ImageUrl = "https://i.ibb.co/ZhgwcZv/farmcrowdy.png" },
                new Company {ImageUrl = "https://i.ibb.co/my6trRV/piggyvest.png" },
                new Company {ImageUrl = "https://i.ibb.co/7X3b9DJ/alat.png" },
                new Company {ImageUrl = "https://i.ibb.co/WGrrd4j/kolopay.png" }

            };
            
        }

        private void LoadOffers()
        {
      
        }
    }
}

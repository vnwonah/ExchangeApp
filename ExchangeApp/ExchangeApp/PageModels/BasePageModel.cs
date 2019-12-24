using System.ComponentModel;

namespace ExchangeApp.PageModels
{
    public class BasePageModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
    }
}

using System.Collections.ObjectModel;
using System.Collections.Specialized;
using Xamarin.Forms;

namespace ExchangeApp.CustomElements
{
    public class BindableStackLayout : StackLayout
    {
        public static readonly BindableProperty ItemsProperty =
        BindableProperty.Create(nameof(Items), typeof(ObservableCollection<View>), typeof(BindableStackLayout), null,
            propertyChanged: (b, o, n) =>
            {
                (n as ObservableCollection<View>).CollectionChanged += (coll, arg) =>
                {
                    switch (arg.Action)
                    {
                        case NotifyCollectionChangedAction.Add:
                            foreach (var v in arg.NewItems)
                            {
                                (b as BindableStackLayout).Children.Add((View)v);
                            }
                            break;
                        case NotifyCollectionChangedAction.Remove:

                            //foreach (var v in arg.NewItems)
                            //    (b as BindableStackLayout).Children.Remove((View)v);

                            (b as BindableStackLayout).Children.Remove((View)arg.OldItems[0]);

                            break;
                        case NotifyCollectionChangedAction.Move:
                            //Do your stuff
                            break;
                        case NotifyCollectionChangedAction.Replace:
                            //Do your stuff
                            break;


                    }
                };
            });


        public ObservableCollection<View> Items
        {
            get { return (ObservableCollection<View>)GetValue(ItemsProperty); }
            set { SetValue(ItemsProperty, value); }
        }
    }
}

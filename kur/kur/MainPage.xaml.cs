using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kur
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            listProduct.ItemsSource = App.orders;
        }

        private void Button_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pageAdd());
        }

        private async void listProduct_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var temp = (order)listProduct.SelectedItem;
            await Navigation.PushAsync(new pageAdd(temp));
        }
    }
}

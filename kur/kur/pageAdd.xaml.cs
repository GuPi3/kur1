using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace kur
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class pageAdd : ContentPage
    {
        private order currentProduct {get; set; }
        public pageAdd()
        {
            InitializeComponent();
        }
        ObservableCollection<consumption> da;
        public pageAdd(order Order)
        {
            
            InitializeComponent();
            currentProduct = Order;
            nameProduct.Text = Order.Name;
            sum.Text = Convert.ToString(Order.sumOrder);
            sumPrep.Text = Convert.ToString(Order.sumPrepayment);
            sumInst.Text = Convert.ToString(Order.costInstal);
            Expems.Text = Convert.ToString(Order.Expemses);
            listExpemses.ItemsSource = Order.Cons;
            da = Order.Cons;

        }

        private void Button_Add(object sender, EventArgs e)
        {
            App.orders.Add(new order { Name = nameProduct.Text, sumOrder = Convert.ToInt32(sum.Text), sumPrepayment = Convert.ToInt32(sumPrep.Text), costInstal = Convert.ToInt32(sumInst.Text), Expemses = Convert.ToInt32(Expems.Text), Cons = new ObservableCollection<consumption>()});
            Navigation.PopAsync();
        }

        private void Button_Change(object sender, EventArgs e)
        {
            var a = App.orders.IndexOf(currentProduct);
            currentProduct.Name = nameProduct.Text;
            currentProduct.sumOrder = Convert.ToInt32(sum.Text);
            currentProduct.costInstal = Convert.ToInt32(sum.Text);
            currentProduct.Expemses = Convert.ToInt32(Expems.Text);
            Navigation.PopAsync();
        }

        private void Button_Del(object sender, EventArgs e)
        {
            App.orders.Remove(currentProduct);
            Navigation.PopAsync();
        }

        private async void listExpemses_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var a = (consumption)listExpemses.SelectedItem;
            await Navigation.PushAsync(new pageAddConsumption(currentProduct ,a));
        }

        private void Button_Add_Consumption(object sender, EventArgs e)
        {
            Navigation.PushAsync(new pageAddConsumption(currentProduct));
        }
    }
}
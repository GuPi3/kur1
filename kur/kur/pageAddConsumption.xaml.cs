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
    public partial class pageAddConsumption : ContentPage
    {
        order da;
        private consumption currentConsumption { get; set; }
        public pageAddConsumption(order Order)
        {
            
            InitializeComponent();
            da = Order;


        }
        
        public pageAddConsumption(order Order, consumption Consumption)
        {
            
            InitializeComponent();
            da = Order;
            currentConsumption = Consumption;
            nameConsumptions.Text = Consumption.NameConsumption;
            sumConsumptions.Text = Convert.ToString(Consumption.SumConsumption);
        }

        private void Add_Clicked(object sender, EventArgs e)
        {
            da.Cons.Add( new consumption { NameConsumption = nameConsumptions.Text, SumConsumption = Convert.ToInt32(sumConsumptions.Text) });
            Navigation.PopAsync();
        }

        private void Change_Clicked(object sender, EventArgs e)
        {
            var a = App.consumptions.IndexOf(currentConsumption);
            currentConsumption.NameConsumption = nameConsumptions.Text;
            currentConsumption.SumConsumption = Convert.ToInt32(sumConsumptions.Text);
            Navigation.PopAsync();
        }

        private void Del_Clicked(object sender, EventArgs e)
        {
            
            da.Cons.Remove(currentConsumption);
            Navigation.PopAsync();
        }
    }
}

using System;
using System.Collections.ObjectModel;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.Linq;
using System.Collections.Generic;

namespace kur
{
    public partial class App : Application
    {

        public static ObservableCollection<order> orders = new ObservableCollection<order>();
        public static ObservableCollection<consumption> consumptions = new ObservableCollection<consumption>();
        public App()
        {
            InitializeComponent();
            if (Application.Current.Properties.TryGetValue("db", out object value) == true)
            {
                var list = JsonConvert.DeserializeObject<List<order>>(value.ToString());
                App.orders = new ObservableCollection<order>(list);
            }
            else
            {
                string json = JsonConvert.SerializeObject(orders);
                Application.Current.Properties["db"] = json;
                Application.Current.SavePropertiesAsync();
            }



            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
            string json = JsonConvert.SerializeObject(orders);
            Application.Current.Properties["db"] = json;
            Application.Current.SavePropertiesAsync();
        }

        protected override void OnResume()
        {
        }

    }
}

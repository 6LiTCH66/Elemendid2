using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Laupaev : ContentPage
    {
        public Laupaev()
        {
            InitializeComponent();
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            var options = new MapLaunchOptions { Name = "My Location" };
            try
            {
                var location = await Xamarin.Essentials.Geolocation.GetLastKnownLocationAsync();
                if(location == null)
                {
                    location = await Xamarin.Essentials.Geolocation.GetLocationAsync(new GeolocationRequest
                    {
                        DesiredAccuracy = GeolocationAccuracy.Medium,
                        Timeout = TimeSpan.FromSeconds(30)
                    });
                }
                await Xamarin.Essentials.Map.OpenAsync(location, options);
            }
            catch (Exception)
            {

            }
        }
    }
}
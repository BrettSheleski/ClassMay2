using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace GPSDemo
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            double latitude = 0, longitude = 0;

            // get the latitude and longitude somehow???

            Xamarin.Essentials.Location location =  await Xamarin.Essentials.Geolocation.GetLocationAsync();

            latitude = location.Latitude;
            longitude = location.Longitude;

            LatitudeLabel.Text = latitude.ToString();
            LongitudeLabel.Text = longitude.ToString();
        }
    }
}

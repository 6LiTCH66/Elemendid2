using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Elemendid2.MainPage())
            {
                BackgroundColor = Color.Coral,
            };
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}

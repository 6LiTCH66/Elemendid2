using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Puhapaev : ContentPage
    {
        Label labelLoading;
        WebView web;
        Button btn;
        public Puhapaev()
        {
            Title = "WebView";
            labelLoading = new Label()
            {
                Text = "Loading...",
                IsVisible = false,
            };
            web = new WebView()
            {
                HeightRequest = 1000,
                WidthRequest = 1000,
                Source = "https://www.tthk.ee/",
                
            };
            web.Navigated += Web_Navigated;
            web.Navigating += Web_Navigating;

            btn = new Button()
            {
                Text = "Koju",
            };
            btn.Clicked += Btn_Clicked;

            StackLayout stackLayout = new StackLayout()
            {
                Children = { labelLoading, web, btn },
            };
            Content = stackLayout;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "Koju")
            {
                await Navigation.PushAsync(new MainPage());
            }
        }

        private void Web_Navigating(object sender, WebNavigatingEventArgs e)
        {
            labelLoading.IsVisible = true;
        }

        private void Web_Navigated(object sender, WebNavigatedEventArgs e)
        {
            labelLoading.IsVisible = false;
        }
    }
}
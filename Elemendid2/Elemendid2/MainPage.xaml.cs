using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Elemendid2
{
    public partial class MainPage : ContentPage
    {
        

        
        Button[] btns = new Button[7];
        StackLayout stack;
        string[] paevad = new string[] { "ListView", "DatePicker", "TableView", "TimePicker", "Speek", "Map", "WebView" };

        public MainPage()
        {
            Title = "Koju";
            stack = new StackLayout();

            stack.Padding = new Thickness(10, 10, 10, 10);
            for (int i = 0; i < 7; i++)
            {

                foreach (var item in paevad)
                {
                    btns[i] = new Button() { Text = paevad[i] };
                }
                stack.Children.Add(btns[i]);
                btns[i].Clicked += Btn_Clicked;
                

            };

            Content = stack;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if (s == "ListView")
            {
                await Navigation.PushAsync(new Esmaspäev());
            }
            else if (s == "DatePicker")
            {
                await Navigation.PushAsync(new Teisipaev());
            }
            else if(s == "TableView")
            {
                await Navigation.PushAsync(new Kolmapaev());
            }
            else if(s == "TimePicker")
            {
                await Navigation.PushAsync(new Neljapaev());
            }
            else if (s == "Speek")
            {
                await Navigation.PushAsync(new Reede());
            }
            else if (s == "Map")
            {
                await Navigation.PushAsync(new Laupaev());
            }
            else if(s == "WebView")
            {
                await Navigation.PushAsync(new Puhapaev());
            }
        }
    }
}

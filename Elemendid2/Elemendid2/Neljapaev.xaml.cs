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
    public partial class Neljapaev : ContentPage
    {
        Entry entry;
        Label lbl1, lbl2;
        Switch _switch;
        Button btn, btn2;
        TimePicker timePicker;
        public Neljapaev()
        {
            Title = "TimePicker";
            entry = new Entry
            {
                Placeholder = "Sisestage meeldetuletatav sündmus",

            };

            lbl1 = new Label()
            {
                Text = "Valige allpool meeldetuletamise aeg.",
            };

            lbl2 = new Label()
            {
                Text = "Salvesta",
            };
            _switch = new Switch()
            {
                HorizontalOptions = LayoutOptions.EndAndExpand,
                IsToggled = false,
            };
            _switch.Toggled += _switch_Toggled;
            btn = new Button()
            {
                Text = "Speek",
            };
            btn.Clicked += Btn_Clicked;

            btn2 = new Button()
            {
                Text = "Koju",
            };
            btn2.Clicked += Btn_Clicked;

            timePicker = new TimePicker
            {
                Time = new TimeSpan(11, 0, 0),
                Format = "T",
            };

            StackLayout stackLayout1 = new StackLayout
            {
                Children = { _switch, lbl2,  }
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { entry, lbl1, timePicker, stackLayout1 , btn, btn2}
            };
            Content = stackLayout;
        }

        private void _switch_Toggled(object sender, ToggledEventArgs e)
        {
            DisplayAlert(entry.Text, "Sine meeldetuletamise aeg on : " + timePicker.Time.ToString(), "OK");
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "Speek")
            {
                await Navigation.PushAsync(new Reede());
            }
            else if(s == "Koju")
            {
                await Navigation.PushAsync(new MainPage());
            }
            
        }
    }
}
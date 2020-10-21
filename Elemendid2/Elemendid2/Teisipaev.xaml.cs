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
    public partial class Teisipaev : ContentPage
    {
        Button btn1, btn2;
        Label lbl;
        public Teisipaev()
        {
            Title = "Teisipäev";

            btn1 = new Button()
            {
                Text = "Esmaspäev"
            };
            btn1.Clicked += Btn1_Clicked;

            btn2 = new Button()
            {
                Text = "Kolmapäev",
            };
            btn2.Clicked += Btn1_Clicked;

            lbl = new Label()
            {
                Text = "Teisipäev",
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, btn1, btn2 }
            };
            Content = stackLayout;
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "Esmaspäev")
            {
                await Navigation.PushAsync(new Esmaspäev());
            }
            else if (s == "Kolmapäev")
            {
                await Navigation.PushAsync(new Kolmapaev());
            }
        }
    }
}
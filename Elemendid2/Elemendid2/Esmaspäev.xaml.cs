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
    public partial class Esmaspäev : ContentPage
    {
        Button btn;
        Label lbl;
        ListView listView;

        public Esmaspäev()
        {
            string[] tasks = new string[] { "7:00 Tõusen püsti", "7:20 Söön putru", " 8:00 Jalutan", " 10:30 Lähen lõunale", "12:45 Tegelen spordiga", "19:00 Söön", "22:00 Magan" };
            listView = new ListView();
            listView.ItemsSource = tasks;

            Title = "Esmaspäev";

            btn = new Button()
            {
                Text = "Teisipäev",
            };

            btn.Clicked += Btn_Clicked;

            lbl = new Label()
            {
                Text = "Esmaspäev!",
                HorizontalOptions = LayoutOptions.Center,
                FontSize = 24,
                TextColor = Color.Black,
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, listView, btn }
            };
            Content = stackLayout;

        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }
    }
}
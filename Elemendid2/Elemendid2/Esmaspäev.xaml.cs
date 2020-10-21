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
        public Esmaspäev()
        {
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
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, btn }
            };
            Content = stackLayout;

        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Teisipaev());
        }
    }
}
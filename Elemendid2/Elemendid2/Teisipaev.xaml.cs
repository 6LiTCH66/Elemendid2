using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Teisipaev : ContentPage
    {
        Button btn1;
        Label lbl, lbl2;
        ListView listView;
        DatePicker datePicker;
        public Teisipaev()
        {

            datePicker = new DatePicker
            {
                MinimumDate = new DateTime(2020, 1, 1),
                MaximumDate = new DateTime(2020, 12, 31),
                Date = new DateTime(2020, 10, 23),
            };

            Title = "Teisipäev";

            btn1 = new Button()
            {
                Text = "Kolmapäev",
            };
            btn1.Clicked += Btn1_Clicked;

            lbl = new Label()
            {
                Text = "Teisipäev",
            };

            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, datePicker, btn1}
            };
            Content = stackLayout;
        }

        private async void Btn1_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "Kolmapäev")
            {
                await Navigation.PushAsync(new Kolmapaev());
            }
        }
    }
}
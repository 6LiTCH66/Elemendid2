using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Kolmapaev : ContentPage
    {
        Button btn, btn2;
        Label lbl;
        TableView tableView;
        TableRoot Tableroot;
        TableSection tabelSection;
        public Kolmapaev()
        {
            Title = "Kolmapäev";
            BackgroundColor = Color.White;
            Title = "Kolmapäev";
            lbl = new Label()
            {
                Text = "Kolmapäev",
            };
            btn = new Button()
            {
                Text = "Neljapäev",
            };
            btn.Clicked += Btn_Clicked;

            btn2 = new Button()
            {
                Text = "Päevaplan",
            };
            btn2.Clicked += Btn_Clicked;

            tableView = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection("")
                    {
                      new EntryCell{Label = "Mis su nimi on?", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "Mis su perekonanimi on?", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "Kui vana sa oled?", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "Kuhu sa elad?", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "Millal on sinu sünipäev", Placeholder = "Kirjuta siin"},
                    }
                },
                Intent = TableIntent.Settings
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, tableView, btn, btn2 }
            };
            Content = stackLayout;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            string s = (sender as Button).Text;
            if(s == "Neljapäev")
            {
                await Navigation.PushAsync(new Neljapaev());
            }
            
            else if(s == "Päevaplan")
            {
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}
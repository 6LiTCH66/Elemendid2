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
        Button btn;
        Label lbl;
        TableView tableView;
        TableRoot Tableroot;
        TableSection tabelSection;
        public Kolmapaev()
        {
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

            tableView = new TableView
            {
                Root = new TableRoot
                {
                    new TableSection("Agent Sales Details")
                    {
                      // TableSection constructor takes title as an optional parameter
                      new EntryCell{Label = "50 + 21", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "5 * 5 + 5", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "11 * 11", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "2 ^ 4", Placeholder = "Kirjuta siin"},
                      new EntryCell{Label = "1 + 3 - 2", Placeholder = "Kirjuta siin"},    
                    }
                },
                Intent = TableIntent.Settings
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl, tableView, btn }
            };
            Content = stackLayout;
        }

        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Neljapaev());
        }
    }
}
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
    public partial class Kolmapaev : ContentPage
    {
        Label lbl;
        public Kolmapaev()
        {
            Title = "Kolmapäev";
            lbl = new Label()
            {
                Text = "Kolmapäev",
            };
            StackLayout stackLayout = new StackLayout()
            {
                Children = { lbl }
            };
            Content = stackLayout;
        }
    }
}
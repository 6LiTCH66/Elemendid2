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
        Button btn, btn1, btn2, btn3, btn4, btn5, btn6;
        StackLayout stack;
        Button[] btns = new Button[7];

        public MainPage()
        {
            stack = new StackLayout();
            btn = new Button()
            {
                Text = "Esmaspäev",
            };
            btn.Clicked += Btn_Clicked;

            for (int i = 0; i < 7; i++)
            {
                btns[i] = new Button() { Text = "new",};

                stack.Children.Add(btns[i]);
            };

            Content = stack;

            StackLayout stackLayout = new StackLayout()
            {
                Children = { btn }
            };
            Content = stackLayout;
        }

        


        private async void Btn_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Esmaspäev());
        }
    }
}

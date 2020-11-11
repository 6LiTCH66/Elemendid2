using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Elemendid2
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Reede : ContentPage
    {
        float Volume_;
        float Pitch_;
        public Reede()
        {
            InitializeComponent();
            Volume_ = (float)vol.Value;
            Pitch_ = (float)pit.Value;

        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            SpeechOptions setting = new SpeechOptions()
            {
                Volume = Volume_,
                Pitch = Pitch_,
            };
            if(text.Text != null && text.Text != "") { await Xamarin.Essentials.TextToSpeech.SpeakAsync(text.Text, setting); }
            else if(text.Placeholder != null) { await Xamarin.Essentials.TextToSpeech.SpeakAsync(text.Placeholder, setting); }
        }
        private void Slider_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            Volume_ = (float)vol.Value;
        }

        private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
        {
            Pitch_ = (float)pit.Value;
        }

    }
}
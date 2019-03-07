using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace XAMLHello
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class HelloCode : ContentPage
	{
		public HelloCode ()
		{
			InitializeComponent ();
		}
        void OnSliderValueChanged(object sender, ValueChangedEventArgs args)
        {
            SliderValue.Text = ((Slider)sender).Value.ToString("F3");
        }

        async void OnButtonClicked(object sender, EventArgs args)
        {
            var ClickMeButton = (Button)sender;
            await DisplayAlert("Atención",
                $"El botón etiquetado {ClickMeButton.Text} ha sido tocado", "OK");
        }


    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CDos.Practica2
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class MainPage : ContentPage
	{
		public MainPage ()
		{
			InitializeComponent ();
		}

        async private void PracticaStatic(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica2.Ejercicio1());
        }

        async private void PracticaDataB(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica2.Ejercicio2());
        }
    }
}
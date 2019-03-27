using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CDos.Practica1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void PracticaGrid(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica1.Ejercicio1());
        }

        async private void PracticaProp(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica1.Ejercicio2());
        }

        async private void PracticaEXT(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica1.Ejercicio3());
        }
    }
}
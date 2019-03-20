using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CDos
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        async private void PracticaUno(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Practica1.MainPage());
        }
    }
}

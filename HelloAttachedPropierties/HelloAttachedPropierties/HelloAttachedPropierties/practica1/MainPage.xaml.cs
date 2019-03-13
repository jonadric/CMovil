using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace HelloAttachedPropierties
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        async private void PracticaGrid(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new practica1.PageGrids());
        }
        
    }
}

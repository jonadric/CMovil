using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace UIWithCS
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnTapMe_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Mensaje informativo", "Has tocado el botón!", "OK");
        }
    }
}

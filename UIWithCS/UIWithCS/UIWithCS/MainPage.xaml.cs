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

         public void clicker(object sender, EventArgs e)
        {
             DisplayAlert("Alert", "Has tocado el botón!", "OK");
        }
        public void clicker1(object sender, EventArgs e)
        {
            DisplayAlert("Alert", "Has tocado el botón!", "OK");
        }
    }
}

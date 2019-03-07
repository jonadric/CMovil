using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XAMLHello
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();

            Button NavigateButton = new Button
            {
                Text = "¡Navegar!",
                HorizontalOptions = LayoutOptions.Center,
                VerticalOptions = LayoutOptions.Center
            };

            NavigateButton.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new HelloCode());

            };

            Content = NavigateButton;

        }
    }
}

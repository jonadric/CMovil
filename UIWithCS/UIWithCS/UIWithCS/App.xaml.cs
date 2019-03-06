using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace UIWithCS
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var Content = new ContentPage
            {
                Title = "Hola Xamarin.Forms con C#",
                Content = new StackLayout
                {
                    Orientation = StackOrientation.Vertical,
                    Padding = new Thickness(10),
                    VerticalOptions = LayoutOptions.Center,
                    Children =
                    {
                        new Label
                        {
                            HorizontalTextAlignment = TextAlignment.Center,
                            
                         
                            Text = "Mi nombre es Jonnathan Astroz!"
                        },
                        new Button
                        {
                            Text = "Toca aquí",
                            Margin = new Thickness(0, 10, 0, 0)
                        }
                    }
                }
            };
            MainPage = Content;
        }


        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

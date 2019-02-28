using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;

namespace AndroidApp
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            /* Creamos la instancia del código compartido 
             * y le inyectamos la dependencia. */
            var Validator =
               new NETStandardProject.AppValidator(new AndroidDialog(this));
            /* Aquí podríamos establecer los valores de las propiedades 
             * EMail, Password y Device*/

            // Realizamos la validación 
            Validator.Validate();

            // Set our view from the "main" layout resource 
            SetContentView(Resource.Layout.activity_main);
        }

    }
}
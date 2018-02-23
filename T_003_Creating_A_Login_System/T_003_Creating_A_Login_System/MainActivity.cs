using Android.App;
using Android.Widget;
using Android.OS;

namespace T_003_Creating_A_Login_System
{
    [Activity(Label = "T_003_Creating_A_Login_System", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
               // this is the main
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

        }
    }
}


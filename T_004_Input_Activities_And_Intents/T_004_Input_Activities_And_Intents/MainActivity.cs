using Android.App;
using Android.Widget;
using Android.OS;

namespace T_004_Input_Activities_And_Intents
{
    [Activity(Label = "T_004_Input_Activities_And_Intents", MainLauncher = true)]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
        }
    }
}


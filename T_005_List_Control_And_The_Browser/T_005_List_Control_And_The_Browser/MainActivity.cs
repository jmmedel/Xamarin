using Android.App;
using Android.Widget;
using Android.OS;

namespace T_005_List_Control_And_The_Browser
{
    [Activity(Label = "T_005_List_Control_And_The_Browser", MainLauncher = true)]
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


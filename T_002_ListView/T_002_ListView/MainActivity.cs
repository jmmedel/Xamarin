using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace T_002_ListView
{
    [Activity(Label = "T_002_ListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<string> mitems;
        private ListView mlistviews;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mlistviews = FindViewById<ListView>(Resource.Id.MyListview);

            mitems = new List<string>();
            mitems.Add("John");
            mitems.Add("Medel");
            mitems.Add("Kagaya");
            // the default listview
            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mitems);
            // call created mylistView class to make use your listview
            MyListview adapter = new MyListview(this, mitems);
            mlistviews.Adapter = adapter;

        }
    }
}


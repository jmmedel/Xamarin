using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace T_001_Hello_Worlds
{
    [Activity(Label = "T_001_Hello_Worlds", MainLauncher = true)]
    public class MainActivity : Activity
    {   // how to make a List view the first program to use

        private List<string> myItem;
        // create listview
        private ListView mlistView;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            // create your own array
            myItem = new List<string>();
            // find the id of a list view in main. axml
            mlistView = FindViewById<ListView>(Resource.Id.MyListView);
            myItem.Add("Kagaya");
            myItem.Add("Medel");
            myItem.Add("John");
            ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, myItem);
            mlistView.Adapter = adapter;
           


        }
    }
}


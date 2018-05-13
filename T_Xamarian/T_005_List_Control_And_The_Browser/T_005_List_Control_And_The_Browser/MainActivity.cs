using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;

namespace T_005_List_Control_And_The_Browser
{
    [Activity(Label = "T_005_List_Control_And_The_Browser", MainLauncher = true)]
    public class MainActivity : ListActivity
    {

        // setup an array of strings for my list 
        string[] items;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            items = new string[] { "Shirts", "Pants", "Shoes", "Coats", "Hats" };
            ListAdapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, items);


        }

        protected override void OnListItemClick(ListView l, View v, int position, long id)
        {
            // this is the selected item
            var item = items[position];
            // this shows a toas popup of the item text
            Android.Widget.Toast.MakeText(this, item, ToastLength.Short).Show();

            var uri = Android.Net.Uri.Parse("www.google.com/#q=" + item);
            //setup an intent so i can activate the activity which will lanuch the broser
            var intent = new Android.Content.Intent(Android.Content.Intent.ActionView, uri);
            StartActivity(Intent);
        }

    }
}


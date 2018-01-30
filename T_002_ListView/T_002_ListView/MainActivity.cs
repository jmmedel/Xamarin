using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace T_002_ListView
{
    [Activity(Label = "T_002_ListView", MainLauncher = true)]
    public class MainActivity : Activity
    {
        private List<Person> mitems;
        private ListView mlistviews;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);
            mlistviews = FindViewById<ListView>(Resource.Id.MyListview);
            // create a Person obj to add to the mitems
            mitems = new List<Person>();
           
            Person john = new Person();
            john.FirstName = "John";
            john.LastName = "Kagaya";
            john.Gender = "Male";
            john.Age = 24;
            mitems.Add(john);
            // the default listview
            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mitems);
            // call created mylistView class to make use your listview
            MyListview adapter = new MyListview(this, mitems);
            mlistviews.Adapter = adapter;

        }
    }
}


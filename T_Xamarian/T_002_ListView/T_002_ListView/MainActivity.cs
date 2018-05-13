using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

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
            Person john2 = new Person();
            john2.FirstName = "Jh";
            john2.LastName = "medel";
            john2.Gender = "Male";
            john2.Age = 21;
            mitems.Add(john2);
            Person john3 = new Person();
            john3.FirstName = "John";
            john3.LastName = "Med";
            john3.Gender = "Male";
            john3.Age = 18;
            mitems.Add(john3);
            // the default listview
            //ArrayAdapter<string> adapter = new ArrayAdapter<string>(this, Android.Resource.Layout.SimpleListItem1, mitems);
            // call created mylistView class to make use your listview
            MyListview adapter = new MyListview(this, mitems);
            mlistviews.Adapter = adapter;
            mlistviews.ItemClick += mlistviews_ItemClick;
            mlistviews.ItemLongClick += mlistviews_ItemLongClick;

        }

        private void mlistviews_ItemLongClick(object sender, AdapterView.ItemLongClickEventArgs e)
        {   // testing to see of the event is working
            Console.WriteLine(mitems[e.Position].LastName);
        }

        private void mlistviews_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {   // testing to see of the event is working
            Console.WriteLine(mitems[e.Position].FirstName);
        }
    }
}


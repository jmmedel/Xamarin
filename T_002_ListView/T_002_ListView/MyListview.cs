using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace T_002_ListView
{   // inhereting to the base Adapter
    class MyListview : BaseAdapter<Person>
    {
        private List<Person> mitems;
        private Context mcontext;
        public MyListview(Context context, List<Person> items)
        {
            mitems = items;
            mcontext = context;
        }
        public override Person this[int position] { get => mitems[position]; }

        public override int Count => mitems.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            // if is null
            if (row == null)
            {
                row = LayoutInflater.From(mcontext).Inflate(Resource.Layout.ListView_row_Layout, null, false);

            }
            TextView First_name = row.FindViewById<TextView>(Resource.Id.First_Name);
            First_name.Text = mitems[position].FirstName;

            TextView Last_name = row.FindViewById<TextView>(Resource.Id.Last_Name);
            Last_name.Text = mitems[position].LastName;

            TextView Agetxt = row.FindViewById<TextView>(Resource.Id.Age);
            Agetxt.Text = mitems[position].Age.ToString();

            TextView Gendertxt = row.FindViewById<TextView>(Resource.Id.Gender);
            Gendertxt.Text = mitems[position].Gender;


            return row;
        }
    }
}
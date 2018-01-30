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
    class MyListview : BaseAdapter<string>
    {
        private List<string> mitems;
        private Context mcontext;
        public MyListview(Context context, List<string> items)
        {
            mitems = items;
            mcontext = context;
        }
        public override string this[int position] => mitems[position];

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
            TextView txtname = row.FindViewById<TextView>(Resource.Id.txtName);
            txtname.Text = mitems[position];
            return row;
        }
    }
}
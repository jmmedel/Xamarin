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

namespace T_004_Input_Activities_And_Intents
{
    [Activity(Label = "UserDisplayActivity")]
    public class UserDisplayActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.UserDisplay);
            TextView name = FindViewById<TextView>(Resource.Id.NametextLabel);
            name.Text = UserData.Name;
            TextView date = FindViewById<TextView>(Resource.Id.BirthdatetextLabel);
            date.Text = UserData.Birthdate.ToShortDateString();


        }
    }
}
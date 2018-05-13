using Android.App;
using Android.Widget;
using Android.OS;
using System;
using Android.Content;

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

            Button button = FindViewById<Button>(Resource.Id.button1);
            button.Click += Button_Click;
        }

        private void Button_Click(object sender, System.EventArgs e)
        {
            EditText name = FindViewById<EditText>(Resource.Id.NameBox);
            UserData.Name = name.Text;

            CalendarView date = FindViewById<CalendarView>(Resource.Id.datePicker1);
            date.DateChange += Date_DateChange;

            // open the new Activity;
            // intents setup a new intent 

            var intent = new Intent(this, typeof(UserDisplayActivity));
            StartActivity(intent);
        }

        private void Date_DateChange(object sender, CalendarView.DateChangeEventArgs e)
        {
            UserData.Birthdate = new DateTime(e.Year, e.Month, e.DayOfMonth);

        }
    }
}


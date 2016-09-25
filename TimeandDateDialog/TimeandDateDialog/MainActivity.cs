using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace TimeandDateDialog
{
    [Activity(Label = "TimeandDateDialog", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        //DATE Picker
        private const int DATE_DIALOG_ID = 0;
        DateTime dateTime;
        TextView textView1;


        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            textView1 = FindViewById<TextView>(Resource.Id.textView1);

            dateTime = DateTime.Now;
            textView1.Text = string.Format("{0}-{1}-{2}",
                dateTime.Year, dateTime.Month, dateTime.Day);

           

            button1.Click += ButtonClick1;
        }

        private void ButtonClick1(object sender, EventArgs e)
        {
            ShowDialog(DATE_DIALOG_ID);
        }

        protected override Dialog OnCreateDialog(int id)
        {
            switch(id)
            {
                case DATE_DIALOG_ID:
                var dialog=new DatePickerDialog(this,DatePickerDataSet,
                    dateTime.Year,dateTime.Month-1,dateTime.Day);
                return dialog;
            }
            return null;
        }

        private void DatePickerDataSet(object sender, DatePickerDialog.DateSetEventArgs e)
        {
            this.dateTime = e.Date;
            textView1.Text = string.Format("{0}-{1}-{2}",
                dateTime.Year, dateTime.Month, dateTime.Day);
        }
    }
}


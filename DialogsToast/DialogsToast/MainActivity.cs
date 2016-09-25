using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;

namespace DialogsToast
{
    [Activity(Label = "DialogsToast", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        int count = 1;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            var button1 = FindViewById<Button>(Resource.Id.button1);
            var button2 = FindViewById<Button>(Resource.Id.button2);
            var button3 = FindViewById<Button>(Resource.Id.button3);

            button1.Click += AlertClick1;
            button2.Click += AlertClick2;
            button3.Click+=AlertClick3;

        }

       
        private void AlertClick1(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder builder = new AlertDialog.Builder(this);
            AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle("Alert Title");
            alertDialog.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            alertDialog.SetMessage("This is a sample message");
            alertDialog.SetButton("OK", (s, ev) =>
                {
                    //Do Something
                    //Only one Button Show
                });
            alertDialog.Show();

        }
        private void AlertClick3(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder builder = new AlertDialog.Builder(this);
            AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle("Alert Title");
            alertDialog.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            alertDialog.SetMessage("This is a sample message");
          //YES
            alertDialog.SetButton("YES",
                (s, ev) =>
            {
                //Do Something
                //Only one Button Show
            });
            alertDialog.SetButton("No",
               (s, ev) =>
               {
                   //Do Something
                   //Only one Button Show
               });
            alertDialog.Show();
        }



        private void AlertClick2(object sender, EventArgs e)
        {
            Android.App.AlertDialog.Builder builder = new AlertDialog.Builder(this);
            AlertDialog alertDialog = builder.Create();
            alertDialog.SetTitle("Alert Title");
            alertDialog.SetIcon(Android.Resource.Drawable.IcDialogAlert);
            alertDialog.SetMessage("This is a sample message");
            //YES
            alertDialog.SetButton("YES",
                (s, ev) =>
                {
                    //Do Something
                    //Only one Button Show
                });
            alertDialog.SetButton("No",
               (s, ev) =>
               {
                   //Do Something
                   //Only one Button Show
               });
            alertDialog.SetButton("Cancel",
             (s, ev) =>
             {
                 //Do Something
                 //Only one Button Show
             });
            alertDialog.Show();
        }

    }
}


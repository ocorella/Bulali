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

namespace BulaliX
{
    [Activity(Label = "MenuActivity", MainLauncher = true)]
    public class MenuActivity : Activity
    {
        private Button orderButton;
        private Button cartButton;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.MainMenu);
            FindViews();
            HandleEvents();
         }

        private void FindViews() {
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
            cartButton = FindViewById<Button>(Resource.Id.cartButton);
        }

        private void HandleEvents() {
            orderButton.Click += OrderButton_Click;
        }

        private void OrderButton_Click(object sender, EventArgs e) {
            var intent = new Intent(this, typeof(ProductMenuActivity));
            StartActivity(intent);
        }
    }
}
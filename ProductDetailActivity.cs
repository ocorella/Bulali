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
using Bulali.Core.Model;
using Bulali.Core.Service;

namespace BulaliX
{
[Activity(Label = "Product Detail", MainLauncher = false)]
    public class ProductDetailActivity : Activity
    {
        private ImageView productImageView;
        private TextView productNameTextView;
        private TextView shortDescriptionTextView;
        private TextView descriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
        private Button cancelButton;
        private Button orderButton;

        private Product selectedProduct;
        //private ProductDataServcie dataService;



        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ProductDetailView);

            ProductDataServcie dataService = new ProductDataServcie();
            selectedProduct = dataService.GetProductById(1);

            FindViews();
            BindData();
            HandleEvents();
        }

        private void FindViews() {
            productImageView = FindViewById<ImageView>(Resource.Id.productImageView);
            productNameTextView = FindViewById<TextView>(Resource.Id.productNameTextView);
            shortDescriptionTextView = FindViewById<TextView>(Resource.Id.shortDescriptionTextView);
            descriptionTextView = FindViewById<TextView>(Resource.Id.descriptionTextView);
            priceTextView = FindViewById<TextView>(Resource.Id.priceTextView);
            amountEditText = FindViewById<EditText>(Resource.Id.amountEditText);
            cancelButton = FindViewById<Button>(Resource.Id.cancelButton);
            orderButton = FindViewById<Button>(Resource.Id.orderButton);
        }

        private void BindData() {
            productNameTextView.Text = selectedProduct.Name;
            shortDescriptionTextView.Text = selectedProduct.ShortDescription;
            descriptionTextView.Text = selectedProduct.Description;
            priceTextView.Text = "Price: " + selectedProduct.Price;
        }

        private void HandleEvents() {
            orderButton.Click += OrderButton_Click;
           // cancelButton.Click += CancelButton_Click;
        }

        /*private void CancelButton_Click {

        }*/

        private void OrderButton_Click(object sender, EventArgs e) {
            var amount = Int32.Parse(amountEditText.Text);

            var dialog = new AlertDialog.Builder(this);
            dialog.SetTitle("Confirmation");
            dialog.SetMessage("Your product has been added!");
            dialog.Show();
        }
    }
}
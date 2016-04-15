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
using Bulali.Core.Service;
using Bulali.Core.Model;
using BulaliX.Adapters;

namespace BulaliX
{
    [Activity(Label = "ProductMenuActivity", MainLauncher = false)]
    public class ProductMenuActivity : Activity
    {
        private ListView productListView;
        private List<Product> allProducts;
        private ProductDataServcie productDataService;
        protected override void OnCreate(Bundle savedInstanceState)

        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ProductMenuView);

            productListView = FindViewById<ListView>(Resource.Id.productListView);

            productDataService = new ProductDataServcie();

            allProducts = productDataService.GetAllProducts();

            productListView.Adapter = new ProductListAdapter(this, allProducts);

            productListView.FastScrollEnabled = true;
        }
    }
}
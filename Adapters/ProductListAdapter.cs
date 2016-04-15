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

namespace BulaliX.Adapters
{
    public class ProductListAdapter:BaseAdapter<Product>
    {
        List<Product> items;
        Activity context;

        public ProductListAdapter(Activity context, List<Product> items) : base() {
            this.context = context;
            this.items = items;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override Product this[int position] {
            get {
                return items[position];
            }
        }

        public override int Count {
            get {
                return items.Count;
            }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var item = items[position];

            if (convertView == null) {
                convertView = context.LayoutInflater.Inflate(Android.Resource.Layout.ActivityListItem, null); // SipleListItem1 templates, Activity List Items para ponerle imagen
            }
            convertView.FindViewById<TextView>(Android.Resource.Id.Text1).Text = item.Name;
            return convertView;
        }

    }
}
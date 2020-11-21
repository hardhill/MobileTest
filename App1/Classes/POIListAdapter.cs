using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace App1.Classes
{
    class POIListAdapter : BaseAdapter<PointofInterest>
    {
        private readonly Activity context;
        List<PointofInterest> poiListData;
        public POIListAdapter(Activity _context,List<PointofInterest> _poiListData):base()
        {
            this.context = _context;
            this.poiListData = _poiListData;
        }
        public override long GetItemId(int position)
        {
            return position;
        }

        public override int Count => poiListData.Count;

        public override PointofInterest this[int position] => poiListData[position];

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.activity_listitem, null);
            }
            return view;
        }
    }
}
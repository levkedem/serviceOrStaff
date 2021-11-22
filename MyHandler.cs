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

namespace serviceOrStaff
{
    class MyHandler:Handler
    {
        int couner = 0;
        Context context;
        public MyHandler(Context context)
        {
            this.context = context;
        }
        public override void HandleMessage(Message msg)
        {
            Toast.MakeText(context, "" + msg.Arg1, ToastLength.Long).Show();
        }
    }
}
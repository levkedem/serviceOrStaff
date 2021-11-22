using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using Android.Content;

namespace serviceOrStaff
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : AppCompatActivity
    {
        Button bstart, bstop;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);
            bstart = (Button)FindViewById(Resource.Id.btStart);
            bstop = (Button)FindViewById(Resource.Id.btStop);

            bstart.Click += Bstart_Click;
            bstop.Click += Bstop_Click;
        }

        private void Bstop_Click(object sender, System.EventArgs e)
        {
            Intent intent = new Intent(this, typeof(MyService));
            StopService(intent);
        }

        
        private void Bstart_Click(object sender, System.EventArgs e)
        {
            Intent intent1 = new Intent(this, typeof(MyService));
            intent1.PutExtra("counter", 5);
            StartService(intent1);
        }
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }
    }
}
using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections;

namespace ListActivity_ArrayAdapter
{
    [Activity(Label = "ListView ArrayAdapter", MainLauncher = true, Icon = "@drawable/simplesmile")]
    public class MainActivity : Activity
    {

        ListView lv;
        ArrayAdapter adapter;
        ArrayList players;

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            //REFERENCE
            lv = FindViewById<ListView>(Resource.Id.lv);

            //FILL DATA
            getData();

            //ADAPTER

            adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, players);
            lv.Adapter = adapter;

            lv.ItemClick += lv_ItemClick;
           
        }

        void lv_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, players[e.Position].ToString(), ToastLength.Short).Show();
        }

        private void getData()
        {
            players = new ArrayList();

            //ADD SOME DATA
            players.Add("Juan Mata");
            players.Add("Jesus Navas");
            players.Add("John Barnes");
            players.Add("John Doe");
            players.Add("Joel CampBell");
            players.Add("John Moh");
            players.Add("Jose Mou");
            players.Add("Joe Aurorah");

        }

    }
}


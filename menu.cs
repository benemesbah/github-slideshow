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
 
namespace MaisonAndroid
{
    [Activity(Label = "menu")]
    public class menu : Activity
    
{
         

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            SetContentView(Resource.Layout.menu);

            string name = Intent.GetStringExtra("sd" ?? "Not recv");
            // Create your application here


            Button Pchambre;
            Button Gchambre;
            Button SDbain;
            Button couloir;
            Button Sallon;
            Button Couloir;
            Button Cuisine;
            Button Toilette;
           

           
            Pchambre = FindViewById<Button>(Resource.Id.Pchambre);
            Gchambre = FindViewById<Button>(Resource.Id.Gchambre);
            SDbain = FindViewById<Button>(Resource.Id.SDbain);
            couloir = FindViewById<Button>(Resource.Id.Couloir);
            Sallon = FindViewById<Button>(Resource.Id.Sallon);
            Couloir = FindViewById<Button>(Resource.Id.Couloir);
            Cuisine = FindViewById<Button>(Resource.Id.Cuisine);
            Toilette = FindViewById<Button>(Resource.Id.Toilette);
            TextView Nom = (TextView)FindViewById(Resource.Id.Nom);
            Nom.Text = name;

            if (Nom.Text == "VOLET")
                {
                    SDbain.Visibility = ViewStates.Invisible;
                    Toilette.Visibility = ViewStates.Invisible;

                Pchambre.Click += (sender, e) =>
                   {
                    string sd;
                    sd = Pchambre.Text;
                    var Frame = new Intent(this, typeof(Volet));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                    };

                Gchambre.Click += (sender, e) =>
                   {
                    string sd;
                    sd = Gchambre.Text;
                    var Frame = new Intent(this, typeof(Volet));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                   };
                Sallon.Click += (sender, e) =>
                {
                    string sd;
                    sd = Sallon.Text;
                    var Frame = new Intent(this, typeof(Volet));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

                Cuisine.Click += (sender, e) =>
                {
                    string sd;
                    sd = Cuisine.Text;
                    var Frame = new Intent(this, typeof(Volet));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

            }

            if (Nom.Text == "ELECTRICITE")
            {

                Pchambre.Click += (sender, e) =>
            {
                string sd;
                sd = Pchambre.Text;
                var Frame = new Intent(this, typeof(Chambre));
                Frame.PutExtra("sd", sd);
                StartActivity(Frame);
            };

                Gchambre.Click += (sender, e) =>
               {
                   string sd;
                   sd = Gchambre.Text;
                   var Frame = new Intent(this, typeof(Chambre));
                   Frame.PutExtra("sd", sd);
                   StartActivity(Frame);
               };


                SDbain.Click += (sender, e) =>
                {
                    string sd;
                    sd = SDbain.Text;
                    var Frame = new Intent(this, typeof(Chambre));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };


                couloir.Click += (sender, e) =>
               {
                   string sd;
                   sd = couloir.Text;
                   var Frame = new Intent(this, typeof(Chambre));
                   Frame.PutExtra("sd", sd);
                   StartActivity(Frame);
               };



                Sallon.Click += (sender, e) =>
                {
                    string sd;
                    sd = Sallon.Text;
                    var Frame = new Intent(this, typeof(Chambre));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

                Couloir.Click += (sender, e) =>
                {
                    string sd;
                    sd = Couloir.Text;
                    var Frame = new Intent(this, typeof(Chambre));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

                Cuisine.Click += (sender, e) =>
                {
                    string sd;
                    sd = Cuisine.Text;
                    var Frame = new Intent(this, typeof(Chambre));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

                Toilette.Click += (sender, e) =>
                {
                    string sd;
                    sd = Toilette.Text;
                    var Frame = new Intent(this, typeof(Chambre));
                    Frame.PutExtra("sd", sd);
                    StartActivity(Frame);
                };

            }
         
        }
       
    }
   
}
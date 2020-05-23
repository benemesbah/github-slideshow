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
    [Activity(Label = "Chambre")]
         public class Chambre : Activity
         {

              protected override void OnCreate(Bundle savedInstanceState)
              {
               Button CMANUEL;
               Button CAUTO;
               Button ON;
               Button OFF;
               Button ALLUME;
               Button ETTIENDRE;
               base.OnCreate(savedInstanceState);
               SetContentView(Resource.Layout.Chambre);
               string name = Intent.GetStringExtra("sd" ?? "Not recv");

            ImageView Rouge = FindViewById<ImageView>(Resource.Id.imageView1);
            ImageView  blue = FindViewById<ImageView>(Resource.Id.imageView2);
            TextView Nom = (TextView)FindViewById(Resource.Id.Nom);
               Nom.Text = name;

            

            if (Nom.Text == "Pchambre")
                     {
               
                     CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                     CMANUEL.Click += (sender, e) =>
                     {

                     //string   CMonte = "@00WD00300100";
                     string CMonte = null;
                    CMonte = "@00WD00300400";
                     //CMonte = "@00WD00060FFF";
                     string[] myargs = { CMonte, "arg2", "arg3" };
                     dynamic mytest = new MainActivity.testclass();
                     mytest.calfsc(myargs);
                     };

                     CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                     CAUTO.Click += (sender, e) =>
                     {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300401";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    };

                    ON = FindViewById<Button>(Resource.Id.Con);
                    ON.Click += (sender, e) =>
                    {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080401";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                        blue.Visibility = ViewStates.Visible ;
                        Rouge.Visibility = ViewStates.Invisible ;
                    };
                    OFF = FindViewById<Button>(Resource.Id.Coff);
                    OFF.Click += (sender, e) =>
                    {

                        //string   CMonte = "@00WD00300100";
                        string CMonte = null;

                    CMonte = "@00WD00080400";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                        Rouge.Visibility = ViewStates.Visible;
                        blue.Visibility = ViewStates.Invisible ;
                    };
                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME .Click += (sender, e) =>
                {

                    
                    string CMonte = null;

                    
                    CMonte = "@00WD00100301";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE );
                ETTIENDRE .Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    //CMonte = "@00WD00310300";
                    CMonte = "@00WD00100300";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

            }
            if (Nom.Text == "Toilette")
            {
                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300600";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300601";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080601";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080600";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

              
            }
            if (Nom.Text == "Sallon")
            {
                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300100";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300101";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080101";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080100";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };
                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100001";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE);
                ETTIENDRE.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100000";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

            }
            if (Nom.Text == "Couloir")
            {
                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE);
                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME.Visibility = ViewStates.Invisible;
                ETTIENDRE.Visibility = ViewStates.Invisible;


                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300000";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300001";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080001";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080000";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };


            }
            if (Nom.Text == "Cuisine")
            {
                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300200";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300201";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080201";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080200";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };
                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100101";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE);
                ETTIENDRE.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100100";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

            }
            if (Nom.Text == "Gchambre")
            {
                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300300";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300301";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080301";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080300";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100201";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE);
                ETTIENDRE.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100200";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };
            }
            if (Nom.Text == "Salle de Bain")
            {
                CMANUEL = FindViewById<Button>(Resource.Id.Cmanu);
                CMANUEL.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300500";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                CAUTO = FindViewById<Button>(Resource.Id.Cauto);
                CAUTO.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00300501";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                };

                ON = FindViewById<Button>(Resource.Id.Con);
                ON.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;
                    CMonte = "@00WD00080501";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    blue.Visibility = ViewStates.Visible;
                    Rouge.Visibility = ViewStates.Invisible;
                };
                OFF = FindViewById<Button>(Resource.Id.Coff);
                OFF.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00080500";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ALLUME = FindViewById<Button>(Resource.Id.ALLUMER);
                ALLUME.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100401";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };

                ETTIENDRE = FindViewById<Button>(Resource.Id.ETTIENDRE);
                ETTIENDRE.Click += (sender, e) =>
                {

                    //string   CMonte = "@00WD00300100";
                    string CMonte = null;

                    CMonte = "@00WD00100400";
                    string[] myargs = { CMonte, "arg2", "arg3" };
                    dynamic mytest = new MainActivity.testclass();
                    mytest.calfsc(myargs);
                    Rouge.Visibility = ViewStates.Visible;
                    blue.Visibility = ViewStates.Invisible;
                };
            }

        }
    }
}

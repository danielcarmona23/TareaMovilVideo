using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using VideoMovil.View;
using VideoMovil.Models;
using System.IO;

namespace VideoMovil

{
    public partial class App : Application
    {

        static bd database;
        public static bd BaseDatos
        {
            get
            {
                if (database == null)
                {
                    database = new bd(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Mydatabase.db3"));
                }

                return database;
            }


        }

        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
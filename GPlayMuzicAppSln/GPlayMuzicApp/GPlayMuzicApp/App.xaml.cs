﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace GPlayMuzicApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

           var navPage = new NavigationPage(new MainPage());
            navPage.BarBackgroundColor = Color.Black;
            navPage.BarTextColor = Color.White;
            MainPage = navPage;

        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}

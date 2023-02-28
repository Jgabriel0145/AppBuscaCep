﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using AppBuscaCep.Views;

namespace AppBuscaCep
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new BairrosPorCidade());
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

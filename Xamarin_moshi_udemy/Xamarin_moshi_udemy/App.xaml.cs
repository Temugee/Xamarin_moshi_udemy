using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_moshi_udemy
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Exercise2();
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

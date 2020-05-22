using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Laboratorium5.Services;
using Laboratorium5.Views;

namespace Laboratorium5
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new NavigationPage(new zad2Page1());
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

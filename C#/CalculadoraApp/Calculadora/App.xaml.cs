using Calculadora.Services;
using Calculadora.ViewModels;
using Calculadora.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Calculadora
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new AppShell();
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

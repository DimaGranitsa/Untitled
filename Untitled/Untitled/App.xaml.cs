using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Untitled.pages;

namespace Untitled
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new main_page();
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

using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Lab6
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            var tabbedPage = new TabbedPage();

            tabbedPage.Children.Add(new TabPage1());
            tabbedPage.Children.Add(new TabPage2());

            MainPage = tabbedPage;


            //var mainPage = new MainPage();
            //var navPage = new NavigationPage(mainPage);
            //MainPage = navPage;
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

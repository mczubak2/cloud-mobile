using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab3
{
    public partial class App : Application
    {
        public App()
        {
            var clientHandler = new HttpClientHandler();
            clientHandler.ServerCertificateCustomValidationCallback += (sender, certificate, chain, sslPolicyErrors) =>
            {
                return true;
            };
            var client = RestEase.RestClient.For<IPeopleRepository>(API_URI, clientHandler);
            InitializeComponent();

            MainPage = new MainPage(client);
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

using Matur.Services;
using System;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matur.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        private UserService _service;
        public Login()
        {
            InitializeComponent();
            _service = new UserService();
        }

        private void GoToRegistrar(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrar());
        }

        private async void GoStartPage(object sender, EventArgs e)
        {
            var retorno = await _service.GetUser("", "");
            if (String.IsNullOrEmpty(retorno))
            {
                await DisplayAlert("Resposta", "Erro Variavel retorno nula = "+retorno, "ok");
            }
            else {
                await DisplayAlert("Resposta", retorno, "ok");
                App.Current.MainPage = new NavigationPage(new StartPage());
            }
            

        }
    }
}
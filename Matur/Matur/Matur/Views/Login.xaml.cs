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
            var user = txtUser.Text;
            var password = txtSenha.Text;

            var retorno = await _service.GetUser(user, password);
            if (String.IsNullOrEmpty(retorno)||retorno == "[]")
            {
                await DisplayAlert("Resposta", "Usuário e ou Senha Invalido", "ok");
            }
            else {
                //await DisplayAlert("Resposta", retorno, "ok");
                //App.Current.MainPage = new NavigationPage(new StartPage());
                App.Current.MainPage = new Matur.Views.Paginas.MenuLateral();
            }
            

        }
    }
}
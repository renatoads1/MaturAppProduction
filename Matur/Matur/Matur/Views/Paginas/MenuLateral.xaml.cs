
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Matur.Views.Paginas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuLateral : MasterDetailPage
    {
        public MenuLateral()
        {
            InitializeComponent();
        }

        private void WebsiteMatur(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Pagina1());
            IsPresented = false;
        }

        private void Relatorios(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Pagina2());
            IsPresented = false;
        }

        private void Perfil(object sender, System.EventArgs e)
        {
            Detail = new NavigationPage(new Pagina3());
            IsPresented = false;
        }
    }
}
using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
        }

        private void OnLogoutClicked(object sender, EventArgs e)
        {
            // Redirecionar para a LoginPage
            Application.Current.MainPage = new LoginPage();
        }
    }
}
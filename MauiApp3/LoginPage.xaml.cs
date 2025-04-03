using Microsoft.Maui.Controls;

namespace MauiApp3
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private async void OnLoginButtonClicked(object sender, EventArgs e)
        {
            // Lógica de login estática
            string email = EmailEntry.Text;
            string password = PasswordEntry.Text;

            if (email == "admin" && password == "admin")
            {
                // Navegar para a AppShell após login bem-sucedido
                Application.Current.MainPage = new AppShell();
            }
            else
            {
                await DisplayAlert("Erro", "Email ou senha incorretos", "OK");
            }
        }
    }
}
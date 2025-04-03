using Microsoft.Maui.Controls;
using MauiApp3.Models;
using System;
using System.Threading.Tasks;

namespace MauiApp3.NovaPasta
{
    public partial class PeriodosPage : ContentPage
    {
        public PeriodosPage()
        {
            InitializeComponent();
        }

        private async void OnInsertClicked(object sender, EventArgs e)
        {
            var periodo = new Periodo
            {
                PerNome = PerNomeEntry.Text,
                PerSigla = PerSiglaEntry.Text
            };
            await App.Database.SavePeriodoAsync(periodo);
            await DisplayAlert("Sucesso", "Per�odo inserido com sucesso", "OK");
        }

        private async void OnUpdateClicked(object sender, EventArgs e)
        {
            // Atualizar l�gica aqui
        }

        private async void OnReadClicked(object sender, EventArgs e)
        {
            var periodos = await App.Database.GetPeriodosAsync();
            // Exibir os dados conforme necess�rio
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            // Deletar l�gica aqui
        }
    }
}
using Microsoft.Maui.Controls;
using MauiApp3.Models;
using System;
using System.Threading.Tasks;

namespace MauiApp3.NovaPasta
{
    public partial class DisciplinasPage : ContentPage
    {
        public DisciplinasPage()
        {
            InitializeComponent();
        }

        private async void OnInsertClicked(object sender, EventArgs e)
        {
            var disciplina = new Disciplina
            {
                DisNome = DisNomeEntry.Text,
                DisSigla = DisSiglaEntry.Text,
                DisObservacoes = DisObservacoesEditor.Text,
                CurId = int.Parse(CurIdEntry.Text)
            };
            await App.Database.SaveDisciplinaAsync(disciplina);
            await DisplayAlert("Sucesso", "Disciplina inserida com sucesso", "OK");
        }

        private async void OnUpdateClicked(object sender, EventArgs e)
        {
            // Atualizar lógica aqui
        }

        private async void OnReadClicked(object sender, EventArgs e)
        {
            var disciplinas = await App.Database.GetDisciplinasAsync();
            // Exibir os dados conforme necessário
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            // Deletar lógica aqui
        }
    }
}
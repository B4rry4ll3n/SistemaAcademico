using Microsoft.Maui.Controls;
using MauiApp3.Models;
using System;
using System.Threading.Tasks;

namespace MauiApp3.NovaPasta
{
    public partial class CursosPage : ContentPage
    {
        public CursosPage()
        {
            InitializeComponent();
        }

        private async void OnInsertClicked(object sender, EventArgs e)
        {
            var curso = new Curso
            {
                CurNome = CurNomeEntry.Text,
                CurSigla = CurSiglaEntry.Text,
                CurObservacoes = CurObservacoesEditor.Text,
                PerId = int.Parse(PerIdEntry.Text)
            };
            await App.Database.SaveCursoAsync(curso);
            await DisplayAlert("Sucesso", "Curso inserido com sucesso", "OK");
        }

        private async void OnUpdateClicked(object sender, EventArgs e)
        {
            // Atualizar l�gica aqui
        }

        private async void OnReadClicked(object sender, EventArgs e)
        {
            var cursos = await App.Database.GetCursosAsync();
            // Exibir os dados conforme necess�rio
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            // Deletar l�gica aqui
        }
    }
}
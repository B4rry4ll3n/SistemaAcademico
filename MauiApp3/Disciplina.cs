using SQLite;

namespace MauiApp3.Models
{
    public class Disciplina
    {
        [PrimaryKey, AutoIncrement]
        public int DisId { get; set; }
        public string DisNome { get; set; }
        public string DisSigla { get; set; }
        public string DisObservacoes { get; set; }
        public int CurId { get; set; }
    }
}
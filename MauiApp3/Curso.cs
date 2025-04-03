using SQLite;

namespace MauiApp3.Models
{
    public class Curso
    {
        [PrimaryKey, AutoIncrement]
        public int CurId { get; set; }
        public string CurNome { get; set; }
        public string CurSigla { get; set; }
        public string CurObservacoes { get; set; }
        public int PerId { get; set; }
    }
}
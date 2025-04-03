using SQLite;

namespace MauiApp3.Models
{
    public class Periodo
    {
        [PrimaryKey, AutoIncrement]
        public int PerId { get; set; }
        public string PerNome { get; set; }
        public string PerSigla { get; set; }
    }
}
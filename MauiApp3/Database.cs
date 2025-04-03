using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;
using MauiApp3.Models;

namespace MauiApp3.Data
{
    public class Database
    {
        private readonly SQLiteAsyncConnection _database;

        public Database(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<Periodo>().Wait();
            _database.CreateTableAsync<Curso>().Wait();
            _database.CreateTableAsync<Disciplina>().Wait();
        }

        public Task<List<Periodo>> GetPeriodosAsync()
        {
            return _database.Table<Periodo>().ToListAsync();
        }

        public Task<int> SavePeriodoAsync(Periodo periodo)
        {
            if (periodo.PerId != 0)
            {
                return _database.UpdateAsync(periodo);
            }
            else
            {
                return _database.InsertAsync(periodo);
            }
        }

        public Task<int> DeletePeriodoAsync(Periodo periodo)
        {
            return _database.DeleteAsync(periodo);
        }

        public Task<List<Curso>> GetCursosAsync()
        {
            return _database.Table<Curso>().ToListAsync();
        }

        public Task<int> SaveCursoAsync(Curso curso)
        {
            if (curso.CurId != 0)
            {
                return _database.UpdateAsync(curso);
            }
            else
            {
                return _database.InsertAsync(curso);
            }
        }

        public Task<int> DeleteCursoAsync(Curso curso)
        {
            return _database.DeleteAsync(curso);
        }

        public Task<List<Disciplina>> GetDisciplinasAsync()
        {
            return _database.Table<Disciplina>().ToListAsync();
        }

        public Task<int> SaveDisciplinaAsync(Disciplina disciplina)
        {
            if (disciplina.DisId != 0)
            {
                return _database.UpdateAsync(disciplina);
            }
            else
            {
                return _database.InsertAsync(disciplina);
            }
        }

        public Task<int> DeleteDisciplinaAsync(Disciplina disciplina)
        {
            return _database.DeleteAsync(disciplina);
        }
    }
}
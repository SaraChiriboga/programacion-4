using S14_P4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace S14_P4.Data
{
    public class DataBaseService
    {
        public readonly SQLite.SQLiteAsyncConnection _db;
        public DataBaseService(string dbPath)
        {
            _db = new SQLite.SQLiteAsyncConnection(dbPath);
            _db.CreateTableAsync<Medicamento>().Wait();
        }

        public Task<List<Medicamento>> GetMedicamentosAsync()=>
            _db.Table<Medicamento>().ToListAsync();

        public Task<int> SaveMedicamentoAsync(Medicamento med)=>
            med.Id != 0 ? _db.UpdateAsync(med) : _db.InsertAsync(med);

        public Task<int> DeleteMedicamentoAsync(Medicamento med)=>
            _db.DeleteAsync(med);
    }
}

using BudgetBoo.Data.Entities;
using SQLite;

namespace BudgetBoo.Data.Database
{
    public class DbInitialiser
    {
        private readonly string _dbPath;

        public DbInitialiser(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task InitialiseDatabaseAsync()
        {
            var db = new SQLiteAsyncConnection(_dbPath);

            await db.CreateTableAsync<TransactionEntity>();
        }
    }
}

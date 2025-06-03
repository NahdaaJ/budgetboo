using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBoo.Data.Entities
{
    [Table("Transactions")]
    public class TransactionEntity
    {
        [PrimaryKey, AutoIncrement]
        public int Id { get; set; }

        [NotNull, MaxLength(100)]
        public string Title { get; set; } = string.Empty;

        [NotNull]
        public decimal Amount { get; set; } = 0;

        [NotNull]
        public DateTime Date { get; set; } = DateTime.Now;

        [NotNull]
        public string Category { get; set; } = string.Empty;
    }
}

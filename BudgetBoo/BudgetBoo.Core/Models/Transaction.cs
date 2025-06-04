using BudgetBoo.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBoo.Core.Models
{
    public class Transaction
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0.0m;
        public DateTime Date { get; set; } = DateTime.Now;
        public TransactionCategories Category { get; set; }
    }
}

using BudgetBoo.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBoo.UI.ViewModels
{
    public class TransactionViewModel
    {
        public int Id { get; set; } = 0;
        public string Title { get; set; } = string.Empty;
        public decimal Amount { get; set; } = 0.0m;
        public DateTime Date { get; set; } = DateTime.Now;
        public TransactionCategories Category { get; set; }
        public string CategoryDisplay { get; set; } = string.Empty;
        public Color CategoryDisplayColour { get; set; } = Colors.Gray;
    }
}

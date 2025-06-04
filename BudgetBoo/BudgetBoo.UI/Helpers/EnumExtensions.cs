using BudgetBoo.Core.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BudgetBoo.UI.Helpers
{
    public static class EnumExtensions
    {
        public static string ToDisplayString(this TransactionCategories category)
        {
            return category switch
            {
                TransactionCategories.Housing => "Housing",
                TransactionCategories.Transportation => "Transportation",
                TransactionCategories.Miscellaneous => "Miscellaneous",
                TransactionCategories.Travel => "Travel",
                TransactionCategories.GroceriesAndEssentials => "Groceries & Essentials",
                TransactionCategories.FoodAndDrink => "Food & Drink",
                TransactionCategories.HealthAndFitness => "Health & Fitness",
                TransactionCategories.WorkAndEducation => "Work & Education",
                TransactionCategories.Subscriptions => "Subscriptions",
                TransactionCategories.ShoppingAndLeisure => "Shopping & Leisure",
                TransactionCategories.Financial => "Financial",
                TransactionCategories.FamilyAndRelationships => "Family & Relationships",
                TransactionCategories.SpecialEvents => "Special Events",
                _ => SplitPascalCase(category.ToString())
            };
        }

        public static Color GetCategoryColour(this TransactionCategories category)
        {
            return category switch
            {
                TransactionCategories.Housing => Color.FromArgb("#BC5A5A"),
                TransactionCategories.Transportation => Color.FromArgb("#BC795A"),
                TransactionCategories.Miscellaneous => Color.FromArgb("#BC9A5A"),
                TransactionCategories.Travel => Color.FromArgb("#BCBA5A"),
                TransactionCategories.GroceriesAndEssentials => Color.FromArgb("#7BBC5A"),
                TransactionCategories.FoodAndDrink => Color.FromArgb("#5ABC8E"),
                TransactionCategories.HealthAndFitness => Color.FromArgb("#5A90BC"),
                TransactionCategories.WorkAndEducation => Color.FromArgb("#605ABC"),
                TransactionCategories.Subscriptions => Color.FromArgb("#765ABC"),
                TransactionCategories.ShoppingAndLeisure => Color.FromArgb("#9D5ABC"),
                TransactionCategories.Financial => Color.FromArgb("#BC5ABB"),
                TransactionCategories.FamilyAndRelationships => Color.FromArgb("#BC5A8B"),
                TransactionCategories.SpecialEvents => Color.FromArgb("#BC5A6C"),
                _ => Colors.Gray
            };
        }

        private static string SplitPascalCase(string input)
        {
            return string.Concat(input.Select((x, i) => i > 0 && char.IsUpper(x) ? " " + x : x.ToString()));
        }
    }
}

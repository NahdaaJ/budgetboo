using BudgetBoo.Core.Models.Enum;
using BudgetBoo.UI.Helpers;
using BudgetBoo.UI.ViewModels;
using System.Collections.ObjectModel;

namespace BudgetBoo.UI.ContentPages;

public partial class TransactionPage : ContentView
{
	public ObservableCollection<TransactionViewModel> Transactions { get; set; } = new();
    public TransactionPage()
	{		
		InitializeComponent();

		Transactions.Add(new TransactionViewModel
        {
            Title = "Groceries",
            Amount = 50.00m,
            Date = DateTime.Parse("01/02/96"),
            Category = TransactionCategories.GroceriesAndEssentials,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.GroceriesAndEssentials),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.GroceriesAndEssentials)
        });

        Transactions.Add(new TransactionViewModel
        {
            Title = "Gas",
            Amount = 139.03m,
            Date = DateTime.Parse("02/02/96"),
            Category = TransactionCategories.Transportation,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Transportation),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Transportation)
        });

        Transactions.Add(new TransactionViewModel
        {
            Title = "Restaurant",
            Amount = 745.00m,
            Date = DateTime.Parse("03/02/96"),
            Category = TransactionCategories.FoodAndDrink,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.FoodAndDrink),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.FoodAndDrink)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Gym Membership",
            Amount = 40.04m,
            Date = DateTime.Parse("04/02/96"),
            Category = TransactionCategories.HealthAndFitness,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.HealthAndFitness),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.HealthAndFitness)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Went out for dinner with Trungi",
            Amount = 40.00m,
            Date = DateTime.Parse("04/02/96"),
            Category = TransactionCategories.FoodAndDrink,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.FoodAndDrink),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.FoodAndDrink)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Bought a new phone",
            Amount = 999.99m,
            Date = DateTime.Parse("05/02/96"),
            Category = TransactionCategories.ShoppingAndLeisure,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.ShoppingAndLeisure),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.ShoppingAndLeisure)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Paid rent",
            Amount = 1200.00m,
            Date = DateTime.Parse("06/02/96"),
            Category = TransactionCategories.Housing,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Housing),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Housing)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Bought a new laptop",
            Amount = 1500.00m,
            Date = DateTime.Parse("07/02/96"),
            Category = TransactionCategories.WorkAndEducation,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.WorkAndEducation),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.WorkAndEducation)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Paid for a subscription",
            Amount = 15.99m,
            Date = DateTime.Parse("08/02/96"),
            Category = TransactionCategories.Subscriptions,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Subscriptions),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Subscriptions)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Bought a new book",
            Amount = 20.00m,
            Date = DateTime.Parse("09/02/96"),
            Category = TransactionCategories.ShoppingAndLeisure,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.ShoppingAndLeisure),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.ShoppingAndLeisure)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Paid for a flight",
            Amount = 500.00m,
            Date = DateTime.Parse("10/02/96"),
            Category = TransactionCategories.Travel,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Travel),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Travel)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Paid for a hotel",
            Amount = 300.00m,
            Date = DateTime.Parse("11/02/96"),
            Category = TransactionCategories.Travel,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Travel),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Travel)
        });
        Transactions.Add(new TransactionViewModel
        {
            Title = "Paid for a car repair",
            Amount = 200.00m,
            Date = DateTime.Parse("12/02/96"),
            Category = TransactionCategories.Transportation,
            CategoryDisplay = EnumExtensions.ToDisplayString(TransactionCategories.Transportation),
            CategoryDisplayColour = EnumExtensions.GetCategoryColour(TransactionCategories.Transportation)
        });

        BindingContext = this;
    }

    private void DeleteTransaction(object sender, EventArgs e)
    {
        var button = (ImageButton)sender;
        var transaction = (TransactionViewModel)button.BindingContext;
        Transactions.Remove(transaction);
    }
}
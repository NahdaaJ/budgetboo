using BudgetBoo.UI.ContentPages;

namespace BudgetBoo.UI;

public partial class MainLayout : ContentPage
{
	public MainLayout()
	{
		InitializeComponent();
        MainContent.Content = new TransactionPage();
    }
}
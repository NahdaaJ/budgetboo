using BudgetBoo.Data.Database;
using System.Diagnostics;

namespace BudgetBoo.UI
{
    public partial class App : Application
    {
        public App(IServiceProvider serviceProvider)
        {
            InitializeComponent();
            InitialiseDb(serviceProvider);

            MainPage = new MainLayout();
        }

        private async void InitialiseDb(IServiceProvider services)
        {
            try
            {
                var dbPath = services.GetRequiredService<string>();
                var dbInit = new DbInitialiser(dbPath);
                await dbInit.InitialiseDatabaseAsync();
            }
            catch (Exception ex)
            {
                // Log or display error
                System.Diagnostics.Debug.WriteLine($"DB init failed: {ex.Message}");
            }
        }
    }
    
}

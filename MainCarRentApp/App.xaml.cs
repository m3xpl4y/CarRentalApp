using MainCarRentApp.DbContexts;
using Microsoft.EntityFrameworkCore;
using System.Windows;

namespace MainCarRentApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private const string CONNECTION_STRING = "Data Source = CarRentSystemDB.db";
        //private const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentSystemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        protected override void OnStartup(StartupEventArgs e)
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            ApplicationDbContext context = new ApplicationDbContext(options);
            context.Database.Migrate();
            base.OnStartup(e);
        }
    }
}

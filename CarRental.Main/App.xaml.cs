using CarRental.Main.Data;
using Microsoft.EntityFrameworkCore.Infrastructure;
using System.Windows;

namespace CarRental.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            DatabaseFacade facade = new(new ApplicationDbContext());
            facade.EnsureCreated();
            base.OnStartup(e);
        }
    }
}

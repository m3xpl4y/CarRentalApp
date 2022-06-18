namespace CarRental.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ApplicationDbContext context = new ApplicationDbContext();
            context.Database.Migrate();
            context.Database.EnsureCreated();
            base.OnStartup(e);
        }
    }
}

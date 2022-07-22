using CarRental.Main.Services;
using ICarRental.IMain.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarRental.Main
{
    public partial class App : Application
    {
        public static IHost? AppHost { get; private set; }
        public App()
        {
            AppHost = Host.CreateDefaultBuilder()
                .ConfigureServices((hostContext, services) =>
                {
                    services.AddDbContext<ApplicationDbContext>(options =>
                            options.UseSqlite(ConfigurationManager.ConnectionStrings["ConnectionString"].ToString()));

                    #region WINDOW
                    services.AddSingleton<MainWindow>();
                    #endregion

                    #region REPOSITORIES
                    services.AddScoped<IRepository<Car, int>, CarRepository>();
                    services.AddScoped<IRepository<Client, int>, ClientRepository>();
                    #endregion

                    #region SERVICES
                    services.AddTransient<IService<Client>, TestService>();
                    #endregion

                }).Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            await AppHost!.StartAsync();
            var startUpWindow = AppHost.Services.GetRequiredService<MainWindow>();
            startUpWindow.Show();
            base.OnStartup(e);
        }
        protected override async void OnExit(ExitEventArgs e)
        {
            await AppHost!.StopAsync();
            base.OnExit(e);
        }
    }
}

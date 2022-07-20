using CarRental.Main.Services;
using ICarRental.IMain.IService;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace CarRental.Main
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
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

                    //RepositoryServices(services);
                    services.AddSingleton<MainWindow>();
                    services.AddScoped<IRepository<Car, int>, CarRepository>();
                    services.AddScoped<IRepository<Client, int>, ClientRepository>();
                    services.AddTransient<IService<Client>, TestService>();

                }).Build();
        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            //ApplicationDbContext context = new ApplicationDbContext();
            //context.Database.Migrate();
            //context.Database.EnsureCreated();

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
        private void RepositoryServices(IServiceCollection services)
        {
            services.AddScoped<IRepository<Car, int>, CarRepository>();
            services.AddScoped<IRepository<Client, int>, ClientRepository>();
        }
    }
}

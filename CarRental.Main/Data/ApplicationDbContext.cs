namespace CarRental.Main.Data;
public class ApplicationDbContext : DbContext
{
    string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(CONNECTION_STRING);
    }

    public DbSet<Client> Clients => Set<Client>();
    public DbSet<Body> Bodies => Set<Body>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<CarService> CarServices => Set<CarService>();
    public DbSet<ClientAddress> ClientAddresses => Set<ClientAddress>();
    public DbSet<ClientDriverLicense> ClientDriverLicenses => Set<ClientDriverLicense>();
    public DbSet<ClientInformation> ClientInformations => Set<ClientInformation>();
    public DbSet<ClientPassport> ClientPassports => Set<ClientPassport>();
    public DbSet<ClientPersonalId> ClientPersonalIds => Set<ClientPersonalId>();
    public DbSet<Contract> Contracts => Set<Contract>();
    public DbSet<Discount> Discounts => Set<Discount>();
    public DbSet<EmailSettings> EmailSettings => Set<EmailSettings>();
    public DbSet<Fuel> Fuels => Set<Fuel>();
    public DbSet<Gear> Gears => Set<Gear>();
    public DbSet<OptionalEquipment> OptionalEquipments => Set<OptionalEquipment>();
    public DbSet<Price> Prices => Set<Price>();
    public DbSet<Promotions> Promotions => Set<Promotions>();
    public DbSet<RentDay> RentDays => Set<RentDay>();
    public DbSet<Repairs> Repairs => Set<Repairs>();    
}
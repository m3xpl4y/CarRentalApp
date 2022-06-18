namespace CarRental.Main.Data;
public class ApplicationDbContext : DbContext
{
    string CONNECTION_STRING = ConfigurationManager.ConnectionStrings["ConnectionString"].ToString();
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlite(CONNECTION_STRING);
    }

    public DbSet<Client> Clients { get; set; }
    public DbSet<Body> Bodies { get; set; }
    public DbSet<Car> Cars { get; set; }
    public DbSet<CarService> CarServices { get; set; }
    public DbSet<ClientAddress> ClientAddresses { get; set; }
    public DbSet<ClientDriverLicense> ClientDriverLicenses { get; set; }
    public DbSet<ClientInformation> ClientInformations { get; set; }
    public DbSet<ClientPassport> ClientPassports { get; set; }
    public DbSet<ClientPersonalId> ClientPersonalIds { get; set; }
    public DbSet<Contract> Contracts { get; set; }
    public DbSet<Discount> Discounts { get; set; }
    public DbSet<EmailSettings> EmailSettings { get; set; }
    public DbSet<Fuel> Fuels { get; set; }
    public DbSet<Gear> Gears { get; set; }
    public DbSet<OptionalEquipment> OptionalEquipments { get; set; }
    public DbSet<Price> Prices { get; set; }
    public DbSet<Promotions> Promotions { get; set; }
    public DbSet<RentDay> RentDays { get; set; }
    public DbSet<Repairs> Repairs { get; set; }
}
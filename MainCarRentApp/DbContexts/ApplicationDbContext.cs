using DataModels.Models;
using Microsoft.EntityFrameworkCore;

namespace MainCarRentApp.DbContexts;
public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions options) 
        : base(options)
    {

    }
    public DbSet<Client> Clients { get; set; }
    public DbSet<ClientAddress> ClientAddress { get; set; }
    public DbSet<ClientDriverLicense> ClientDriverLicense { get; set; }
    public DbSet<ClientInformation> ClientInformation { get; set; }
    public DbSet<ClientPassport> ClientPassport { get; set; }
    public DbSet<ClientPersonalId> ClientPersonalId { get; set; }
}

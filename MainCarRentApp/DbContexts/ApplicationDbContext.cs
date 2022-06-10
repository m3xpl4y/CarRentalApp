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
}

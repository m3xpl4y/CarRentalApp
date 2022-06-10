using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;

namespace MainCarRentApp.DbContexts;
public class CarRentDesignTimeDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        DbContextOptions options = new DbContextOptionsBuilder().UseSqlite("Data Source = CarRentSystemDB").Options;
        ApplicationDbContext context = new ApplicationDbContext(options);
        return context;
    }
}

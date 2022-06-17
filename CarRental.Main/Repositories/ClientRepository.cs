using CarRental.Main.Data;
using DataModels.Models;
using ICarRental.IMain.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CarRental.Main.Repositories;
internal class ClientRepository : IRepository<Client, int>
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();
    public async Task Create(Client model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Client model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Client>> GetAll()
    {
        var clients = await _context.Clients
            .Include(x => x.ClientAddress)
            .Include(x => x.ClientInformation)
            .Include(x => x.ClientDriverLicense)
            .Include(x => x.ClientPassport)
            .Include(x => x.ClientPersonalId)
            .ToListAsync();
        return clients;
    }

    public Task<Client> GetbyId(int Id)
    {
        throw new NotImplementedException();
    }

    public Task Update(Client model)
    {
        throw new NotImplementedException();
    }
}

namespace CarRental.Main.Repositories;
public class ClientRepository : BaseRepository, IRepository<Client, int>
{
    private readonly ApplicationDbContext _context;
    public ClientRepository()
    {
        _context = base.Context;
    }
    public async Task Create(Client model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Client model)
    {
        Context.Remove(model);
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

    public async Task<Client> GetbyId(int id)
    {
        var client = await _context.Clients
            .Include(x => x.ClientAddress)
            .Include(x => x.ClientInformation)
            .Include(x => x.ClientDriverLicense)
            .Include(x => x.ClientPassport)
            .Include(x => x.ClientPersonalId)
            .FirstOrDefaultAsync(x => x.Id == id);
        return client;
    }

    public async Task Update(Client model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}
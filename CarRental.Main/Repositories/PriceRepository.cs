namespace CarRental.Main.Repositories;
public class PriceRepository : BaseRepository, IRepository<Price, int>
{
    private readonly ApplicationDbContext _context;
    public PriceRepository()
    {
        _context = Context;
    }

    public async Task Create(Price model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Price model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Price>> GetAll()
    {
        var prices = await _context.Prices
            .ToListAsync();
        return prices;
    }

    public async Task<Price> GetbyId(int id)
    {
        var price = await _context.Prices
            .FirstOrDefaultAsync(x => x.Id == id);
        return price;

    }

    public async Task Update(Price model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

namespace CarRental.Main.Repositories;
public class PromotionRepository : IRepository<Promotions, int>
{
    private readonly ApplicationDbContext _context;
    public PromotionRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Create(Promotions model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Promotions model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Promotions>> GetAll()
    {
        var promotions = await _context.Promotions.ToListAsync();
        return promotions;
    }

    public async Task<Promotions> GetbyId(int id)
    {
        var promotion = await _context.Promotions
            .FirstOrDefaultAsync(x => x.Id == id);
        return promotion;
    }

    public async Task Update(Promotions model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

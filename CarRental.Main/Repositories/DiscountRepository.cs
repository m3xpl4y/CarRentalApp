namespace CarRental.Main.Repositories;
public class DiscountRepository : IRepository<Discount, int>
{
    private readonly ApplicationDbContext _context;
    public DiscountRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Create(Discount model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Discount model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Discount>> GetAll()
    {
        var discounts = await _context.Discounts.ToListAsync();
        return discounts;
    }

    public async Task<Discount> GetbyId(int id)
    {
        var discount = await _context.Discounts
            .FirstOrDefaultAsync(x => x.Id == id);
        return discount;
    }

    public async Task Update(Discount model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

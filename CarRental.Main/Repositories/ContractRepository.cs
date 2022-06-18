namespace CarRental.Main.Repositories;
public class ContractRepository : IRepository<Contract, int>
{
    private readonly ApplicationDbContext _context = new ApplicationDbContext();
    public async Task Create(Contract model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Contract model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Contract>> GetAll()
    {
        return await _context.Contracts.ToListAsync();
    }

    public async Task<Contract> GetbyId(int id)
    {
        var contract = await _context.Contracts
            .FirstOrDefaultAsync(x => x.Id == id);
        return contract;
    }

    public async Task Update(Contract model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

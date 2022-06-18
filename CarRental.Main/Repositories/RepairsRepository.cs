namespace CarRental.Main.Repositories;
public class RepairsRepository : BaseRepository, IRepository<Repairs, int>
{
    private readonly ApplicationDbContext _context;

    public RepairsRepository()
    {
        _context = base.Context;
    }
    public async Task Create(Repairs model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Repairs model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Repairs>> GetAll()
    {
        var repairs = await _context.Repairs
            .Include(x => x.Car.OptionalEquipment)
            .Include(x => x.Car.Fuel)
            .Include(x => x.Car.BodyType)
            .Include(x => x.Car.Gear)
            .Include(x => x.Car.CarService)
            .Include(x => x.Car.Client)
            .Include(x => x.Car.Client.ClientAddress)
            .Include(x => x.Car.Client.ClientInformation)
            .Include(x => x.Car.Client.ClientDriverLicense)
            .Include(x => x.Car.Client.ClientPassport)
            .Include(x => x.Car.Client.ClientPersonalId)
            .ToListAsync();
        return repairs;
    }

    public async Task<Repairs> GetbyId(int id)
    {
        var repair = await _context.Repairs
            .Include(x => x.Car.OptionalEquipment)
            .Include(x => x.Car.Fuel)
            .Include(x => x.Car.BodyType)
            .Include(x => x.Car.Gear)
            .Include(x => x.Car.CarService)
            .Include(x => x.Car.Client)
            .Include(x => x.Car.Client.ClientAddress)
            .Include(x => x.Car.Client.ClientInformation)
            .Include(x => x.Car.Client.ClientDriverLicense)
            .Include(x => x.Car.Client.ClientPassport)
            .Include(x => x.Car.Client.ClientPersonalId)
            .FirstOrDefaultAsync(x => x.Id == id);
        return repair;
    }

    public async Task Update(Repairs model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

namespace CarRental.Main.Repositories;
public class RentDayRepository : IRepository<RentDay, int>
{
    private readonly ApplicationDbContext _context;
    public RentDayRepository(ApplicationDbContext context)
    {
        _context = context;
    }
    public async Task Create(RentDay model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(RentDay model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<RentDay>> GetAll()
    {
        var rentDays = await _context.RentDays
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
        return rentDays;
    }

    public async Task<RentDay> GetbyId(int id)
    {
        var rentDay = await _context.RentDays
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
        return rentDay;
    }

    public async Task Update(RentDay model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

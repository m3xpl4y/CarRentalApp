namespace CarRental.Main.Repositories;
public class CarRepository : BaseRepository, IRepository<Car, int>
{
    private readonly ApplicationDbContext _context;
    public CarRepository()
    {
        _context = base.Context;
    }
    public async Task Create(Car model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(Car model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<Car>> GetAll()
    {
        var cars = await _context.Cars
            .Include(x => x.OptionalEquipment)
            .Include(x => x.Fuel)
            .Include(x => x.BodyType)
            .Include(x => x.Gear)
            .Include(x => x.CarService)
            .Include(x => x.Client)
            .Include(x => x.Client.ClientAddress)
            .Include(x => x.Client.ClientInformation)
            .Include(x => x.Client.ClientDriverLicense)
            .Include(x => x.Client.ClientPassport)
            .Include(x => x.Client.ClientPersonalId)
            .ToListAsync();
        return cars;
    }

    public async Task<Car> GetbyId(int id)
    {
        var car = await _context.Cars
            .Include(x => x.OptionalEquipment)
            .Include(x => x.Fuel)
            .Include(x => x.BodyType)
            .Include(x => x.Gear)
            .Include(x => x.CarService)
            .Include(x => x.Client)
            .Include(x => x.Client.ClientAddress)
            .Include(x => x.Client.ClientInformation)
            .Include(x => x.Client.ClientDriverLicense)
            .Include(x => x.Client.ClientPassport)
            .Include(x => x.Client.ClientPersonalId)
            .FirstOrDefaultAsync(x => x.Id == id);
        return car;
    }

    public async Task Update(Car model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}
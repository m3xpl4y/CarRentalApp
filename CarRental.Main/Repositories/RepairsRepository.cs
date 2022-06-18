namespace CarRental.Main.Repositories;
public class RepairsRepository : BaseRepository, IRepository<Repairs, int>
{
    public async Task Create(Repairs model)
    {
        await Context().AddAsync(model);
        await Context().SaveChangesAsync();
    }

    public async Task Delete(Repairs model)
    {
        Context().Remove(model);
        await Context().SaveChangesAsync();
    }

    public async Task<List<Repairs>> GetAll()
    {
        var repairs = await Context().Repairs
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
        var repair = await Context().Repairs
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
        Context().Update(model);
        await Context().SaveChangesAsync();
    }
}

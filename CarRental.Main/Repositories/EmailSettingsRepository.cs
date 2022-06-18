namespace CarRental.Main.Repositories;
public class EmailSettingsRepository : BaseRepository, IRepository<EmailSettings, int>
{
    private readonly ApplicationDbContext _context;
    public EmailSettingsRepository()
    {
        _context = Context;
    }
    public async Task Create(EmailSettings model)
    {
        await _context.AddAsync(model);
        await _context.SaveChangesAsync();
    }

    public async Task Delete(EmailSettings model)
    {
        _context.Remove(model);
        await _context.SaveChangesAsync();
    }

    public async Task<List<EmailSettings>> GetAll()
    {
        var emailSettings = await _context.EmailSettings.ToListAsync();
        return emailSettings;
    }

    public async Task<EmailSettings> GetbyId(int id)
    {
        var emailSetting = await _context.EmailSettings
            .FirstOrDefaultAsync(x => x.Id == id);
        return emailSetting;
    }

    public async Task Update(EmailSettings model)
    {
        _context.Update(model);
        await _context.SaveChangesAsync();
    }
}

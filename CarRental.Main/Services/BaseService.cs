using ICarRental.IMain.IService;

namespace CarRental.Main.Services;
public class BaseService : IService<Client>
{
    public void CreateNew(Client entity)
    {
        throw new NotImplementedException();
    }

    public Task<List<Client>> GetAll()
    {
        throw new NotImplementedException();
    }
}

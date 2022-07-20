using ICarRental.IMain.IService;

namespace CarRental.Main.Services;
public class TestService : IService<Client>
{
    private readonly IRepository<Client, int> _clientRepository;

    public TestService(IRepository<Client, int> clientRepository)
    {
        _clientRepository = clientRepository;
    }

    public void CreateNew(Client client)
    {
        _clientRepository.Create(client);
    }

    public async Task<List<Client>> GetAll()
    {
        return await _clientRepository.GetAll();
    }
}

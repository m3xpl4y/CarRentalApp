using ICarRental.IMain.IService;

namespace CarRental.Main;

public partial class MainWindow : Window
{
    private readonly IService<Client> _service;

    public MainWindow(IService<Client> service)
    {
        InitializeComponent();
        _service = service;

        CreateNewClient().Wait();
        ReadClients().Wait();
    }
    private async Task CreateNewClient()
    {
        ClientDriverLicense license = new ClientDriverLicense()
        {
            DateOfExpiry = DateTime.Now,
            DateOfIssue = DateTime.Now,
            IssuingAuthority = "Feldkirch",
            DriverLicensNr = "111111111"
        };

        ClientPassport clientPassport = new ClientPassport()
        {
            DateOfExpiry = DateTime.Now,
            DateOfIssue = DateTime.Now,
            IssuingAuthority = "Romania",
            PassportNr = "333333333"
        };
        ClientPersonalId clientPersonalId = new ClientPersonalId()
        {
            DateOfExpiry = DateTime.Now,
            DateOfIssue = DateTime.Now,
            IssuingAuthority = "Romania",
            PersonalIdNumber = "222222"
        };
        ClientAddress clientAddress = new ClientAddress()
        {
            Country = "Östereich",
            Location = "Rankweil",
            StreetNumber = "Schweizerstraße 32",
            ZipCode = "6830"
        };
        ClientInformation clientInformation = new ClientInformation()
        {
            isBlocked = false,
            Notes = "Nichts zu berichten",
            Notice = "alles in ordnung"
        };
        Client client = new Client()
        {
            Salutation = "Herr",
            FirstName = "Maximilian",
            LastName = "Tamasanu",
            BirthDate = DateTime.Now,
            Phone = "069914464747",
            Email = "maex84@gmail.com",
            ClientInformation = clientInformation,
            ClientAddress = clientAddress,
            ClientDriverLicense = license,
            ClientPassport = clientPassport,
            ClientPersonalId = clientPersonalId
        };
        _service.CreateNew(client);
    }
    private async Task ReadClients()
    {
        var clients = await _service.GetAll();
        var test = clients;
    }
}

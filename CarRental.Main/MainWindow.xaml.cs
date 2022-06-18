namespace CarRental.Main
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateNewClient().Wait();
            ReadClients().Wait();
        }
        private readonly ClientRepository _clientRepository = new ClientRepository();
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
            await _clientRepository.Create(client);
        }
        private async Task ReadClients()
        {
            var clients = await _clientRepository.GetAll();
            var test = clients;
        }
    }
}

using DataModels.Models;
using MainCarRentApp.DbContexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MainCarRentApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private const string CONNECTION_STRING = "Data Source=CarRentSystemDb.db";
        //private const string CONNECTION_STRING = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=CarRentSystemDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        public MainWindow()
        {
            InitializeComponent();
            WriteToDb();
            ReadFromDb();
        }
        private void WriteToDb()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            ApplicationDbContext context = new ApplicationDbContext(options);
            var address = new ClientAddress()
            {
                Country = "Austria",
                Location = "Rankweil",
                StreetNumber = "Strasse 12",
                ZipCode = "1235"
            };
            var driverlicense = new ClientDriverLicense()
            {
                DateOfExpiry = DateTime.Now,
                DateOfIssue = DateTime.Now,
                DriverLicensNr = "12345",
                IssuingAuthority = "Countery"
            };
            var clientInfo = new ClientInformation()
            {
                isBlocked = false,
                Notes = "Hallo",
                Notice = "welt"
            };
            var passport = new ClientPassport()
            {
                DateOfExpiry = DateTime.Now,
                DateOfIssue = DateTime.Now,
                IssuingAuthority = "some country",
                PassportNr = "12345",
            };
            var personalId = new ClientPersonalId()
            {
                DateOfExpiry = DateTime.Now,
                DateOfIssue = DateTime.Now,
                IssuingAuthority = "öalksdf",
                PersonalIdNumber = "12345",
            };

            Client client = new Client()
            {
                BirthDate = DateTime.Now,
                ClientAddress = address,
                Email = "test@test.com",
                FirstName = "Max",
                LastName = "Play",
                Phone = "65454654",
                ClientDriverLicense = driverlicense,
                ClientInformation = clientInfo,
                ClientPassport = passport,
                Salutation = "herr",
                ClientPersonalId = personalId
            };
            Debug.WriteLine("client updated" + " " + client.FirstName);
            context.Add(client);
            try
            {
                //context.Database.EnsureCreated();
                context.SaveChanges();
            }
            catch (Exception e)
            {

                Debug.WriteLine("Inside TryCatchBlock: " + e.InnerException.Message);
            }
        }
        private void ReadFromDb()
        {
            DbContextOptions options = new DbContextOptionsBuilder().UseSqlite(CONNECTION_STRING).Options;
            ApplicationDbContext context = new ApplicationDbContext(options);
            var clients = context.Clients
                .Include(x => x.ClientAddress)
                .Include(x => x.ClientPassport)
                .ToList();
            var name = clients[12].FirstName.ToString();
            var id = clients[12].Id.ToString();
            var counter = clients.Count();
            var location = clients[12].ClientAddress.Location.ToString();
            var passport = clients[12].ClientPassport.IssuingAuthority.ToString();
            lbl_Id.Text = id.ToString();
            lbl_Name.Text = name.ToString();
            lbl_counter.Text = counter.ToString();
            lbl_Address.Text = location.ToString();
            lbl_passport.Text = passport.ToString();
        }

    }
}

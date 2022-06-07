using System.ComponentModel.DataAnnotations;

namespace DataModels.Models;

public class Client
{
    public int Id { get; set; }
    [MaxLength(40, ErrorMessage ="Maximal Länge überschritten")]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    public string LastName { get; set; } = string.Empty;
    public DateTime Birthsday { get; set; }
    [Phone]
    public string Phone { get; set; }
    [EmailAddress]
    public string Email { get; set; }
    public ClientDriverLicense ClientDriverLicense { get; set; }
    public ClientPassport? ClientPassport { get; set; }
    public ClientPersonalId? ClientPersonalId { get; set; }
    public ClientAddress ClientAddress{ get; set; }

}

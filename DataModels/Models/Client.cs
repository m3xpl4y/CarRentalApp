namespace DataModels.Models;

public class Client
{
    public int Id { get; set; }
    [MaxLength(40, ErrorMessage ="Maximal Länge überschritten")]
    [Display(Name = "Vorname")]
    public string FirstName { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Nachname")]
    public string LastName { get; set; } = string.Empty;
    [Display(Name = "Geburtsdatum")]
    public DateTime BirthDate { get; set; }
    [Phone]
    [Display(Name = "Telefon")]
    public string Phone { get; set; } = string.Empty;
    [EmailAddress]
    [Display(Name = "E-Mail")]
    public string Email { get; set; } = string.Empty;
    public ClientDriverLicense ClientDriverLicense { get; set; }
    public ClientPassport? ClientPassport { get; set; }
    public ClientPersonalId? ClientPersonalId { get; set; }
    public ClientAddress ClientAddress{ get; set; }
    public ClientInformation ClientInformation { get; set; }
}
namespace DataModels.Models;
public class EmailSettings
{
    public int Id { get; set; }
    [Display(Name = "E-Mail")]
    [EmailAddress]
    public string Email { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Benutzer")]
    public string EmailUsername { get; set; } = string.Empty;
    [Display(Name = "Passwort")]
    public string Password { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Ausgangserver")]
    public string Host { get; set; } = string.Empty;
    [MaxLength(4, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Port")]
    public int Port { get; set; }
    [Display(Name = "SSL")]
    public bool SSL { get; set; }
    [MaxLength(150, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Betreff")]
    public string Subject { get; set; } = string.Empty;
    [Display(Name = "Inhalt")]
    public string EmailContent { get; set; } = string.Empty;
}
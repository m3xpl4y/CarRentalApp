namespace DataModels.Models;

public class ClientPersonalId
{
    public int Id { get; set; }
    [Display(Name = "Personalausweis Nr.")]
    public string PersonalIdNumber { get; set; } = string.Empty;
    [Display(Name = "Ausgestellt durch")]
    public string IssuingAuthority { get; set; } = string.Empty;
    [Display(Name = "Ausstellungsdatum")]
    public DateTime DateOfIssue { get; set; }
    [Display(Name = "Ablaufdatum")]
    public DateTime DateOfExpiry { get; set; }
}
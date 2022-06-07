namespace DataModels.Models;
public class ClientInformation
{
    public int Id { get; set; }
    public bool isBlocked { get; set; }
    [MaxLength(2000, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Vermerk")]
    public string Notice { get; set; } = string.Empty;
    [MaxLength(2000, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Notizen")]
    public string Notes { get; set; } = string.Empty;
}
namespace DataModels.Models;

public class ClientAddress
{
    public int Id { get; set; }
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Straße & Nr.")] 
    public string StreetNumber { get; set; } = string.Empty;
    [MaxLength(5, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "PLZ")]
    public string ZipCode { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Ort")] 
    public string Location { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Land")]
    public string Country { get; set; } = string.Empty;
}
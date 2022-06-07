namespace DataModels.Models;

public class ClientAddress
{
    public int Id { get; set; }
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    public string StreetNumber { get; set; } = string.Empty;
    [MaxLength(5, ErrorMessage = "Maximal Länge überschritten")]
    public string ZipCode { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    public string Location { get; set; } = string.Empty;
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    public string Country { get; set; } = string.Empty;
}
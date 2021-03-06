namespace DataModels.Models;
public class Price
{
    public int Id { get; set; }
    [MaxLength(100, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Bezeichnung")]
    public string Name { get; set; } = string.Empty;
    [Display(Name = "Betrag")]
    public decimal Amount { get; set; }
}

namespace DataModels.Models;
public class Discount
{
    public int Id { get; set; }
    [MaxLength(100, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Bezeichnung")]
    public string Name { get; set; } = string.Empty;
    [Display(Name = "Prozente")]
    public double Percentage { get; set; }
}
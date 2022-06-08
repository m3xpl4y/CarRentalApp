namespace DataModels.Models;

public class Fuel
{
    public int Id { get; set; }
    [MaxLength(45, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Treibstoff")]
    public string FuelType { get; set; } = string.Empty;
}
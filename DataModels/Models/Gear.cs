namespace DataModels.Models;

public class Gear
{
    public int Id { get; set; }
    [MaxLength(35, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Getriebe")]
    public string GearType { get; set; } = string.Empty;
}
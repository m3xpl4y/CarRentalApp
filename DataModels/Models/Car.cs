namespace DataModels.Models;
public class Car
{
    public int Id { get; set; }
    [MaxLength(25, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Marke")]
    public string Make { get; set; } = string.Empty;
    [MaxLength(25, ErrorMessage = "Maximal Länge überschritten")]    
    [Display(Name = "Modell")]
    
    public string Model { get; set; } = string.Empty;
    [MaxLength(45, ErrorMessage = "Maximal Länge überschritten")]    
    [Display(Name = "Variante")]
    public string Variant { get; set; } = string.Empty;
    [MaxLength(20, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Variante")]
    public string Color { get; set; } = string.Empty;
    [Display(Name = "Farbe")]
    public double PowerInKiloWatts { get; set; }
    public DateTime FirstRegistration  { get; set; }
    public OptionalEquipment OptionalEquipment { get; set; }
    public Fuel Fuel { get; set; }
    public Body BodyType{ get; set; }
    public Gear Gear { get; set; }


}

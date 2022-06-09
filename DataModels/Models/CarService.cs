namespace DataModels.Models;

public class CarService
{
    public int Id { get; set; }
    [Display(Name = "Pickerlüberprüfung")]
    public DateTime ServiceCheck { get; set; }
    [Display(Name = "Reifenwechsel")]
    public DateTime ChangeTires { get; set; }
    [Display(Name = "Ölwechsel")]
    public DateTime OilChange { get; set; }
}
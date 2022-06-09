namespace DataModels.Models;
public class Repairs
{
    public int Id { get; set; }
    [MaxLength(200, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Bezeichnung")]
    public string RepairText { get; set; } = string.Empty;
    public Car Car { get; set; }
}

public class Contract
{
    public int Id { get; set; }
    [Display(Name = "Vertrag")]
    public string ContractContent { get; set; } = string.Empty;
}
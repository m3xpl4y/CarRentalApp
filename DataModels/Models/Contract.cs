namespace DataModels.Models;

public class Contract
{
    public int Id { get; set; }
    [Display(Name = "Vertrag")]
    public string ContractContent { get; set; } = string.Empty;
}
namespace DataModels.Models;

public class Body
{
    public int Id { get; set; }
    [MaxLength(35, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Karrosierieform")]
    public string BodyType { get; set; } = string.Empty;
}
namespace DataModels.Models;

public class Promotions
{
    public int Id { get; set; }
    [MaxLength(10, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Gutschein Code")]
    public string PromotionCode { get; set; } = string.Empty; 
    [MaxLength(40, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Titel")]
    public string Title { get; set; } = string.Empty;
    [MaxLength(250, ErrorMessage = "Maximal Länge überschritten")]
    [Display(Name = "Bezeichnung")]
    public string Description { get; set; } = string.Empty;
    [Display(Name = "Prozente")]
    public double Percentage { get; set; }
}
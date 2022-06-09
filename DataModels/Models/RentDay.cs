namespace DataModels.Models;

public class RentDay
{
    public int Id { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public Car Car { get; set; }
}
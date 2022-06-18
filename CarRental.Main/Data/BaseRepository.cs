namespace CarRental.Main.Data;
public class BaseRepository
{
    public ApplicationDbContext Context() => new ApplicationDbContext();
}

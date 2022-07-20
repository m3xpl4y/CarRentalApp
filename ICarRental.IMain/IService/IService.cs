namespace ICarRental.IMain.IService;
public interface IService<T1> where T1 : class
{
    void CreateNew(T1 entity);
    Task<List<T1>> GetAll();
}

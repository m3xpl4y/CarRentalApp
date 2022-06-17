namespace ICarRental.IMain.IRepository
{
    public interface IRepository<T1, T2> where T1 : class
    {
        Task<List<T1>> GetAll();
        Task<T1> GetbyId(T2 Id);
        Task Create(T1 model);
        Task Update(T1 model);
        Task Delete(T1 model);

    }
}

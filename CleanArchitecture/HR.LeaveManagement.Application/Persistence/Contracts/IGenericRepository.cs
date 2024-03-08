namespace HR.LeaveManagement.Application.Persistence.Contracts;

//Any class can use this repository
public interface IGenericRepository<T> where T : class
{
    //Methods
    Task<T> Get(int id);
    Task<IReadOnlyList<T>> GetAll();
    Task<T> Add(T entity);
    Task Update(T entity);
    Task Delete(T entity);
}
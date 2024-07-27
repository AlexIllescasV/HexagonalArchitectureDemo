
namespace HexaArchDemo.Infrastructure.Drivens.InternalBD.Ports
{
    public interface IEntityPort<T> where T : class
    {
        Task<T> GetByIdAsync(int id);
        Task<IEnumerable<T>> GetAllAsync();
        Task AddAsync(T entity);
        Task UpdateAsync(T entity);
        Task DeleteAsync(int id);
    }
}

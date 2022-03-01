using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Contracts
{
    public interface IAsyncRepository<T> where T : class
    {
        
        Task<T> AdddAsync(T entity);
        Task<T> GetByIdAsync(string id);
        Task<IQueryable<T>> GetAllAsync();
        Task<bool> UpdatedAsync(T entity);
        Task<bool> DeleteAsync(T entity);  
    }
}

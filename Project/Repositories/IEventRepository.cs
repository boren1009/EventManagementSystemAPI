using System.Collections.Generic;
using System.Threading.Tasks;
using EventManagementSystemAPI.Models;

namespace EventManagementSystemAPI.Repositories
{
    public interface IEventRepository
    {
        Task<IEnumerable<Event>> GetAllAsync();
        Task<Event> GetByIdAsync(int id);
        Task AddAsync(Event ev);
        Task UpdateAsync(Event ev);
        Task DeleteAsync(int id);
        Task<bool> ExistsAsync(int id);
    }
}

using System.Collections.Generic;
using System.Threading.Tasks;
using EventManagementSystemAPI.Models;

namespace EventManagementSystemAPI.Services
{
    public interface IEventService
    {
        Task<IEnumerable<Event>> GetAllEventsAsync();
        Task<Event> GetEventByIdAsync(int id);
        Task AddEventAsync(Event ev);
        Task UpdateEventAsync(Event ev);
        Task DeleteEventAsync(int id);
    }
}

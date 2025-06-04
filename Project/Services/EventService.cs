using System.Collections.Generic;
using System.Threading.Tasks;
using EventManagementSystemAPI.Models;
using EventManagementSystemAPI.Repositories;

namespace EventManagementSystemAPI.Services
{
    public class EventService : IEventService
    {
        private readonly IEventRepository _repository;

        public EventService(IEventRepository repository)
        {
            _repository = repository;
        }

        public async Task<IEnumerable<Event>> GetAllEventsAsync()
        {
            return await _repository.GetAllAsync();
        }

        public async Task<Event> GetEventByIdAsync(int id)
        {
            return await _repository.GetByIdAsync(id);
        }

        public async Task AddEventAsync(Event ev)
        {
            await _repository.AddAsync(ev);
        }

        public async Task UpdateEventAsync(Event ev)
        {
            await _repository.UpdateAsync(ev);
        }

        public async Task DeleteEventAsync(int id)
        {
            await _repository.DeleteAsync(id);
        }
    }
}

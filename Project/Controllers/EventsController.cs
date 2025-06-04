using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using EventManagementSystemAPI.Models;
using EventManagementSystemAPI.Services;

namespace EventManagementSystemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly IEventService _service;

        public EventsController(IEventService service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetEvents()
        {
            var events = await _service.GetAllEventsAsync();
            return Ok(events);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var ev = await _service.GetEventByIdAsync(id);
            if (ev == null)
                return NotFound();

            return Ok(ev);
        }

        [HttpPost]
        public async Task<ActionResult> CreateEvent(Event ev)
        {
            await _service.AddEventAsync(ev);
            return CreatedAtAction(nameof(GetEvent), new { id = ev.Id }, ev);
        }

        [HttpPut("{id}")]
        public async Task<ActionResult> UpdateEvent(int id, Event ev)
        {
            if (id != ev.Id)
                return BadRequest();

            var exists = await _service.GetEventByIdAsync(id);
            if (exists == null)
                return NotFound();

            await _service.UpdateEventAsync(ev);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteEvent(int id)
        {
            var exists = await _service.GetEventByIdAsync(id);
            if (exists == null)
                return NotFound();

            await _service.DeleteEventAsync(id);
            return NoContent();
        }
    }
}

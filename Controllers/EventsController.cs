using CampusBuzzAPI.Data;
using CampusBuzzAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CampusBuzzAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EventsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public EventsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Event>>> GetAllEvents()
        {
            return await _context.Events.ToListAsync();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Event>> GetEvent(int id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null) return NotFound();
            return ev;
        }

        [HttpPost]
        public async Task<ActionResult<Event>> AddEvent(Event ev)
        {
            _context.Events.Add(ev);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(GetEvent), new { id = ev.Id }, ev);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> EditEvent(int id, Event ev)
        {
            if (id != ev.Id) return BadRequest();
            _context.Entry(ev).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            var ev = await _context.Events.FindAsync(id);
            if (ev == null) return NotFound();
            _context.Events.Remove(ev);
            await _context.SaveChangesAsync();
            return NoContent();
        }
    }
}
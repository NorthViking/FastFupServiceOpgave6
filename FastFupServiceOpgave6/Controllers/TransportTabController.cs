using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using FastFupServiceOpgave6.Model;

namespace FastFupServiceOpgave6.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransportTabController : ControllerBase
    {
        private readonly DBContext _context;

        public TransportTabController(DBContext context)
        {
            _context = context;
        }

        // GET: api/TransportTab
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TransportTab>>> GettransportTabs()
        {
            return await _context.transportTabs.ToListAsync();
        }

        // GET: api/TransportTab/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TransportTab>> GetTransportTab(int id)
        {
            var transportTab = await _context.transportTabs.FindAsync(id);

            if (transportTab == null)
            {
                return NotFound();
            }

            return transportTab;
        }

        // PUT: api/TransportTab/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTransportTab(int id, TransportTab transportTab)
        {
            if (id != transportTab.Id)
            {
                return BadRequest();
            }

            _context.Entry(transportTab).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TransportTabExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/TransportTab
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TransportTab>> PostTransportTab(TransportTab transportTab)
        {
            _context.transportTabs.Add(transportTab);
            await _context.SaveChangesAsync();

            //return CreatedAtAction("GetTransportTab", new { id = transportTab.Id }, transportTab);
            return CreatedAtAction(nameof(GetTransportTab), new { id = transportTab.Id }, transportTab);
        }

        // DELETE: api/TransportTab/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TransportTab>> DeleteTransportTab(int id)
        {
            var transportTab = await _context.transportTabs.FindAsync(id);
            if (transportTab == null)
            {
                return NotFound();
            }

            _context.transportTabs.Remove(transportTab);
            await _context.SaveChangesAsync();

            return transportTab;
        }

        private bool TransportTabExists(int id)
        {
            return _context.transportTabs.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PoolPlayingResource.Models;
using PoolPlayingResource.data;
using Microsoft.AspNetCore.Authorization;
using System.Diagnostics;

namespace PoolPlayingResource.Controllers
{
    public class VenueController : Controller
    {
        private readonly Context _context;

        public VenueController(Context context)
        {
            _context = context;
        }

        // GET: Venue
        public async Task<IActionResult> Index()
        {
            return _context.Venues != null ?
                        View(await _context.Venues.ToListAsync()) :
                        Problem("Entity set 'Context.Venues'  is null.");
        }

        // GET: Venue/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Venues == null)
            {
                return NotFound();
            }

            var venue = await _context.Venues
                .FirstOrDefaultAsync(m => m.VenueId == id);
            if (venue == null)
            {
                return NotFound();
            }

            return View(venue);
        }

        // GET: Venue/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Venue/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("VenueId,VenueName,NumberTables,VenueAddress,TableFee,TableSize")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venue);
        }


        // GET: Venue/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Venues == null)
            {
                return NotFound();
            }

            var venue = await _context.Venues.FindAsync(id);
            if (venue == null)
            {
                return NotFound();
            }
            return View(venue);
        }

        // POST: Venue/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("VenueId,VenueName,NumberTables,VenueAddress,TableFee,TableSize")] Venue venue)
        {
            if (id != venue.VenueId)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(venue);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!VenueExists(venue.VenueId))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(venue);
        }

        // GET: Venue/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Venues == null)
            {
                return NotFound();
            }

            var venue = await _context.Venues
                .FirstOrDefaultAsync(m => m.VenueId == id);
            if (venue == null)
            {
                return NotFound();
            }

            return View(venue);
        }

        // POST: Venue/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.Venues == null)
            {
                return Problem("Entity set 'Context.Venues'  is null.");
            }
            var venue = await _context.Venues.FindAsync(id);
            if (venue != null)
            {
                _context.Venues.Remove(venue);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool VenueExists(int id)
        {
          return (_context.Venues?.Any(e => e.VenueId == id)).GetValueOrDefault();
        }
        //GET: Venue/AddYourVenue
        public IActionResult AddYourVenue()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddYourVenue([Bind("VenueId,VenueName,NumberTables,VenueAddress,TableFee,TableSize")] Venue venue)
        {
            if (ModelState.IsValid)
            {
                _context.Add(venue);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(venue);
        }

        private string GetDebuggerDisplay()
        {
            return ToString();
        }
    }
}

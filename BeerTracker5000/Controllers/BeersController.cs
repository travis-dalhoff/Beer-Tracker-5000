using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BeerTracker5000.Models;

namespace BeerTracker5000.Controllers
{
    //Beer Controllers  ----  Coordinates URL requests, retrieve data, and call view templates for the CRUD portion of App
    public class BeersController : Controller
    {
        private readonly BeerTracker5000Context _context;

        public BeersController(BeerTracker5000Context context)
        {
            _context = context;    
        }

        // GET: Beers
        public async Task<IActionResult> Index()
        {
            return View(await _context.Beer.ToListAsync());
        }

        // GET: Beers/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beer = await _context.Beer
                .SingleOrDefaultAsync(m => m.ID == id);
            if (beer == null)
            {
                return NotFound();
            }

            return View(beer);
        }

        // GET: Beers/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Beers/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,BeerName,BreweryName,Style,Abv,Ibu,Rating,Notes")] Beer beer)
        {
            if (ModelState.IsValid)
            {
                _context.Add(beer);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(beer);
        }

        // GET: Beers/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beer = await _context.Beer.SingleOrDefaultAsync(m => m.ID == id);
            if (beer == null)
            {
                return NotFound();
            }
            return View(beer);
        }

        // POST: Beers/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,BeerName,BreweryName,Style,Abv,Ibu,Rating,Notes")] Beer beer)
        {
            if (id != beer.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(beer);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BeerExists(beer.ID))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Index");
            }
            return View(beer);
        }

        // GET: Beers/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var beer = await _context.Beer
                .SingleOrDefaultAsync(m => m.ID == id);
            if (beer == null)
            {
                return NotFound();
            }

            return View(beer);
        }

        // POST: Beers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var beer = await _context.Beer.SingleOrDefaultAsync(m => m.ID == id);
            _context.Beer.Remove(beer);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        private bool BeerExists(int id)
        {
            return _context.Beer.Any(e => e.ID == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using BamBoo_SoftToothbrush.Data;
using BamBoo_SoftToothbrush.Models;

namespace BamBoo_SoftToothbrush.Controllers
{
    public class BrushClassesController : Controller
    {
        private readonly BamBoo_SoftToothbrushContext _context;

        public BrushClassesController(BamBoo_SoftToothbrushContext context)
        {
            _context = context;
        }

        // GET: BrushClasses
        public async Task<IActionResult> Index()
        {
            return View(await _context.BrushClass.ToListAsync());
        }

        // GET: BrushClasses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brushClass = await _context.BrushClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (brushClass == null)
            {
                return NotFound();
            }

            return View(brushClass);
        }

        // GET: BrushClasses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: BrushClasses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("ID,ProductName,Price,BrushSize,Category")] BrushClass brushClass)
        {
            if (ModelState.IsValid)
            {
                _context.Add(brushClass);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(brushClass);
        }

        // GET: BrushClasses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brushClass = await _context.BrushClass.FindAsync(id);
            if (brushClass == null)
            {
                return NotFound();
            }
            return View(brushClass);
        }

        // POST: BrushClasses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("ID,ProductName,Price,BrushSize,Category")] BrushClass brushClass)
        {
            if (id != brushClass.ID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(brushClass);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BrushClassExists(brushClass.ID))
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
            return View(brushClass);
        }

        // GET: BrushClasses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var brushClass = await _context.BrushClass
                .FirstOrDefaultAsync(m => m.ID == id);
            if (brushClass == null)
            {
                return NotFound();
            }

            return View(brushClass);
        }

        // POST: BrushClasses/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var brushClass = await _context.BrushClass.FindAsync(id);
            _context.BrushClass.Remove(brushClass);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BrushClassExists(int id)
        {
            return _context.BrushClass.Any(e => e.ID == id);
        }
    }
}

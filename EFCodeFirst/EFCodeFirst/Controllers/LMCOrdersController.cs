using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using EFCodeFirst.Models;

namespace EFCodeFirst.Controllers
{
    public class LMCOrdersController : Controller
    {
        private readonly AzureContext _context;

        public LMCOrdersController(AzureContext context)
        {
            _context = context;
        }

        // GET: LMCOrders
        public async Task<IActionResult> Index()
        {
            return View(await _context.LMCOrders.ToListAsync());
        }

        // GET: LMCOrders/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lMCOrder = await _context.LMCOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (lMCOrder == null)
            {
                return NotFound();
            }

            return View(lMCOrder);
        }

        // GET: LMCOrders/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: LMCOrders/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("OrderID,CustomerID,EmpId,OrderDate")] LMCOrder lMCOrder)
        {
            if (ModelState.IsValid)
            {
                _context.Add(lMCOrder);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(lMCOrder);
        }

        // GET: LMCOrders/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lMCOrder = await _context.LMCOrders.FindAsync(id);
            if (lMCOrder == null)
            {
                return NotFound();
            }
            return View(lMCOrder);
        }

        // POST: LMCOrders/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("OrderID,CustomerID,EmpId,OrderDate")] LMCOrder lMCOrder)
        {
            if (id != lMCOrder.OrderID)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(lMCOrder);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!LMCOrderExists(lMCOrder.OrderID))
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
            return View(lMCOrder);
        }

        // GET: LMCOrders/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var lMCOrder = await _context.LMCOrders
                .FirstOrDefaultAsync(m => m.OrderID == id);
            if (lMCOrder == null)
            {
                return NotFound();
            }

            return View(lMCOrder);
        }

        // POST: LMCOrders/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var lMCOrder = await _context.LMCOrders.FindAsync(id);
            _context.LMCOrders.Remove(lMCOrder);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool LMCOrderExists(int id)
        {
            return _context.LMCOrders.Any(e => e.OrderID == id);
        }
    }
}

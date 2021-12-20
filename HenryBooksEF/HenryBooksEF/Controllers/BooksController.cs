using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using HenryBooksEF.Models;

namespace HenryBooksEF.Controllers
{
    public class BooksController : Controller
    {
        private readonly cottrell2021Context _context;

        public BooksController(cottrell2021Context context)
        {
            _context = context;
        }

        // GET: Books
        /* public async Task<IActionResult> Index()
         {
             var cottrell2021Context = _context.Books.Include(b => b.PublisherCodeNavigation);
            // var cottrell2021Context = _context.Books.Where(b => b.Type.Equals("FIC")).Include(b => b.PublisherCodeNavigation);
             return View(await cottrell2021Context.ToListAsync());
         }
        */
        public async Task<IActionResult> Index(string sortOrder, string searchString)
        {
            var books = from b in _context.Books
                        select b;

            ViewData["TitleSortParam"] = String.IsNullOrEmpty(sortOrder) ? "title_sort" : "";//default
            ViewData["TypeSortParam"] = sortOrder == "Type" ? "type_sort" : "type_sort";
            ViewData["CurrentFilter"] = searchString;

            if (!String.IsNullOrEmpty(searchString))
            {
                books = books.Where(b => b.Title.Contains(searchString));
            }

            switch (sortOrder)
            {
                case "type_sort":
                    books = books.OrderBy(b => b.Type);
                    break;

                case "title_sort":
                default:
                    books = books.OrderBy(b => b.Title);
                    break;
            }

            return View(await books.AsNoTracking().ToListAsync());
        }


        // GET: Books/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.PublisherCodeNavigation)
                .FirstOrDefaultAsync(m => m.BookCode == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // GET: Books/Create
        public IActionResult Create()
        {
            ViewData["PublisherCode"] = new SelectList(_context.Publishers, "PublisherCode", "PublisherCode");
            return View();
        }

        // POST: Books/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("BookCode,Title,PublisherCode,Type,Paperback")] Book book)
        {
            if (ModelState.IsValid)
            {
                _context.Add(book);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["PublisherCode"] = new SelectList(_context.Publishers, "PublisherCode", "PublisherCode", book.PublisherCode);
            return View(book);
        }

        // GET: Books/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books.FindAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            ViewData["PublisherCode"] = new SelectList(_context.Publishers, "PublisherCode", "PublisherCode", book.PublisherCode);
            return View(book);
        }

        // POST: Books/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("BookCode,Title,PublisherCode,Type,Paperback")] Book book)
        {
            if (id != book.BookCode)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(book);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!BookExists(book.BookCode))
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
            ViewData["PublisherCode"] = new SelectList(_context.Publishers, "PublisherCode", "PublisherCode", book.PublisherCode);
            return View(book);
        }

        // GET: Books/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = await _context.Books
                .Include(b => b.PublisherCodeNavigation)
                .FirstOrDefaultAsync(m => m.BookCode == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }

        // POST: Books/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var book = await _context.Books.FindAsync(id);
            _context.Books.Remove(book);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool BookExists(string id)
        {
            return _context.Books.Any(e => e.BookCode == id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Esmeraldaplus.Core.Domain;
using Esmeraldaplus.Infrastructure.Data;

namespace Esmeraldaplus.Web.Controllers
{
    public class OrdenDeVentaController : Controller
    {
        private readonly EsmeraldaplusDbContext _context;

        public OrdenDeVentaController(EsmeraldaplusDbContext context)
        {
            _context = context;
        }

        // GET: OrdenDeVenta
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdenDeVenta.ToListAsync());
        }

        // GET: OrdenDeVenta/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeVenta = await _context.OrdenDeVenta
                .FirstOrDefaultAsync(m => m.IdOrdenVenta == id);
            if (ordenDeVenta == null)
            {
                return NotFound();
            }

            return View(ordenDeVenta);
        }

        // GET: OrdenDeVenta/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdenDeVenta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOrdenVenta,CantidadProducto,ValorUnitario,ValorTotal")] OrdenDeVenta ordenDeVenta)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenDeVenta);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordenDeVenta);
        }

        // GET: OrdenDeVenta/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeVenta = await _context.OrdenDeVenta.FindAsync(id);
            if (ordenDeVenta == null)
            {
                return NotFound();
            }
            return View(ordenDeVenta);
        }

        // POST: OrdenDeVenta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOrdenVenta,CantidadProducto,ValorUnitario,ValorTotal")] OrdenDeVenta ordenDeVenta)
        {
            if (id != ordenDeVenta.IdOrdenVenta)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenDeVenta);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenDeVentaExists(ordenDeVenta.IdOrdenVenta))
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
            return View(ordenDeVenta);
        }

        // GET: OrdenDeVenta/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeVenta = await _context.OrdenDeVenta
                .FirstOrDefaultAsync(m => m.IdOrdenVenta == id);
            if (ordenDeVenta == null)
            {
                return NotFound();
            }

            return View(ordenDeVenta);
        }

        // POST: OrdenDeVenta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordenDeVenta = await _context.OrdenDeVenta.FindAsync(id);
            _context.OrdenDeVenta.Remove(ordenDeVenta);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenDeVentaExists(int id)
        {
            return _context.OrdenDeVenta.Any(e => e.IdOrdenVenta == id);
        }
    }
}

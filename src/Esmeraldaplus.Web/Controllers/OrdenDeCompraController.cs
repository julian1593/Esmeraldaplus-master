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
    public class OrdenDeCompraController : Controller
    {
        private readonly EsmeraldaplusDbContext _context;

        public OrdenDeCompraController(EsmeraldaplusDbContext context)
        {
            _context = context;
        }

        // GET: OrdenDeCompra
        public async Task<IActionResult> Index()
        {
            return View(await _context.OrdenDeCompra.ToListAsync());
        }

        // GET: OrdenDeCompra/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeCompra = await _context.OrdenDeCompra
                .FirstOrDefaultAsync(m => m.IdOrdenCompra == id);
            if (ordenDeCompra == null)
            {
                return NotFound();
            }

            return View(ordenDeCompra);
        }

        // GET: OrdenDeCompra/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: OrdenDeCompra/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdOrdenCompra,NombreProveedor,ValorUnitarioProducto,ValorTotalProducto,Producto")] OrdenDeCompra ordenDeCompra)
        {
            if (ModelState.IsValid)
            {
                _context.Add(ordenDeCompra);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(ordenDeCompra);
        }

        // GET: OrdenDeCompra/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeCompra = await _context.OrdenDeCompra.FindAsync(id);
            if (ordenDeCompra == null)
            {
                return NotFound();
            }
            return View(ordenDeCompra);
        }

        // POST: OrdenDeCompra/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdOrdenCompra,NombreProveedor,ValorUnitarioProducto,ValorTotalProducto,Producto")] OrdenDeCompra ordenDeCompra)
        {
            if (id != ordenDeCompra.IdOrdenCompra)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(ordenDeCompra);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!OrdenDeCompraExists(ordenDeCompra.IdOrdenCompra))
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
            return View(ordenDeCompra);
        }

        // GET: OrdenDeCompra/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var ordenDeCompra = await _context.OrdenDeCompra
                .FirstOrDefaultAsync(m => m.IdOrdenCompra == id);
            if (ordenDeCompra == null)
            {
                return NotFound();
            }

            return View(ordenDeCompra);
        }

        // POST: OrdenDeCompra/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var ordenDeCompra = await _context.OrdenDeCompra.FindAsync(id);
            _context.OrdenDeCompra.Remove(ordenDeCompra);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool OrdenDeCompraExists(int id)
        {
            return _context.OrdenDeCompra.Any(e => e.IdOrdenCompra == id);
        }
    }
}

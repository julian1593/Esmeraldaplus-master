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
    public class EstadoDePedidoController : Controller
    {
        private readonly EsmeraldaplusDbContext _context;

        public EstadoDePedidoController(EsmeraldaplusDbContext context)
        {
            _context = context;
        }

        // GET: EstadoDePedido
        public async Task<IActionResult> Index()
        {
            return View(await _context.EstadoDePedido.ToListAsync());
        }

        // GET: EstadoDePedido/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDePedido = await _context.EstadoDePedido
                .FirstOrDefaultAsync(m => m.IdEstadoPedido == id);
            if (estadoDePedido == null)
            {
                return NotFound();
            }

            return View(estadoDePedido);
        }

        // GET: EstadoDePedido/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: EstadoDePedido/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdEstadoPedido,NombreEstadoPedido")] EstadoDePedido estadoDePedido)
        {
            if (ModelState.IsValid)
            {
                _context.Add(estadoDePedido);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(estadoDePedido);
        }

        // GET: EstadoDePedido/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDePedido = await _context.EstadoDePedido.FindAsync(id);
            if (estadoDePedido == null)
            {
                return NotFound();
            }
            return View(estadoDePedido);
        }

        // POST: EstadoDePedido/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdEstadoPedido,NombreEstadoPedido")] EstadoDePedido estadoDePedido)
        {
            if (id != estadoDePedido.IdEstadoPedido)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(estadoDePedido);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!EstadoDePedidoExists(estadoDePedido.IdEstadoPedido))
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
            return View(estadoDePedido);
        }

        // GET: EstadoDePedido/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var estadoDePedido = await _context.EstadoDePedido
                .FirstOrDefaultAsync(m => m.IdEstadoPedido == id);
            if (estadoDePedido == null)
            {
                return NotFound();
            }

            return View(estadoDePedido);
        }

        // POST: EstadoDePedido/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var estadoDePedido = await _context.EstadoDePedido.FindAsync(id);
            _context.EstadoDePedido.Remove(estadoDePedido);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool EstadoDePedidoExists(int id)
        {
            return _context.EstadoDePedido.Any(e => e.IdEstadoPedido == id);
        }
    }
}

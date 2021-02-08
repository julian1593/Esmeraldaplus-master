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
    public class InventarioController : Controller
    {
        private readonly EsmeraldaplusDbContext _context;

        public InventarioController(EsmeraldaplusDbContext context)
        {
            _context = context;
        }

        // GET: Inventario
        public async Task<IActionResult> Index()
        {
            var esmeraldaplusDbContext = _context.Inventario.Include(i => i.IdOrdenCompraNavigation).Include(i => i.IdOrdenVentaNavigation).Include(i => i.IdPedidoNavigation).Include(i => i.IdProductoNavigation).Include(i => i.IdUsuarioNavigation);
            return View(await esmeraldaplusDbContext.ToListAsync());
        }

        // GET: Inventario/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario
                .Include(i => i.IdOrdenCompraNavigation)
                .Include(i => i.IdOrdenVentaNavigation)
                .Include(i => i.IdPedidoNavigation)
                .Include(i => i.IdProductoNavigation)
                .Include(i => i.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // GET: Inventario/Create
        public IActionResult Create()
        {
            ViewData["IdOrdenCompra"] = new SelectList(_context.OrdenDeCompra, "IdOrdenCompra", "IdOrdenCompra");
            ViewData["IdOrdenVenta"] = new SelectList(_context.OrdenDeVenta, "IdOrdenVenta", "IdOrdenVenta");
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "IdPedido");
            ViewData["IdProducto"] = new SelectList(_context.Producto,"IdProducto", "IdTipoProducto");
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario");
            return View();
        }

        // POST: Inventario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("IdInventario,FechaIngreso,IdUsuario,IdOrdenCompra,IdOrdenVenta,IdPedido,IdProducto")] Inventario inventario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(inventario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["IdOrdenCompra"] = new SelectList(_context.OrdenDeCompra, "IdOrdenCompra", "Producto", inventario.IdOrdenCompra);
            ViewData["IdOrdenVenta"] = new SelectList(_context.OrdenDeVenta, "IdOrdenVenta", "IdOrdenVenta", inventario.IdOrdenVenta);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "IdUsuario", inventario.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", inventario.IdProducto);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", inventario.IdUsuario);
            return View(inventario);
        }

        // GET: Inventario/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario.FindAsync(id);
            if (inventario == null)
            {
                return NotFound();
            }
            ViewData["IdOrdenCompra"] = new SelectList(_context.OrdenDeCompra, "IdOrdenCompra", "Producto", inventario.IdOrdenCompra);
            ViewData["IdOrdenVenta"] = new SelectList(_context.OrdenDeVenta, "IdOrdenVenta", "IdOrdenVenta", inventario.IdOrdenVenta);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "IdUsuario", inventario.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", inventario.IdProducto);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", inventario.IdUsuario);
            return View(inventario);
        }

        // POST: Inventario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("IdInventario,FechaIngreso,IdUsuario,IdOrdenCompra,IdOrdenVenta,IdPedido,IdProducto")] Inventario inventario)
        {
            if (id != inventario.IdInventario)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(inventario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InventarioExists(inventario.IdInventario))
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
            ViewData["IdOrdenCompra"] = new SelectList(_context.OrdenDeCompra, "IdOrdenCompra", "Producto", inventario.IdOrdenCompra);
            ViewData["IdOrdenVenta"] = new SelectList(_context.OrdenDeVenta, "IdOrdenVenta", "IdOrdenVenta", inventario.IdOrdenVenta);
            ViewData["IdPedido"] = new SelectList(_context.Pedido, "IdPedido", "IdUsuario", inventario.IdPedido);
            ViewData["IdProducto"] = new SelectList(_context.Producto, "IdProducto", "IdProducto", inventario.IdProducto);
            ViewData["IdUsuario"] = new SelectList(_context.Usuarios, "IdUsuario", "IdUsuario", inventario.IdUsuario);
            return View(inventario);
        }

        // GET: Inventario/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var inventario = await _context.Inventario
                .Include(i => i.IdOrdenCompraNavigation)
                .Include(i => i.IdOrdenVentaNavigation)
                .Include(i => i.IdPedidoNavigation)
                .Include(i => i.IdProductoNavigation)
                .Include(i => i.IdUsuarioNavigation)
                .FirstOrDefaultAsync(m => m.IdInventario == id);
            if (inventario == null)
            {
                return NotFound();
            }

            return View(inventario);
        }

        // POST: Inventario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var inventario = await _context.Inventario.FindAsync(id);
            _context.Inventario.Remove(inventario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InventarioExists(int id)
        {
            return _context.Inventario.Any(e => e.IdInventario == id);
        }
    }
}

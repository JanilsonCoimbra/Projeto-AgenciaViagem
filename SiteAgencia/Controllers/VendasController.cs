using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SiteAgencia.Models;

namespace SiteAgencia.Controllers
{
    public class VendasController : Controller
    {
        private readonly Conectar _context;

        public VendasController(Conectar context)
        {
            _context = context;
        }

        // GET: Vendas
        public async Task<IActionResult> Index()
        {
            var conectar = _context.Compra.Include(c => c.cliente).Include(c => c.destino);
            return View(await conectar.ToListAsync());
        }

        // GET: Vendas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compra
                .Include(c => c.cliente)
                .Include(c => c.destino)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // GET: Vendas/Create
        public IActionResult Create()
        {
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nome");
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Destino");
            return View();
        }

        // POST: Vendas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,ClienteId,DestinoId")] Compras compras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nome", compras.ClienteId);
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Destino", compras.DestinoId);
            return View(compras);
        }

        // GET: Vendas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compra.FindAsync(id);
            if (compras == null)
            {
                return NotFound();
            }
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Nome", compras.ClienteId);
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Destino", compras.DestinoId);
            return View(compras);
        }

        // POST: Vendas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,ClienteId,DestinoId")] Compras compras)
        {
            if (id != compras.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(compras);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ComprasExists(compras.Id))
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
            ViewData["ClienteId"] = new SelectList(_context.Cliente, "Id", "Email", compras.ClienteId);
            ViewData["DestinoId"] = new SelectList(_context.Destino, "Id", "Id", compras.DestinoId);
            return View(compras);
        }

        // GET: Vendas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.Compra
                .Include(c => c.cliente)
                .Include(c => c.destino)
                .FirstOrDefaultAsync(m => m.Id == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // POST: Vendas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compras = await _context.Compra.FindAsync(id);
            _context.Compra.Remove(compras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComprasExists(int id)
        {
            return _context.Compra.Any(e => e.Id == id);
        }
    }
}

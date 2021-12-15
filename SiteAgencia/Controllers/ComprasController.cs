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
    public class ComprasController : Controller
    {
        private readonly Conectar _context;

        public ComprasController(Conectar context)
        {
            _context = context;
        }

        // GET: Compras
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroCompra.ToListAsync());
        }

        // GET: Compras/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.CadastroCompra
                .FirstOrDefaultAsync(m => m.id_compra == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // GET: Compras/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Compras/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("id_compra,id_cliente,id_destino")] Compras compras)
        {
            if (ModelState.IsValid)
            {
                _context.Add(compras);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(compras);
        }

        // GET: Compras/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.CadastroCompra.FindAsync(id);
            if (compras == null)
            {
                return NotFound();
            }
            return View(compras);
        }

        // POST: Compras/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("id_compra,id_cliente,id_destino")] Compras compras)
        {
            if (id != compras.id_compra)
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
                    if (!ComprasExists(compras.id_compra))
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
            return View(compras);
        }

        // GET: Compras/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var compras = await _context.CadastroCompra
                .FirstOrDefaultAsync(m => m.id_compra == id);
            if (compras == null)
            {
                return NotFound();
            }

            return View(compras);
        }

        // POST: Compras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var compras = await _context.CadastroCompra.FindAsync(id);
            _context.CadastroCompra.Remove(compras);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ComprasExists(int id)
        {
            return _context.CadastroCompra.Any(e => e.id_compra == id);
        }
    }
}

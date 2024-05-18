using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ChurnAnalitycs.Data;
using ChurnAnalitycs.Models;

namespace ChurnAnalitycs.Controllers
{
    public class InfoAdicionalsController : Controller
    {
        private readonly DataContext _context;

        public InfoAdicionalsController(DataContext context)
        {
            _context = context;
        }

        // GET: InfoAdicionals
        public async Task<IActionResult> Index()
        {
            return View(await _context.InfoAdicionais.ToListAsync());
        }

        // GET: InfoAdicionals/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoAdicional = await _context.InfoAdicionais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoAdicional == null)
            {
                return NotFound();
            }

            return View(infoAdicional);
        }

        // GET: InfoAdicionals/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: InfoAdicionals/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,NomeIntegracaoSistema,InfoProdutosServicos,OutrasInformacoesSetor,SegmentacaoClientes,PersonaCliente,EstruturaOrganizacional,InformacoesRegulatoriasConformidade,ObjetivosMetasEstrategicas")] InfoAdicional infoAdicional)
        {
            if (ModelState.IsValid)
            {
                _context.Add(infoAdicional);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(infoAdicional);
        }

        // GET: InfoAdicionals/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoAdicional = await _context.InfoAdicionais.FindAsync(id);
            if (infoAdicional == null)
            {
                return NotFound();
            }
            return View(infoAdicional);
        }

        // POST: InfoAdicionals/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,NomeIntegracaoSistema,InfoProdutosServicos,OutrasInformacoesSetor,SegmentacaoClientes,PersonaCliente,EstruturaOrganizacional,InformacoesRegulatoriasConformidade,ObjetivosMetasEstrategicas")] InfoAdicional infoAdicional)
        {
            if (id != infoAdicional.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(infoAdicional);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!InfoAdicionalExists(infoAdicional.Id))
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
            return View(infoAdicional);
        }

        // GET: InfoAdicionals/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var infoAdicional = await _context.InfoAdicionais
                .FirstOrDefaultAsync(m => m.Id == id);
            if (infoAdicional == null)
            {
                return NotFound();
            }

            return View(infoAdicional);
        }

        // POST: InfoAdicionals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var infoAdicional = await _context.InfoAdicionais.FindAsync(id);
            if (infoAdicional != null)
            {
                _context.InfoAdicionais.Remove(infoAdicional);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool InfoAdicionalExists(int id)
        {
            return _context.InfoAdicionais.Any(e => e.Id == id);
        }
    }
}

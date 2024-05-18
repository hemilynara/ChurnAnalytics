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
    public class CadastroEmpresasController : Controller
    {
        private readonly DataContext _context;

        public CadastroEmpresasController(DataContext context)
        {
            _context = context;
        }

        // GET: CadastroEmpresas
        public async Task<IActionResult> Index()
        {
            return View(await _context.CadastroEmpresas.ToListAsync());
        }

        // GET: CadastroEmpresas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroEmpresa = await _context.CadastroEmpresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroEmpresa == null)
            {
                return NotFound();
            }

            return View(cadastroEmpresa);
        }

        // GET: CadastroEmpresas/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: CadastroEmpresas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,RazaoSocial,CNPJ,SetorAtuacao,Porte,Endereco,Numero,Bairro,Cidade,Estado,CEP,Pais,NomeContatoPrincipal,CargoContatoPrincipal,EmailContato,TelefoneContato,ProdutoServicoAdquirido,ValorCompra,ReceitaAnual,Lucratividade")] CadastroEmpresa cadastroEmpresa)
        {
            if (ModelState.IsValid)
            {
                _context.Add(cadastroEmpresa);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(cadastroEmpresa);
        }

        // GET: CadastroEmpresas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroEmpresa = await _context.CadastroEmpresas.FindAsync(id);
            if (cadastroEmpresa == null)
            {
                return NotFound();
            }
            return View(cadastroEmpresa);
        }

        // POST: CadastroEmpresas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,RazaoSocial,CNPJ,SetorAtuacao,Porte,Endereco,Numero,Bairro,Cidade,Estado,CEP,Pais,NomeContatoPrincipal,CargoContatoPrincipal,EmailContato,TelefoneContato,ProdutoServicoAdquirido,ValorCompra,ReceitaAnual,Lucratividade")] CadastroEmpresa cadastroEmpresa)
        {
            if (id != cadastroEmpresa.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(cadastroEmpresa);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!CadastroEmpresaExists(cadastroEmpresa.Id))
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
            return View(cadastroEmpresa);
        }

        // GET: CadastroEmpresas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var cadastroEmpresa = await _context.CadastroEmpresas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (cadastroEmpresa == null)
            {
                return NotFound();
            }

            return View(cadastroEmpresa);
        }

        // POST: CadastroEmpresas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var cadastroEmpresa = await _context.CadastroEmpresas.FindAsync(id);
            if (cadastroEmpresa != null)
            {
                _context.CadastroEmpresas.Remove(cadastroEmpresa);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool CadastroEmpresaExists(int id)
        {
            return _context.CadastroEmpresas.Any(e => e.Id == id);
        }
    }
}

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;
using Word_no_Navegador.Data;
using Word_no_Navegador.Models;

namespace Word_no_Navegador.Controllers
{
    public class HomeController : Controller
    {
        readonly private ApplicationDbContext _context;
        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
             var documentos = await _context.Documentos.ToListAsync();

            return View(documentos);
        }

        public IActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Cadastrar (DocumentoModel documento)
        {
            if(ModelState.IsValid)
            {
                _context.Add(documento);
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(documento);  
        }

        public IActionResult Editar(int id)
        {
            var documento = _context.Documentos.FirstOrDefault(x=>x.ID == id);

            return View(documento);
        } 

        [HttpPost]
        public async Task<IActionResult> Editar(DocumentoModel documento)
        {
            if (ModelState.IsValid)
            {
                DocumentoModel documento_atualizado = documento;
                documento_atualizado.ID = documento.ID;
                documento_atualizado.Conteudo = documento.Conteudo;
                documento_atualizado.DataAtualizacao = documento.DataAtualizacao;
                documento_atualizado.DataAtualizacao = DateTime.Now;
                _context.Update(documento_atualizado); 
                await _context.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(documento);
        }
        public async Task<IActionResult> Excluir(int id)
        {
            var documento = await _context.Documentos.FirstOrDefaultAsync(x=>x.ID == id);

            _context.Documentos.Remove(documento);  
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        
    }
}

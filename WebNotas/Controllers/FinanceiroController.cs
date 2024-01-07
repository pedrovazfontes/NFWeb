using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using WebNotas.Data;
using WebNotas.Models;
using WebNotas.Repository;

namespace WebNotas.Controllers
{
    
    public class FinanceiroController : Controller
    {
        private readonly INotasRepository _notasRepository;

        public FinanceiroController(INotasRepository notasRepository)
        {
            _notasRepository = notasRepository;
        }
     
        // GET: Financeiro/Create
        [HttpGet]
        public IActionResult Criar()
        {
            return View("../Financeiro/Create") ;
        }

        // POST: Financeiro/Create
        [HttpPost]
        public IActionResult CadastrarNF(NF nota)
        {
            _notasRepository.CriarNF(nota);
            return RedirectToAction("ListarNFs");
        }

        [HttpGet]
        public IActionResult ListarNFs()
        {
            List<NF> nfs = _notasRepository.ListarTodasNF();
            return View(nfs);
        }

        [HttpGet]
        public IActionResult ListarNFPorNum(int numero)
        {
            _notasRepository.ListarPorNumero(numero);
            return View();
        }

        [HttpPost]
        public IActionResult EditarNF(NF nota) 
        {
            _notasRepository.Atualizar(nota);
            return View();  
        
        }

        public IActionResult TesteLista()
        {
            return View("../Financeiro/ListarNFs");
        }

    
    }
}

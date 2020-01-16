using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using TestePagueVeloz.Models;
using TestePagueVeloz.ViewModel;

namespace TestePagueVeloz.Controllers
{
    public class EmpresasController : Controller
    {
        private TesteContext contexto;

        public EmpresasController(TesteContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult AdicionarEmpresa()
        {
            return View();
        }

        public IActionResult Listar()
        {
            var empresas = contexto.Empresas.ToList();
            return View(empresas);
        }

        [HttpPost]
        public IActionResult AdicionarEmpresa(EmpresaViewModel empresa)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var empresaParaAdicionar = new Empresa(empresa.UF, empresa.CNPJ, empresa.NomeFantasia);
                    contexto.Empresas.Add(empresaParaAdicionar);
                    contexto.SaveChanges();
                }

                return RedirectToAction("Listar");
            }
            catch(Exception e)
            {
                ViewBag.Error = e.Message;
            }
            return View();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TestePagueVeloz.Models;
using TestePagueVeloz.ViewModel;

namespace TestePagueVeloz.Controllers
{
    public class FornecedoresController : Controller
    {

        private TesteContext contexto;

        public FornecedoresController(TesteContext contexto)
        {
            this.contexto = contexto;
        }

        public IActionResult Listar()
        {
            var fornecedores = contexto.Fornecedores.Include(e => e.Empresa).ToList();

            return View(fornecedores);
        }

        public IActionResult NovoFornecedor()
        {

            ViewBag.Empresas = contexto.Empresas.ToList();
            return View();
        }

        [HttpPost]
        public IActionResult NovoFornecedor(FornecedorViewModel fornecedor)
        {
            try
            {
                var novoFornecedor = new Fornecedor();

                var empresa = contexto.Empresas.Where(e => e.EmpresaId == fornecedor.EmpresaId).SingleOrDefault();
                if (string.IsNullOrEmpty(fornecedor.Rg))
                {

                    novoFornecedor = new Fornecedor(
                                                fornecedor.Nome,
                                                fornecedor.CnpjOuCPpf,
                                                DateTime.Now,
                                                fornecedor.Telefone,
                                                empresa
                                                );

                }
                else
                {
                    novoFornecedor = new Fornecedor(
                                        fornecedor.Nome,
                                        fornecedor.CnpjOuCPpf,
                                        fornecedor.Rg,
                                        DateTime.Now,
                                        fornecedor.DataDeNascimento,
                                        fornecedor.Telefone,
                                        empresa
                                        );

                }

                contexto.Fornecedores.Add(novoFornecedor);
                contexto.SaveChanges();
                return RedirectToAction("Listar");
            }
            catch (Exception e)
            {
                ViewBag.Error = e.Message;

            }
            ViewBag.Empresas = contexto.Empresas.ToList();
            return View();
        }

        public IActionResult Deletar(int fornecedorId)
        {
           var fornecedor =  contexto.Fornecedores.Where(f => f.FornecedorId == fornecedorId).SingleOrDefault();
            contexto.Fornecedores.Remove(fornecedor);
            contexto.SaveChanges();
            return RedirectToAction("Listar");
        }
    }
}
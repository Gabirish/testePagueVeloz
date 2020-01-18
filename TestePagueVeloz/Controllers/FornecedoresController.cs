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

            var empresas = contexto.Empresas.ToList();

            ViewBag.Empresas = empresas;
            return View(fornecedores);
        }

        [HttpGet("/BuscarFornecedor/{idFornecedor}")]
        public Fornecedor BuscarFornecedor(int idFornecedor)
        {
            var fornecedor = contexto.Fornecedores.Include(e => e.Empresa).Where(f => f.FornecedorId == idFornecedor).SingleOrDefault();

            return fornecedor;
        }

        public IActionResult NovoFornecedor()
        {

            ViewBag.Empresas = contexto.Empresas.ToList();
            return View();
        }

        [HttpPost("/AtualizarFornecedor")]
        public bool AtualizarFornecedor(Fornecedor pFornecedor)
        {
            try
            {
                var fornecedor = contexto.Fornecedores.Where(f => f.FornecedorId == pFornecedor.FornecedorId).SingleOrDefault();
                if (!string.IsNullOrEmpty(pFornecedor.CnpjOuCpf) && pFornecedor.CnpjOuCpf != fornecedor.CnpjOuCpf)
                {
                    fornecedor.CnpjOuCpf = pFornecedor.CnpjOuCpf;
                }
                if (DateTime.MinValue != pFornecedor.DataDeNascimento && pFornecedor.DataDeNascimento != fornecedor.DataDeNascimento)
                {
                    fornecedor.DataDeNascimento = pFornecedor.DataDeNascimento;
                }
                if (pFornecedor.EmpresaId != 0 && pFornecedor.EmpresaId != fornecedor.EmpresaId)
                {
                    var empresa = contexto.Empresas.Where(e=> e.EmpresaId == pFornecedor.EmpresaId).SingleOrDefault();
                    var hoje = DateTime.Now;
                    if (empresa.Uf == UF.PR && hoje < pFornecedor.DataDeNascimento.AddYears(18))
                    {
                        return false;
                    }
                    
                    fornecedor.EmpresaId = pFornecedor.EmpresaId;
                }
                if (!string.IsNullOrEmpty(pFornecedor.Nome) && pFornecedor.Nome != fornecedor.Nome)
                {
                    fornecedor.Nome = pFornecedor.Nome;
                }
                if (!string.IsNullOrEmpty(pFornecedor.Rg) && pFornecedor.Rg != fornecedor.Rg)
                {
                    fornecedor.Rg = pFornecedor.Rg;
                }
                if (!string.IsNullOrEmpty(pFornecedor.Telefone) && pFornecedor.Telefone != fornecedor.Telefone)
                {
                    fornecedor.Telefone = pFornecedor.Telefone;
                }

                contexto.Fornecedores.Update(fornecedor);
                contexto.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }
        }

        [HttpPost]
        public IActionResult NovoFornecedor(FornecedorViewModel fornecedor)
        {
            try
            {
                var novoFornecedor = new Fornecedor();

                var empresa = contexto.Empresas.Where(e => e.EmpresaId == fornecedor.EmpresaId).SingleOrDefault();
                if (fornecedor.CnpjOuCPpf.Length == 18)
                {

                    novoFornecedor = new Fornecedor(
                                                fornecedor.Nome,
                                                fornecedor.CnpjOuCPpf,
                                                DateTime.Now,
                                                fornecedor.Telefone,
                                                empresa
                                                );

                }
                else if (fornecedor.CnpjOuCPpf.Length == 14)
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
            var fornecedor = contexto.Fornecedores.Where(f => f.FornecedorId == fornecedorId).SingleOrDefault();
            contexto.Fornecedores.Remove(fornecedor);
            contexto.SaveChanges();
            return RedirectToAction("Listar");
        }
    }
}
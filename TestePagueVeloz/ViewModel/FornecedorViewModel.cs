using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TestePagueVeloz.Models;

namespace TestePagueVeloz.ViewModel
{
    public class FornecedorViewModel
    {
        public string Nome { get; set; }
        [Display(Name="CPF / CNPJ")]
        public string CnpjOuCPpf { get; set; }
        public string Rg { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public string Telefone { get; set; }
        public Empresa Empresa { get; set; }
        public int EmpresaId { get; set; }
    }
}
